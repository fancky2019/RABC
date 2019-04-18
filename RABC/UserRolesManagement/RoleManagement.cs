using DevExpress.XtraEditors;
using RABC.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS.Model.ViewModels;

namespace WMS.UserRolesManagement
{
    public partial class RoleManagement : UserControl
    {
        private UserManagerBll _bll = null;
        public RoleManagement()
        {
            InitializeComponent();
            _bll = new UserManagerBll();
        }
        private void FrmRoleManagement_Load(object sender, EventArgs e)
        {
            RequestGridData();
        }
  

        private void RequestGridData()
        {

            try
            {
       
                gcRoles.DataSource = _bll.GetRoles(new RolesVM { Name = this.teQueryName.Text.Trim() });
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.teRoleName.Text.Trim()))
                {
                
                    XtraMessageBox.Show("teRoleName is empty!", "提示", MessageBoxButtons.OK);
                    return;
                }

                int res = _bll.AddRoles(new RolesVM()
                {
                    Name = this.teRoleName.Text.Trim(),

                });
             
                if (res > 0)
                {
                    XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                    this.teRoleName.Text = string.Empty;
                    RequestGridData();
                }
                else
                {
                    XtraMessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }

        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            RequestGridData();
        }

        private void sbtDelete_Click(object sender, EventArgs e)
        {
            //List<int> selectedIDList = new List<int>();
            int[] rowHandles = this.gvRoles.GetSelectedRows();//获取选中行号；
            if (rowHandles.Length == 0)
            {
          
                XtraMessageBox.Show("please select deleted rows!", "提示", MessageBoxButtons.OK);
                return;
            }
            if (DialogResult.OK == XtraMessageBox.Show("deleting these rows ？", "waring", MessageBoxButtons.OKCancel))
            {
                List<RolesVM> selectedList = new List<RolesVM>();
                foreach (var rowHandle in rowHandles)
                {
                    ////获取选中行的ID
                    //selectedIDList.Add(int.Parse(this.gvRoles.GetRowCellValue(rowHandle, "ID").ToString()));
                    RolesVM vm = this.gvRoles.GetRow(rowHandle) as RolesVM;
                    if(vm.Name.ToLower()=="admin")
                    {
                      
                        XtraMessageBox.Show("can not delete role admin!", "提示", MessageBoxButtons.OK);
                        return;
                    }
                    selectedList.Add(vm);
                }
                
                int res = _bll.DeleteRoles(selectedList.Select(p => p.ID).ToList());

                if (res > 0)
                {
                    XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                    this.teRoleName.Text = string.Empty;
                    RequestGridData();
                }
                else
                {
                    XtraMessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
                }
            }
        }

 
    }
}
