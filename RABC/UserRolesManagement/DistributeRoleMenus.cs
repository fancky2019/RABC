using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using RABC.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WMS.Model.ViewModels;

namespace WMS.UserRolesManagement
{
    public partial class DistributeRoleMenus : UserControl
    {
        private UserManagerBll _bll = null;
        public DistributeRoleMenus()
        {
            InitializeComponent();
            _bll = new UserManagerBll();
        }
        private void FrmDistributeRoleMenus_Load(object sender, EventArgs e)
        {
            RequestRolesData();

            RequestRoleMenusData();
            this.slueRoles.Properties.PopupFormSize = new Size(this.slueRoles.Width, this.slueRoles.Properties.PopupFormSize.Height);
        }
   



        private void RequestRolesData()
        {
            try
            {
           
                slueRoles.Properties.DataSource = _bll.GetRoles(new RolesVM());
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
                this.tlMenus.DataSource = null;
                this.tlMenus.DataSource = _bll.GetMenus(new RoleMenusVM { RoleID = (int)this.slueRoles.EditValue });

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }


        private void RequestRoleMenusData()
        {
            try
            {
   
                gcRoleMenus.DataSource = _bll.GetRoleMenus(new RoleMenusVM { RoleName = this.teRoleName.Text.Trim(), MenuName = this.teMenuName.Text.Trim() });
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }

        private void tlMenus_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            if (e.PrevState == CheckState.Checked)
            {
                e.State = CheckState.Unchecked;
            }
            else
            {
                e.State = CheckState.Checked;
            }

        }

        private void tlMenus_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            SetCheckedChildNodes(e.Node, e.Node.CheckState);
            SetCheckedParentNodes(e.Node, e.Node.CheckState);
            var selectList = GetChectedNodeData(this.tlMenus);
            this.tlSelectMenus.DataSource = null;
            this.tlSelectMenus.DataSource = selectList;
            this.tlSelectMenus.ExpandAll();
        }

        #region 设置子节点状态  
        private void SetCheckedChildNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }
        #endregion

        #region 设置父节点状态  
        private void SetCheckedParentNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                if (b)
                {
                    node.ParentNode.CheckState = CheckState.Indeterminate;
                }
                else
                {
                    node.ParentNode.CheckState = check;
                }
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }

        #endregion



        private void GetCheckedData(TreeListNode parentNode, List<MenusVM> lstCheckedKeyID, TreeList treeList)
        {
            if (parentNode.Nodes.Count == 0)
            {
                if (parentNode.CheckState == CheckState.Checked)
                {
                    if (parentNode.ParentNode == null)
                    {
                        lstCheckedKeyID.Add(treeList.GetDataRecordByNode(parentNode) as MenusVM);
                    }

                }

                return;//递归终止
            }

            foreach (TreeListNode node in parentNode.Nodes)
            {
                if (node.CheckState == CheckState.Checked)
                {
                    if (node.HasChildren)
                    {
                        GetCheckedData(node, lstCheckedKeyID, treeList);
                    }
                    else
                    {
                        //DataRowView drv = treeList.GetDataRecordByNode(node) as DataRowView;
                        MenusVM menusVM = treeList.GetDataRecordByNode(node) as MenusVM;
                        var parentData = treeList.GetDataRecordByNode(node.ParentNode) as MenusVM;
                        if (menusVM != null)
                        {
                            //string KeyFieldName = (string)drv["KeyFieldName"];
                            lstCheckedKeyID.Add(menusVM);
                            if (!lstCheckedKeyID.Any(p => p.ID == parentData.ID))
                            {
                                lstCheckedKeyID.Add(parentData);
                            }
                        }
                    }
                }
                //GetCheckedData(node, lstCheckedKeyID, treeList);
            }
        }



        /// <summary>
        /// 获取选中的节点
        /// </summary>
        /// <param name="tree"></param>
        private List<MenusVM> GetChectedNodeData(DevExpress.XtraTreeList.TreeList tree)
        {
            List<MenusVM> menusVMList = new List<MenusVM>();

            if (tree.Nodes.Count > 0)
            {
                foreach (TreeListNode root in tree.Nodes)
                {
                    GetCheckedData(root, menusVMList, tree);
                }
            }

            return menusVMList;
        }

        private void ribeDeleteSelectedMenu_Click(object sender, EventArgs e)
        {
            var data = tlSelectMenus.GetDataRecordByNode(this.tlSelectMenus.FocusedNode) as MenusVM;
            var list = this.tlSelectMenus.DataSource as List<MenusVM>;
            if (data.ParentID == 0)
            {
                list.RemoveAll(p => p.ParentID == data.ID);
            }

            list.Remove(list.Find(p => p.ID == data.ID));

            this.tlSelectMenus.DataSource = null;
            this.tlSelectMenus.DataSource = list;
            this.tlSelectMenus.ExpandAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            RequestRoleMenusData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.slueRoles.EditValue == null)
            {

            
                XtraMessageBox.Show("role is empty!", "提示", MessageBoxButtons.OK);
                return;

            }
            int roleID = int.Parse(this.slueRoles.EditValue.ToString());
            var list = this.tlSelectMenus.DataSource as List<MenusVM>;

            if (list == null || list.Count == 0)
            {
              
                XtraMessageBox.Show("please select the menus !", "提示", MessageBoxButtons.OK);
                return;
            }
            //   List<MenusVM> roleMenusVMList = new List<MenusVM>();

            list.ForEach(p =>
            {
                p.RoleID = roleID;
            });

     
            int res = _bll.AddRoleMenus(list);
     
            if (res > 0)
            {
               
                XtraMessageBox.Show("保存成功 !", "提示", MessageBoxButtons.OK);

                RequestRoleMenusData();
                this.slueRoles.EditValue = null;

            }
            else
            {
                XtraMessageBox.Show("保存失败!", "提示", MessageBoxButtons.OK);
            }
        }

        private void slueRoles_EditValueChanged(object sender, EventArgs e)
        {
            if (this.slueRoles.EditValue == null)
            {
                this.tlMenus.DataSource = null;
                this.tlSelectMenus.DataSource = null;
                return;
            }
            RequestMenusData();
        }

        private void ribeDeleteRoleMenu_Click(object sender, EventArgs e)
        {
            RoleMenusVM roleMenusVM = this.gvRoleMenus.GetRow(this.gvRoleMenus.FocusedRowHandle) as RoleMenusVM;//获取选中行的实体
            if (roleMenusVM.RoleName.ToLower() == "admin")
            {
               
                XtraMessageBox.Show("can not delete role admin!", "提示", MessageBoxButtons.OK);
                return;
            }
       
            int resDeleteUserRoles = _bll.DeleteRoleMenus(roleMenusVM);

            if (resDeleteUserRoles > 0)
            {
                XtraMessageBox.Show("删除成功!", "提示", MessageBoxButtons.OK);
                RequestRoleMenusData();
                this.slueRoles.EditValue = null;

            }
            else
            {
                XtraMessageBox.Show("删除失败!", "提示", MessageBoxButtons.OK);
            }
        }

   
    }
}
