using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using RABC.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WMS.Model.ViewModels;

namespace WMS.UserRolesManagement
{
    public partial class MenuManagement : UserControl
    {
        private UserManagerBll _bll = null;
        public MenuManagement()
        {
            InitializeComponent();
            _bll = new UserManagerBll();
        }
        private void FrmMenuManagement_Load(object sender, EventArgs e)
        {
            this.slueParentName.Properties.PopupFormSize = new Size(this.slueParentName.Width, this.slueParentName.Properties.PopupFormSize.Height);
            RequestGridData();
            GetParentMenus();
        }
    

        private void RequestGridData()
        {
      
            try
            {
                tlMenus.DataSource = _bll.GetAllMenus(new MenusVM
                {
                    FormName = teQueryFormName.Text.Trim(),
                    TabHeaderText = teQueryTabHeaderText.Text.Trim()
                });
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }

        }
        private void GetParentMenus()
        {
            try
            {
                this.slueParentName.Properties.DataSource = _bll.GetParentMenus();
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString(), "提示", MessageBoxButtons.OK);
            }
        }

        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            RequestGridData();
        }

        private void sbtnSaveParent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.teAddFormName.Text.Trim()))
            {
              
                XtraMessageBox.Show("Form Name is empty!", "提示", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(this.teAddTabHeaderText.Text.Trim()))
            {
             
                XtraMessageBox.Show("Header Text is empty!", "提示", MessageBoxButtons.OK);
                return;
            }
            var check = this.ceParentStatus.Checked ? 1 : 0;
            MenusVM parents = this.slueParentName.EditValue as MenusVM;
            MenusVM vm = new MenusVM()
            {
                ParentID = 0,
                FormName = this.teAddFormName.Text.Trim(),
                TabHeaderText = this.teAddTabHeaderText.Text.Trim(),
                Status = check
            };
            SaveMenus(vm);
        }

        private void sbtnSaveChild_Click(object sender, EventArgs e)
        {
            if (this.slueParentName.EditValue == null)
            {
            
                XtraMessageBox.Show("Parent name is null!", "提示", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(this.teAddChildFormName.Text.Trim()))
            {
             
                XtraMessageBox.Show("Form Name is empty!", "提示", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(this.teAddChildTabHeaderText.Text.Trim()))
            {
              
                XtraMessageBox.Show("Header Text is empty!", "提示", MessageBoxButtons.OK);
                return;
            }
            var check = this.ceChildStatus.Checked ? 1 : 0;
            FormRoleMenuAuthoritiesVM parents = this.slueParentName.EditValue as FormRoleMenuAuthoritiesVM;
            MenusVM vm = new MenusVM()
            {
                ParentID = parents.ID,
                FormName = this.teAddChildFormName.Text.Trim(),
                TabHeaderText = this.teAddChildTabHeaderText.Text.Trim(),
                Status = check
            };
            SaveMenus(vm);
        }

        private void SaveMenus(MenusVM vm)
        {

            int res = _bll.AddMenus(vm);
         
            if (res > 0)
            {
                XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                RequestGridData();
                GetParentMenus();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK);
            }
        }

        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            var selectList = GetChectedNodeData(this.tlMenus);
            if (selectList.Count == 0)
            {
             
                XtraMessageBox.Show("please select deleted rows!", "提示", MessageBoxButtons.OK);
                return;
            }
            if (DialogResult.OK == XtraMessageBox.Show("deleting these rows ？", "waring", MessageBoxButtons.OKCancel))
            {


              

                int resDeleteUserRoles = _bll.DeleteMenus(selectList.Select(p => p.ID).ToList());
                if (resDeleteUserRoles > 0)
                {
                    XtraMessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK);
                    RequestGridData();
                    GetParentMenus();
                }
                else
                {
                    XtraMessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK);
                }
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
            var parentData = treeList.GetDataRecordByNode(parentNode) as MenusVM;
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
                   
                        if (menusVM != null)
                        {
                            //string KeyFieldName = (string)drv["KeyFieldName"];
                            lstCheckedKeyID.Add(menusVM);
                        }
                    }
                }
            }
           if( parentNode.Nodes.Where(p=>p.Checked).Count()==parentNode.Nodes.Count)
            {
                lstCheckedKeyID.Add(parentData);
            }
        }

       
    }
}
