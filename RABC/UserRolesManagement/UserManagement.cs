using DevExpress.XtraEditors;
using Newtonsoft.Json;
using RABC;
using RABC.BLL;
using RABC.Model.QueryModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WMS.Model.ViewModels;

namespace WMS.UserRolesManagement
{
    public partial class UserManagement : UserControl
    {
        List<FormRoleMenuAuthoritiesVM> _roleMenuAuthorityList = null;
        private UserManagerBll _bll = null;
        public UserManagement()
        {
            InitializeComponent();
            _bll = new UserManagerBll();
        }
        private void FrmUserManagement_Load(object sender, EventArgs e)
        {
            GetFormRoleMenuAuthorities("FrmUserManagement");
            RequestGridData();
        }

        public void GetFormRoleMenuAuthorities(string formName)
        {
            this._roleMenuAuthorityList =_bll.GetFormRoleMenuAuthorities(new FormRoleMenuAuthoritiesVM { Account = GlobalObject.User.Account, FormName = formName });
            InitUI();
          
            if (this._roleMenuAuthorityList.Any(p => p.AuthorityName == "Query"))
            {
                RequestGridData();
            }
        }
        private void InitUI()
        {
            if (!GlobalObject.UserRoles.Any(p => p.RoleName == "admin"))
            {
                for (int i = 0; i < this.panelSave.Controls.Count; i++)
                {
                    SimpleButton sb = this.panelSave.Controls[i] as SimpleButton;
                    string name = this.panelSave.Controls[i].Name;
                    if (sb != null)
                    {
                        continue;
                    }
                    this.panelSave.Controls.Remove(this.panelSave.Controls[i]);
                    i--;
                }

                //lblAccount
                Label lblAccount = new Label();
                lblAccount.AutoSize = true;
                lblAccount.Location = new System.Drawing.Point(12, 28);
                lblAccount.Text = "Account:";
                lblAccount.Name = "lblAccount";
                this.panelSave.Controls.Add(lblAccount);

                //teAccount
                TextEdit teAddAccount = new TextEdit();
                teAddAccount.Location = new System.Drawing.Point(lblAccount.Location.X + lblAccount.Size.Width + 5, 25);
                teAddAccount.Size = new System.Drawing.Size(100, 20);
                teAddAccount.Name = "teAddAccount";
                teAddAccount.Text = GlobalObject.User.Account;
                teAddAccount.ReadOnly = true;
                this.panelSave.Controls.Add(teAddAccount);

                Label lblOldPassword = new Label();
                lblOldPassword.Location = new System.Drawing.Point(teAddAccount.Location.X + teAddAccount.Size.Width + 5, 28);
                lblOldPassword.AutoSize = true;
                lblOldPassword.Text = "Old Password:";
                lblOldPassword.Name = "OldPassword";
                this.panelSave.Controls.Add(lblOldPassword);

                //teOldPassword
                TextEdit teAddOldPassword = new TextEdit();
                teAddOldPassword.Location = new System.Drawing.Point(lblOldPassword.Location.X + lblOldPassword.Size.Width + 5, 25);
                teAddOldPassword.Name = "teAddOldPassword";
                teAddOldPassword.Properties.PasswordChar = '*';
                teAddOldPassword.Size = new System.Drawing.Size(100, 20);
                this.panelSave.Controls.Add(teAddOldPassword);

                //lblNewPassword
                Label lblNewPassword = new Label();
                lblNewPassword.AutoSize = true;
                lblNewPassword.Location = new System.Drawing.Point(teAddOldPassword.Location.X + teAddOldPassword.Size.Width + 5, 28);
                lblNewPassword.Text = "New Password:";
                lblNewPassword.Name = "lblNewPassword";
                this.panelSave.Controls.Add(lblNewPassword);

                //teNewPassword
                TextEdit teAddNewPassword = new TextEdit();
                teAddNewPassword.Location = new System.Drawing.Point(lblNewPassword.Location.X + lblNewPassword.Size.Width + 5, 25);
                teAddNewPassword.Name = "teAddNewPassword";
                teAddNewPassword.Properties.PasswordChar = '*';
                teAddNewPassword.Size = new System.Drawing.Size(100, 20);
                this.panelSave.Controls.Add(teAddNewPassword);

                //lblConfirmPassword
                Label lblConfirmPassword = new Label();
                lblConfirmPassword.AutoSize = true;
                lblConfirmPassword.Location = new System.Drawing.Point(teAddNewPassword.Location.X + teAddNewPassword.Size.Width + 5, 28);
                lblConfirmPassword.Text = "Confirm Password:";
                lblConfirmPassword.Name = "lblConfirmPassword";
                this.panelSave.Controls.Add(lblConfirmPassword);

                //teConfirmPassword
                TextEdit teAddConfirmPassword = new TextEdit();
                teAddConfirmPassword.Location = new System.Drawing.Point(lblConfirmPassword.Location.X + lblConfirmPassword.Size.Width + 5, 25);
                teAddConfirmPassword.Name = "teAddConfirmPassword";
                teAddConfirmPassword.Properties.PasswordChar = '*';
                teAddConfirmPassword.Size = new System.Drawing.Size(100, 20);
                this.panelSave.Controls.Add(teAddConfirmPassword);


 
                this.panelQuery.Visible = false;
                this.gcUser.Visible = false;
            }
        }

       
       
