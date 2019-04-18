using DevExpress.XtraEditors;
using RABC.BLL;
using RABC.Model.QueryModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WMS.Model.ViewModels;

namespace WMS.UserRolesManagement
{
    /// <summary>
    /// 分配用户角色
    /// </summary>
    public partial class DistributeUserRoles : UserControl
    {
        private UserManagerBll _bll = null;
        public DistributeUserRoles()
        {
            InitializeComponent();
            _bll = new UserManagerBll();
        }
        private void FrmDistributeUserRoles_Load(object sender, EventArgs e)
        {
            RequestUsersData();
            RequestUserRolesData();
            this.slueUsers.Properties.PopupFormSize = new Size(this.slueUsers.Width, this.slueUsers.Properties.PopupFormSize.Height);
        }
       
        private void RequestUsersData()
        {
            try
            {
                //    gcUser.DataSource = null;
        
                slueUsers.Properties.DataSource = _bll.GetUsers(new UsersQM()
                {
                    Take=1000000,
                    Skip=0
                }).UsersList;

            }
            catch (Exception ex)
            {
                //  LoadingUtil.HideImageLoading();
                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }
        private void RequestRolesData()
        {
            try
            {

                gcRoles.DataSource = _bll.GetUserNotHaveRoles(new UserRolesVM { UserID = (int)this.slueUsers.EditValue });
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }


        private void RequestUserRolesData()
        {
            try
            {
         

                gcUserRoles.DataSource = _bll.GetUserRoles(new UserRolesVM { UserID = 0 });
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.slueUsers.EditValue==null)
            {
            
                DevExpress.XtraEditors.XtraMessageBox.Show("User is empty!", "提示", MessageBoxButtons.OK);
                return;

            }
            int userID = int.Parse(this.slueUsers.EditValue.ToString());
            var list = this.gcSelectedRoles.DataSource as List<RolesVM>;
            if (list == null || list.Count == 0)
            {
              
                DevExpress.XtraEditors.XtraMessageBox.Show("please select the roles !", "提示", MessageBoxButtons.OK);
                return;
            }

            List<UserRolesVM> userRoleList = new List<UserRolesVM>();

            list.ForEach(p =>
            {
                userRoleList.Add(new UserRolesVM()
                {
                    UserID = userID,
                    RoleID = p.ID
                });
            });

        

            int res = _bll.AddUserRoles(userRoleList);
      
            if (res > 0)
            {
                XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                RequestUserRolesData();
                this.slueUsers.EditValue = null;

            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
            }
        }


        private void gvRoles_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            List<RolesVM> list = new List<RolesVM>();
            int[] rowHandles = this.gvRoles.GetSelectedRows();//获取选中行号；
            for (int i = 0; i < rowHandles.Length; i++)
            {
                RolesVM pro = this.gvRoles.GetRow(rowHandles[i]) as RolesVM;//获取选中行的实体
                list.Add(pro);
            }
            this.gcSelectedRoles.DataSource = null;
            this.gcSelectedRoles.DataSource = list;
        }

        private void ribeDeleteRoles_Click(object sender, EventArgs e)
        {
            int[] rowHandles = this.gvRoles.GetSelectedRows();//获取选中行号；
            RolesVM rolesVM = this.gvSelectedUsers.GetRow(this.gvSelectedUsers.FocusedRowHandle) as RolesVM;//获取选中行的实体
            for (int i = 0; i < rowHandles.Length; i++)
            {
                RolesVM source = this.gvRoles.GetRow(rowHandles[i]) as RolesVM;//获取选中行的实体
                if (rolesVM.ID == source.ID)
                {
                    this.gvRoles.UnselectRow(rowHandles[i]);
                    break;
                }
            }
        }

        private void ribeDeleteUserRole_Click(object sender, EventArgs e)
        {
            UserRolesVM userRolesVM = this.gvUserRoles.GetRow(this.gvUserRoles.FocusedRowHandle) as UserRolesVM;//获取选中行的实体
            if (userRolesVM.UserName.ToLower() == "admin"|| userRolesVM.RoleName.ToLower() == "admin")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("can not delete role or user  admin!", "提示", MessageBoxButtons.OK);
                return;
            }
       

            int resDeleteUserRoles = _bll.DeleteUserRoles(userRolesVM);

            if (resDeleteUserRoles > 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK);
                RequestUserRolesData();
                this.slueUsers.EditValue = null;

            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK);
            }
        }

        private void slueUsers_EditValueChanged(object sender, EventArgs e)
        {
            if (this.slueUsers.EditValue == null)
            {
                this.gcRoles.DataSource = null;
                this.gcSelectedRoles.DataSource = null;
                return;
            }
            RequestRolesData();
        }

  
    }
}
