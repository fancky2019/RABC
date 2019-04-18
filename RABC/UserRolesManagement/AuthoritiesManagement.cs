using DevExpress.XtraEditors;
using RABC.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WMS.Model.ViewModels;

namespace WMS.UserRolesManagement
{
    public partial class AuthoritiesManagement : UserControl
    {
        private UserManagerBll _bll = null;
        public AuthoritiesManagement()
        {
            InitializeComponent();
            _bll = new UserManagerBll();
        }

        private void FrmAuthoritiesManagement_Load(object sender, EventArgs e)
        {
            RequestAllMenusData();
            RequestAuthoritiesData();
        }


        private void RequestAllMenusData()
        {

            tlueMenu.Properties.DataSource = _bll.GetAllMenus(new MenusVM());

        }
        private void RequestAuthoritiesData()
        {
            try
            {

                AuthoritiesVM vm = new AuthoritiesVM { MenuName = this.teMenuName.Text.Trim(), Name = this.teQueryAuthorityName.Text.Trim() };
                this.gcAuthorities.DataSource = null;
                this.gcAuthorities.DataSource = _bll.GetAuthorities(vm);

            }
            catch (Exception ex)
            {

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.teAuthorityName.Text))
            {
                XtraMessageBox.Show("button text is empty!", "提示", MessageBoxButtons.OK);
                return;

            }
            var source = tlueMenu.Properties.DataSource as List<MenusVM>;
            if (this.tlueMenu.EditValue == null)
            {

                XtraMessageBox.Show("menu is empty!", "提示", MessageBoxButtons.OK);
                return;

            }

            var item = this.tlueMenu.EditValue as MenusVM;//当前选中的实体
            if (item.ParentID == 0)
            {
                if (source.Any(p => p.ParentID == item.ID))//有孩子
                {

                    XtraMessageBox.Show("please select children menu!", "提示", MessageBoxButtons.OK);
                    return;

                }
            }

            AuthoritiesVM vm = new AuthoritiesVM()
            {
                MenuID = item.ID,
                Name = this.teAuthorityName.Text.Trim()
            };


            var res = _bll.AddAuthorities(vm);
            if (res > 0)
            {
                XtraMessageBox.Show("保存成功!", "提示", MessageBoxButtons.OK);
                RequestAuthoritiesData();
            }
            else
            {
                XtraMessageBox.Show("保存失败!", "提示", MessageBoxButtons.OK);
            }
        }

        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            RequestAuthoritiesData();
        }

        private void ribeDeleteAuthority_Click(object sender, EventArgs e)
        {
            AuthoritiesVM vm = this.gvAuthorities.GetRow(this.gvAuthorities.FocusedRowHandle) as AuthoritiesVM;//获取选中行的实体
      
            var res = _bll.DeleteAuthorities(vm);
            if (res > 0)
            {
                XtraMessageBox.Show("删除成功!", "提示", MessageBoxButtons.OK);
                RequestAuthoritiesData();
            }
            else
            {
                XtraMessageBox.Show("删除失败!", "提示", MessageBoxButtons.OK);
            }
        }


    }
}