        private void RememberPassword()
        {
            RememberPassword model = new RememberPassword()
            {
                Remember = true,
                Account = GlobalObject.User.Account,
                Password = GlobalObject.User.Password
            };
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Password.txt");
            SaveContent(path, JsonConvert.SerializeObject(model));
        }

        void SaveContent(string fileName, string content)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(fileName, FileMode.Create, FileAccess.Write), System.Text.Encoding.Default))
            {
                sw.WriteLine(content);
            }

        }
        private void RequestGridData()
        {

            try
            {
                gcUser.DataSource = null;
              

              var result = _bll.GetUsers(new UsersQM()
                {
                    Take=this.pageNavigator.Take,
                    Skip=this.pageNavigator.Skip,
                    Account=this.teQueryAccount.Text.Trim()
              });
                gcUser.DataSource = result.UsersList;
                this.pageNavigator.Total = result.Count;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //  LoadingUtil.ShowImageLoading();
            try
            {
                UserVM user = null;
                if (GlobalObject.UserRoles.Any(p => p.RoleName == "admin"))
                {
                    if (string.IsNullOrEmpty(this.teAccount.Text.Trim()))
                    {

                        XtraMessageBox.Show("Account is empty!", "提示", MessageBoxButtons.OK);
                        return;
                    }
                    if (string.IsNullOrEmpty(this.tePassword.Text.Trim()))
                    {

                        XtraMessageBox.Show("Password is empty!", "提示", MessageBoxButtons.OK);

                        return;
                    }
                    if (string.IsNullOrEmpty(this.teConfirmPassword.Text.Trim()))
                    {

                        XtraMessageBox.Show("ConfirmPassword is empty!", "提示", MessageBoxButtons.OK);
                        return;
                    }

                    if (this.teConfirmPassword.Text.Trim() != this.tePassword.Text.Trim())
                    {

                        XtraMessageBox.Show("Password is  not the  same  with ConfirmPassword!", "提示", MessageBoxButtons.OK);
                        return;
                    }
                    user = new UserVM()
                    {
                        Account = this.teAccount.Text.Trim(),
                        Password = this.tePassword.Text.Trim()
                    };
                }
                else
                {
                    string oldPassword = GetTextEdit("teAddOldPassword");
                    if (string.IsNullOrEmpty(oldPassword))
                    {

                        XtraMessageBox.Show("Old Password is empty!", "提示", MessageBoxButtons.OK);
                        return;
                    }
                    if (oldPassword != GlobalObject.User.Password)
                    {

                        XtraMessageBox.Show("Old Password is not correct!", "提示", MessageBoxButtons.OK);
                        return;
                    }

                    string newPassword = GetTextEdit("teAddNewPassword");
                    if (string.IsNullOrEmpty(newPassword))
                    {
                        XtraMessageBox.Show("New Password is empty!", "提示", MessageBoxButtons.OK);
                        return;
                    }
                    string confirmPassword = GetTextEdit("teAddConfirmPassword");
                    if (string.IsNullOrEmpty(confirmPassword))
                    {
                        XtraMessageBox.Show("Confirm Password is empty!", "提示", MessageBoxButtons.OK);
                        return;
                    }

                    if (newPassword != confirmPassword)
                    {
                        XtraMessageBox.Show("Password is  not the  same  with ConfirmPassword!", "提示", MessageBoxButtons.OK);
                        return;
                    }


                    _operation = "EditUser";
                    user = new UserVM()
                    {
                        Account = GlobalObject.User.Account,
                        Password = confirmPassword
                    };
                }

                if (_operation == "EditUser")
                {
                    user.ID = (this.gvUser.GetRow(gvUser.FocusedRowHandle) as UserVM).ID;
                }


                var result = 0;
                if (_operation == "EditUser")
                {
                    result = _bll.EditUser(user);
                }
                else
                {
                    result = _bll.AddUser(user);
                }
                if (result > 0)
                {
                    XtraMessageBox.Show("保存成功!", "提示", MessageBoxButtons.OK);
                    if (GlobalObject.UserRoles.Any(p => p.RoleName != "admin"))
                    {
                        GlobalObject.User.Password = GetTextEdit("teNewPassword");
                        RememberPassword();
                    }
                    ClearText();
                    RequestGridData();

                }
                else
                {
                    XtraMessageBox.Show("保存失败!", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }
        private string GetTextEdit(string name)
        {
            foreach (Control control in this.panelSave.Controls)
            {
                if (control.Name == name)
                {
                    return control.Text;
                }
            }
            return "";
        }
        private void pager_PageChanged(object sender, EventArgs e)
        {
            RequestGridData();
        }


        private void sbtnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            foreach (var control in this.panelSave.Controls)
            {
                TextEdit te = control as TextEdit;
                if (te != null)
                {
                    if (_operation == "EditUser")
                    {
                        if (te.Name == "teAccount")
                        {
                            continue;
                        }
                    }
                    te.Text = string.Empty;
                }
            }

            if (_operation == "EditUser")
            {
                this.gvUser.SetRowCellValue(gvUser.FocusedRowHandle, gvUser.Columns["Checked"], CheckState.Indeterminate);
                var list = this.gcUser.DataSource as List<UserVM>;
                UserVM userVm = this.gvUser.GetRow(gvUser.FocusedRowHandle) as UserVM;//获取实体
                userVm.Checked = false;

                this.gcUser.DataSource = null;
                this.gcUser.DataSource = list;
            }
            _operation = "AddUser";
        }


        string _operation = "AddUser";
        private void repositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

            int i = gvUser.FocusedRowHandle;
            UserVM userVm = this.gvUser.GetRow(gvUser.FocusedRowHandle) as UserVM;//获取实体
            CheckState check = (sender as DevExpress.XtraEditors.CheckEdit).CheckState;
            if (check == CheckState.Checked)
            {
                this.teAccount.Text = userVm.Account;
                this.tePassword.Text = userVm.Password;
                this.teConfirmPassword.Text = userVm.Password;
                userVm.Checked = true;
                _operation = "EditUser";

            }
            else
            {
                ClearText();
                userVm.Checked = false;
            }
            var list = this.gcUser.DataSource as List<UserVM>;
            list.ForEach(p =>
            {
                if (p.ID != userVm.ID)
                {
                    p.Checked = false;
                }
            });

            this.gcUser.DataSource = null;
            this.gcUser.DataSource = list;
            this.gvUser.FocusedRowHandle = i;

        }

        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            RequestGridData();
        }

        private void ribeDeleteUser_Click(object sender, EventArgs e)
        {
            UserVM vm = this.gvUser.GetRow(this.gvUser.FocusedRowHandle) as UserVM;//获取选中行的实体
            if (vm.Account.ToLower() == "admin")
            {
                
                XtraMessageBox.Show("can not delete user  admin!", "提示", MessageBoxButtons.OK);

                return;
            }
 



            int resDeleteUsers = _bll.DeleteUsers(vm);
           
            if (resDeleteUsers > 0)
            {
                XtraMessageBox.Show("删除成功!", "提示", MessageBoxButtons.OK);
             
                RequestGridData();
            }
            else
            {
                XtraMessageBox.Show("删除失败!", "提示", MessageBoxButtons.OK);
            }
        }

        private void pageNavigator_PageIndexChanged(int arg1, int arg2)
        {
            RequestGridData();
        }
    }
}
