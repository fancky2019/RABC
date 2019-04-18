using DevExpress.XtraEditors;
using RABC.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WMS.Model.ViewModels;

namespace WMS.UserRolesManagement
{
    public partial class DistributeRoleMenuAuthorities : UserControl
    {
        private UserManagerBll _bll = null;
        public DistributeRoleMenuAuthorities()
        {
            InitializeComponent();
            _bll = new UserManagerBll();
        }

        private void FrmDistributeRoleMenuAuthorities_Load(object sender, EventArgs e)
        {
            RequestRolesData();
            RequestRoleMenuAuthoritiesData();
        }

        private void RequestRolesData()
        {
            try
            {
                this.lueAddRole.Properties.DataSource =  _bll.GetRoles(new RolesVM ());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);

            }
        }
        private void RequestMenusData()
        {
            try
            {

                this.tllueAddMenu.Properties.DataSource = _bll.GetRoleMenus(new RoleMenusVM { RoleID = (this.lueAddRole.EditValue as RolesVM).ID });
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);

            }
        }

        private void RequestAuthoritiesData()
        {
            try
            {
                this.lueAuthority.Properties.DataSource = _bll.GetAuthorities(new AuthoritiesVM { MenuID = (this.tllueAddMenu.EditValue as RoleMenusVM).MenuID });

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }
        private void RequestRoleMenuAuthoritiesData()
        {
            try
            {
                this.gcRoleMenuAuthority.DataSource = null;
                this.gcRoleMenuAuthority.DataSource = _bll.GetRoleMenuAuthorities(new RoleMenuAuthoritiesVM { RoleName = this.teQueryRole.Text.Trim(), MenuName = this.teQueryMenu.Text.Trim() }); 
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.lueAddRole.EditValue == null)
            {
               
                XtraMessageBox.Show("role is empty!！", "提示", MessageBoxButtons.OK);
                return;
            }
            if (this.tllueAddMenu.EditValue == null)
            {
             
                XtraMessageBox.Show("menu is empty!", "提示", MessageBoxButtons.OK);
                return;
            }
            if (this.lueAuthority.EditValue == null)
            {
                
                XtraMessageBox.Show("Authority is empty!", "提示", MessageBoxButtons.OK);
                return;
            }

            RoleMenuAuthoritiesVM vm = new RoleMenuAuthoritiesVM()
            {
                RoleID = (this.lueAddRole.EditValue as RolesVM).ID,
                MenuID = (this.tllueAddMenu.EditValue as RoleMenusVM).MenuID,
                AuthorityID = (this.lueAuthority.EditValue as AuthoritiesVM).ID
            };
     
            var res = _bll.AddRoleMenuAuthorities(vm);
            if (res > 0)
            {
                XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                RequestRoleMenuAuthoritiesData();
            }
            else
            {
                XtraMessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
            }
        }

        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            RequestRoleMenuAuthoritiesData();
        }

        private void ribeDeleteRoleMenuAuthority_Click(object sender, EventArgs e)
        {
            RoleMenuAuthoritiesVM vm = this.gvRoleMenuAuthority.GetRow(this.gvRoleMenuAuthority.FocusedRowHandle) as RoleMenuAuthoritiesVM;//获取选中行的实体
 

            var resDeleteUserRoles = _bll.DeleteRoleMenuAuthority(vm);
            if (resDeleteUserRoles > 0)
            {
                XtraMessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK);
                RequestRoleMenuAuthoritiesData();


            }
            else
            {
                XtraMessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK);
            }
        }

        private void lueAddRole_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lueAddRole.EditValue == null)
            {
                this.tllueAddMenu.Properties.DataSource = null;
                return;
            }
            RequestMenusData();
        }


        private void tllueAddMenu_EditValueChanged(object sender, EventArgs e)
        {
            if (this.tllueAddMenu.EditValue == null)
            {
                this.lueAuthority.Properties.DataSource = null;
                return;
            }
            else
            {
                //判断点击的节点有没有子节点
                RoleMenusVM menu = this.tllueAddMenu.EditValue as RoleMenusVM;
                if (menu.ParentID == 0)
                {
                    List<RoleMenusVM> sourceList = this.tllueAddMenu.Properties.DataSource as List<RoleMenusVM>;
                    if (sourceList.Any(p => p.ParentID == menu.MenuID))
                    {
                        XtraMessageBox.Show("please select  child node!", "提示", MessageBoxButtons.OK);
                        this.tllueAddMenu.EditValue = null;
                        return;
                    }

                }
            }
            RequestAuthoritiesData();
        }
    }
}
