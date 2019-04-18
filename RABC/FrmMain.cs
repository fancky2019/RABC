using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;
using RABC.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS.Model.ViewModels;

namespace RABC
{
    public partial class FrmMain : RibbonForm
    {
        private UserManagerBll _bll = null;
        Type[] types = null;
        public FrmMain()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            types = assembly.GetTypes();
            _bll = new UserManagerBll();
            this.ribbonControl.Pages.Clear();
            LoadMenus();
        }
        public void LoadMenus()
        {
            this.ribbonControl.Items.Add(this.ribbonControl.ExpandCollapseItem);
            List<UserMenusVM> list = _bll.GetUserMenus(GlobalObject.User.Account);
            var parents = list.Where(p => p.ParentID == 0).ToList();
            parents.ForEach(p =>
            {
                RibbonPage ribbonPage = new RibbonPage();
                ribbonPage.Text = p.TabHeaderText;
                var children = list.Where(q => q.ParentID == p.ID).ToList();
                if (children.Count == 0)
                {
                    RibbonPageGroup ribbonPageGroup = new RibbonPageGroup();

                    BarButtonItem barButtonItem = new BarButtonItem();
                    barButtonItem.Caption = p.TabHeaderText;
                    barButtonItem.Id = p.ID;
                    barButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
                    barButtonItem.Tag = p.FormName;

                    ribbonControl.Items.Add(barButtonItem);
                    ribbonPageGroup.ItemLinks.Add(barButtonItem);
                    ribbonPage.Groups.Add(ribbonPageGroup);
                }
                else
                {
                    children.ForEach(c =>
                    {
                        RibbonPageGroup ribbonPageGroup = new RibbonPageGroup();
        
                        BarButtonItem barButtonItem = new BarButtonItem();
                        barButtonItem.Caption = c.TabHeaderText;
                        barButtonItem.Id = c.ID;
                        barButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
                        barButtonItem.Tag = c.FormName;

                        ribbonControl.Items.Add(barButtonItem);
                        ribbonPageGroup.ItemLinks.Add(barButtonItem);
                        ribbonPage.Groups.Add(ribbonPageGroup);
                    });
                }
                this.ribbonControl.Pages.Add(ribbonPage);
            });

        }

        private async void ribbonControl1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ssmAddItem.IsSplashFormVisible)//如果已ShowWaitForm,return
            {
                return;
            }
            //WaitDialogForm
            ssmAddItem.ShowWaitForm();
            ssmAddItem.SetWaitFormCaption("提示");
            ssmAddItem.SetWaitFormDescription("数据加载中...");
            await Task.Run(() =>
            {
                Type type = null;
                if (e.Item.Tag == null)
                {
                    return;
                }
                string controlName = e.Item.Tag.ToString();
                foreach (var t in types)
                {
                    if (t.Name == controlName)
                    {
                        type = t;
                        break;
                    }
                }
                if(type==null)
                {
                  
                    return;
                }
 
                this.BeginInvoke((MethodInvoker)(() =>
                   {
                       var control = Activator.CreateInstance(type);
                       AddXtrTabPages(e.Item.Caption, control );

                   }));
            });
            ssmAddItem.CloseWaitForm();
        }

        private void AddXtrTabPages(string header,  object obj)
        {
            if (obj is UserControl control)
            {
                IEnumerable<XtraTabPage> res = this.xtraTabControl1.TabPages.Where(p => p.Text.Contains(header));
                if (res.Count() > 0)
                {
                    this.xtraTabControl1.SelectedTabPage = res.FirstOrDefault();
                    return;
                }
                XtraTabPage xtraTabPage = new XtraTabPage();
                xtraTabPage.Name = header;
                xtraTabPage.Size = new System.Drawing.Size(401, 288);
                xtraTabPage.Text = header;
                this.xtraTabControl1.TabPages.Add(xtraTabPage);
                this.xtraTabControl1.SelectedTabPage = xtraTabPage;

                xtraTabPage.Controls.Add(control);
                xtraTabPage.Controls[0].Dock = DockStyle.Fill;
            }

        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            //xtraTabControl1.TabPages.Remove(this.xtraTabControl1.SelectedTabPage);
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs EArg = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
            string name = EArg.Page.Text;//得到关闭的选项卡的text
            foreach (XtraTabPage page in xtraTabControl1.TabPages)//遍历得到和关闭的选项卡一样的Text
            {
                if (page.Text == name)
                {
                    xtraTabControl1.TabPages.Remove(page);
                    page.Dispose();
                    return;
                }
            }

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
