using DevExpress.XtraEditors;
using Newtonsoft.Json;
using RABC.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WMS.Model.ViewModels;

namespace RABC
{

    public partial class FrmLogin :XtraForm
    {
        private UserManagerBll _bll = null;
        public FrmLogin()
        {
      
            InitializeComponent();
            _bll = new UserManagerBll();
            LoadAccount();
        }

        private void RememberPassword()
        {
            RememberPassword model = new RememberPassword()
            {
                Remember = this.chkRememberPassword.Checked,
                Account = this.txtUserName.Text.Trim(),
                Password = this.txtPassword.Text.Trim()
            };
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Password.txt");
            SaveContent(path, JsonConvert.SerializeObject(model));
        }
        private void LoadAccount()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Password.txt");
            if (File.Exists(path))
            {
                RememberPassword model = ReadFile(path);
                this.chkRememberPassword.Checked = model.Remember;
                this.txtUserName.Text = model.Account;
                this.txtPassword.Text = model.Password;
            }
        }
        RememberPassword ReadFile(string fileName)
        {
            string str = string.Empty;
            using (StreamReader sReader = new StreamReader(File.Open(fileName, FileMode.Open), System.Text.Encoding.Default))
            {
                str = sReader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<RememberPassword>(str);
        }
        void SaveContent(string fileName, string content)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(fileName, FileMode.Create, FileAccess.Write), System.Text.Encoding.Default))
            {
                sw.WriteLine(content);
            }

        }

   







        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text))
            {
             XtraMessageBox.Show("User name is empty!", "提示", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
              XtraMessageBox.Show("Password is empty!", "提示", MessageBoxButtons.OK);
                return;
            }

        

            UserVM vm = _bll.Login(new UserVM { Account = this.txtUserName.Text.Trim() });
            if (vm != null)
            {
                if (vm.Password == this.txtPassword.Text.Trim())
                {
                    RememberPassword();
                    GlobalObject.User = vm;

                    GetUserRoles();


                }
                else
                {
                   XtraMessageBox.Show("Password is not correct!", "提示", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
              XtraMessageBox.Show("User name is not exists!", "提示", MessageBoxButtons.OK);

                return;
            }
        }



        private void GetUserRoles()
        {
            try
            {
                GlobalObject.UserRoles = _bll.GetUserRoles(new UserRolesVM { UserID = GlobalObject.User.ID });
                this.Hide();
                if (GlobalObject.FrmLogOn == null)
                {
                    GlobalObject.FrmLogOn = this;
                }
                if (GlobalObject.FrmMain == null)
                {
                    GlobalObject.FrmMain = new FrmMain();
                }
                else
                {
                    GlobalObject.FrmMain.LoadMenus();
                }
                GlobalObject.FrmMain.Show();

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //// 退出应用程序
            //GlobalObject.uiController.dataEngine.stop();
            ////Application.Exit();
            //Environment.Exit(Environment.ExitCode);
        }

        private void FrmLogOnByName_Load(object sender, EventArgs e)
        {


        }

    }
}