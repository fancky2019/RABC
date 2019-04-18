using DevExpress.XtraEditors;

namespace WMS.UserRolesManagement
{
    partial class DistributeRoleMenus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new PanelControl();
            this.slueRoles = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblUser = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tlMenus = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlSelectMenus = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ribeDeleteSelectedMenu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel2 = new PanelControl();
            this.teMenuName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.teRoleName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gcRoleMenus = new DevExpress.XtraGrid.GridControl();
            this.gvRoleMenus = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeDeleteRoleMenu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemHyperLinkEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemImageEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemHyperLinkEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slueRoles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlSelectMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDeleteSelectedMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMenuName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoleMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoleMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDeleteRoleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.slueRoles);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 48);
            this.panel1.TabIndex = 814;
            // 
            // slueRoles
            // 
            this.slueRoles.Location = new System.Drawing.Point(90, 12);
            this.slueRoles.Name = "slueRoles";
            this.slueRoles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueRoles.Properties.DisplayMember = "Name";
            this.slueRoles.Properties.NullText = "Select  a role";
            this.slueRoles.Properties.NullValuePrompt = "Select  a role";
            this.slueRoles.Properties.NullValuePromptShowForEmptyValue = true;
            this.slueRoles.Properties.ValueMember = "ID";
            this.slueRoles.Properties.View = this.searchLookUpEdit1View;
            this.slueRoles.Size = new System.Drawing.Size(211, 20);
            this.slueRoles.TabIndex = 807;
            this.slueRoles.EditValueChanged += new System.EventHandler(this.slueRoles_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Name";
            this.gridColumn6.FieldName = "Name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.Location = new System.Drawing.Point(798, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 36);
            this.btnSave.TabIndex = 805;
            this.btnSave.Text = "Save[&S]";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(10, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 14);
            this.lblUser.TabIndex = 805;
            this.lblUser.Text = "Role Name:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tlMenus);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tlSelectMenus);
            this.splitContainer1.Size = new System.Drawing.Size(933, 265);
            this.splitContainer1.SplitterDistance = 495;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 816;
            // 
            // tlMenus
            // 
            this.tlMenus.ActiveFilterEnabled = false;
            this.tlMenus.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.tlMenus.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMenus.Location = new System.Drawing.Point(0, 0);
            this.tlMenus.Name = "tlMenus";
            this.tlMenus.OptionsCustomization.AllowBandMoving = false;
            this.tlMenus.OptionsCustomization.AllowBandResizing = false;
            this.tlMenus.OptionsCustomization.AllowColumnMoving = false;
            this.tlMenus.OptionsCustomization.AllowColumnResizing = false;
            this.tlMenus.OptionsCustomization.AllowQuickHideColumns = false;
            this.tlMenus.OptionsCustomization.ShowBandsInCustomizationForm = false;
            this.tlMenus.OptionsFilter.AllowColumnMRUFilterList = false;
            this.tlMenus.OptionsFilter.AllowFilterEditor = false;
            this.tlMenus.OptionsFilter.AllowMRUFilterList = false;
            this.tlMenus.OptionsMenu.EnableColumnMenu = false;
            this.tlMenus.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.tlMenus.OptionsView.ShowCheckBoxes = true;
            this.tlMenus.Size = new System.Drawing.Size(495, 265);
            this.tlMenus.TabIndex = 3;
            this.tlMenus.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.tlMenus_BeforeCheckNode);
            this.tlMenus.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tlMenus_AfterCheckNode);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Menu Name";
            this.treeListColumn1.FieldName = "TabHeaderText";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.OptionsColumn.AllowFocus = false;
            this.treeListColumn1.OptionsColumn.AllowSort = false;
            this.treeListColumn1.OptionsFilter.AllowAutoFilter = false;
            this.treeListColumn1.OptionsFilter.AllowFilter = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 122;
            // 
            // tlSelectMenus
            // 
            this.tlSelectMenus.ActiveFilterEnabled = false;
            this.tlSelectMenus.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2,
            this.treeListColumn3});
            this.tlSelectMenus.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlSelectMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlSelectMenus.Location = new System.Drawing.Point(0, 0);
            this.tlSelectMenus.Name = "tlSelectMenus";
            this.tlSelectMenus.OptionsCustomization.AllowBandMoving = false;
            this.tlSelectMenus.OptionsCustomization.AllowBandResizing = false;
            this.tlSelectMenus.OptionsCustomization.AllowColumnMoving = false;
            this.tlSelectMenus.OptionsCustomization.AllowColumnResizing = false;
            this.tlSelectMenus.OptionsCustomization.AllowQuickHideColumns = false;
            this.tlSelectMenus.OptionsCustomization.ShowBandsInCustomizationForm = false;
            this.tlSelectMenus.OptionsFilter.AllowColumnMRUFilterList = false;
            this.tlSelectMenus.OptionsFilter.AllowFilterEditor = false;
            this.tlSelectMenus.OptionsFilter.AllowMRUFilterList = false;
            this.tlSelectMenus.OptionsMenu.EnableColumnMenu = false;
            this.tlSelectMenus.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.tlSelectMenus.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribeDeleteSelectedMenu});
            this.tlSelectMenus.Size = new System.Drawing.Size(432, 265);
            this.tlSelectMenus.TabIndex = 4;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Menu Name";
            this.treeListColumn2.FieldName = "TabHeaderText";
            this.treeListColumn2.MinWidth = 34;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.OptionsColumn.AllowFocus = false;
            this.treeListColumn2.OptionsColumn.AllowSort = false;
            this.treeListColumn2.OptionsFilter.AllowAutoFilter = false;
            this.treeListColumn2.OptionsFilter.AllowFilter = false;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 122;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Delete";
            this.treeListColumn3.ColumnEdit = this.ribeDeleteSelectedMenu;
            this.treeListColumn3.FieldName = "Delete";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 1;
            // 
            // ribeDeleteSelectedMenu
            // 
            this.ribeDeleteSelectedMenu.AutoHeight = false;
            this.ribeDeleteSelectedMenu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.ribeDeleteSelectedMenu.Name = "ribeDeleteSelectedMenu";
            this.ribeDeleteSelectedMenu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeDeleteSelectedMenu.Click += new System.EventHandler(this.ribeDeleteSelectedMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.teMenuName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.teRoleName);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 48);
            this.panel2.TabIndex = 819;
            // 
            // teMenuName
            // 
            this.teMenuName.Location = new System.Drawing.Point(335, 15);
            this.teMenuName.Name = "teMenuName";
            this.teMenuName.Size = new System.Drawing.Size(143, 20);
            this.teMenuName.TabIndex = 808;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 807;
            this.label2.Text = "Menu Name:";
            // 
            // teRoleName
            // 
            this.teRoleName.Location = new System.Drawing.Point(86, 15);
            this.teRoleName.Name = "teRoleName";
            this.teRoleName.Size = new System.Drawing.Size(143, 20);
            this.teRoleName.TabIndex = 806;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.Location = new System.Drawing.Point(798, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(118, 36);
            this.simpleButton1.TabIndex = 805;
            this.simpleButton1.Text = "Query[&Q]";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 805;
            this.label1.Text = "Role Name:";
            // 
            // gcRoleMenus
            // 
            this.gcRoleMenus.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcRoleMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoleMenus.Location = new System.Drawing.Point(0, 361);
            this.gcRoleMenus.MainView = this.gvRoleMenus;
            this.gcRoleMenus.Margin = new System.Windows.Forms.Padding(0);
            this.gcRoleMenus.Name = "gcRoleMenus";
            this.gcRoleMenus.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit5,
            this.repositoryItemImageEdit3,
            this.repositoryItemHyperLinkEdit6,
            this.repositoryItemCheckEdit3,
            this.ribeDeleteRoleMenu});
            this.gcRoleMenus.Size = new System.Drawing.Size(933, 324);
            this.gcRoleMenus.TabIndex = 821;
            this.gcRoleMenus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRoleMenus});
            // 
            // gvRoleMenus
            // 
            this.gvRoleMenus.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.gvRoleMenus.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRoleMenus.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn3,
            this.gridColumn5});
            this.gvRoleMenus.GridControl = this.gcRoleMenus;
            this.gvRoleMenus.IndicatorWidth = 35;
            this.gvRoleMenus.Name = "gvRoleMenus";
            this.gvRoleMenus.OptionsCustomization.AllowFilter = false;
            this.gvRoleMenus.OptionsCustomization.AllowSort = false;
            this.gvRoleMenus.OptionsMenu.EnableColumnMenu = false;
            this.gvRoleMenus.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvRoleMenus.OptionsSelection.MultiSelect = true;
            this.gvRoleMenus.OptionsView.ColumnAutoWidth = false;
            this.gvRoleMenus.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Role Name";
            this.gridColumn7.FieldName = "RoleName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 299;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Menu Name";
            this.gridColumn3.FieldName = "MenuName";
            this.gridColumn3.MinWidth = 100;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 327;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Delete";
            this.gridColumn5.ColumnEdit = this.ribeDeleteRoleMenu;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // ribeDeleteRoleMenu
            // 
            this.ribeDeleteRoleMenu.AutoHeight = false;
            this.ribeDeleteRoleMenu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.ribeDeleteRoleMenu.Name = "ribeDeleteRoleMenu";
            this.ribeDeleteRoleMenu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeDeleteRoleMenu.Click += new System.EventHandler(this.ribeDeleteRoleMenu_Click);
            // 
            // repositoryItemHyperLinkEdit5
            // 
            this.repositoryItemHyperLinkEdit5.AutoHeight = false;
            this.repositoryItemHyperLinkEdit5.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.repositoryItemHyperLinkEdit5.Caption = "Download";
            this.repositoryItemHyperLinkEdit5.Name = "repositoryItemHyperLinkEdit5";
            // 
            // repositoryItemImageEdit3
            // 
            this.repositoryItemImageEdit3.AutoHeight = false;
            this.repositoryItemImageEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit3.Name = "repositoryItemImageEdit3";
            // 
            // repositoryItemHyperLinkEdit6
            // 
            this.repositoryItemHyperLinkEdit6.AutoHeight = false;
            this.repositoryItemHyperLinkEdit6.Caption = "123";
            this.repositoryItemHyperLinkEdit6.Name = "repositoryItemHyperLinkEdit6";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // FrmDistributeRoleMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 685);
            this.Controls.Add(this.gcRoleMenus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDistributeRoleMenus";
            this.Text = "FrmDistributeRoleMenus";
            this.Load += new System.EventHandler(this.FrmDistributeRoleMenus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slueRoles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlSelectMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDeleteSelectedMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMenuName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoleMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoleMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDeleteRoleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl panel1;
        private DevExpress.XtraEditors.SearchLookUpEdit slueRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTreeList.TreeList tlMenus;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.TreeList tlSelectMenus;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeDeleteSelectedMenu;
        private PanelControl panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcRoleMenus;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRoleMenus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeDeleteRoleMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit6;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit teRoleName;
        private DevExpress.XtraEditors.TextEdit teMenuName;
    }
}