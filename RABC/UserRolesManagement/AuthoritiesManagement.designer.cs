using DevExpress.XtraEditors;

namespace WMS.UserRolesManagement
{
    partial class AuthoritiesManagement
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
            this.panel1 = new PanelControl();
            this.teAuthorityName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlueMenu = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new PanelControl();
            this.teMenuName = new DevExpress.XtraEditors.TextEdit();
            this.teQueryAuthorityName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sbtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.gcAuthorities = new DevExpress.XtraGrid.GridControl();
            this.gvAuthorities = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeDeleteAuthority = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repHyperLinkDownFile = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.rpLinkDownFile = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teAuthorityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlueMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMenuName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQueryAuthorityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthorities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAuthorities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDeleteAuthority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repHyperLinkDownFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpLinkDownFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teAuthorityName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tlueMenu);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 68);
            this.panel1.TabIndex = 2;
            // 
            // teAuthorityName
            // 
            this.teAuthorityName.Location = new System.Drawing.Point(379, 28);
            this.teAuthorityName.Name = "teAuthorityName";
            this.teAuthorityName.Size = new System.Drawing.Size(197, 20);
            this.teAuthorityName.TabIndex = 812;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 811;
            this.label2.Text = "Button Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 810;
            this.label1.Text = "Menu:";
            // 
            // tlueMenu
            // 
            this.tlueMenu.Location = new System.Drawing.Point(69, 28);
            this.tlueMenu.Name = "tlueMenu";
            this.tlueMenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tlueMenu.Properties.DisplayMember = "TabHeaderText";
            this.tlueMenu.Properties.KeyMember = "ID";
            this.tlueMenu.Properties.NullText = "Select  a menu";
            this.tlueMenu.Properties.NullValuePrompt = "Select  a menu";
            this.tlueMenu.Properties.NullValuePromptShowForEmptyValue = true;
            this.tlueMenu.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.tlueMenu.Size = new System.Drawing.Size(219, 20);
            this.tlueMenu.TabIndex = 809;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 125);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Menu Name";
            this.treeListColumn1.FieldName = "TabHeaderText";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.Location = new System.Drawing.Point(649, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 803;
            this.btnSave.Text = "Save[&S]";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.teMenuName);
            this.panel2.Controls.Add(this.teQueryAuthorityName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.sbtnQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 68);
            this.panel2.TabIndex = 812;
            // 
            // teMenuName
            // 
            this.teMenuName.Location = new System.Drawing.Point(69, 28);
            this.teMenuName.Name = "teMenuName";
            this.teMenuName.Size = new System.Drawing.Size(219, 20);
            this.teMenuName.TabIndex = 813;
            // 
            // teQueryAuthorityName
            // 
            this.teQueryAuthorityName.Location = new System.Drawing.Point(379, 28);
            this.teQueryAuthorityName.Name = "teQueryAuthorityName";
            this.teQueryAuthorityName.Size = new System.Drawing.Size(197, 20);
            this.teQueryAuthorityName.TabIndex = 812;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 811;
            this.label3.Text = "Button Text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 810;
            this.label4.Text = "Menu:";
            // 
            // sbtnQuery
            // 
            this.sbtnQuery.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.sbtnQuery.Appearance.Options.UseBackColor = true;
            this.sbtnQuery.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbtnQuery.Location = new System.Drawing.Point(649, 24);
            this.sbtnQuery.Name = "sbtnQuery";
            this.sbtnQuery.Size = new System.Drawing.Size(87, 27);
            this.sbtnQuery.TabIndex = 803;
            this.sbtnQuery.Text = "Query[&S]";
            this.sbtnQuery.Click += new System.EventHandler(this.sbtnQuery_Click);
            // 
            // gcAuthorities
            // 
            this.gcAuthorities.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcAuthorities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAuthorities.Location = new System.Drawing.Point(0, 136);
            this.gcAuthorities.MainView = this.gvAuthorities;
            this.gcAuthorities.Margin = new System.Windows.Forms.Padding(0);
            this.gcAuthorities.Name = "gcAuthorities";
            this.gcAuthorities.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repHyperLinkDownFile,
            this.repositoryItemImageEdit1,
            this.rpLinkDownFile,
            this.repositoryItemCheckEdit,
            this.ribeDeleteAuthority});
            this.gcAuthorities.Size = new System.Drawing.Size(933, 389);
            this.gcAuthorities.TabIndex = 813;
            this.gcAuthorities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAuthorities});
            // 
            // gvAuthorities
            // 
            this.gvAuthorities.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.gvAuthorities.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAuthorities.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvAuthorities.GridControl = this.gcAuthorities;
            this.gvAuthorities.IndicatorWidth = 35;
            this.gvAuthorities.Name = "gvAuthorities";
            this.gvAuthorities.OptionsCustomization.AllowFilter = false;
            this.gvAuthorities.OptionsCustomization.AllowSort = false;
            this.gvAuthorities.OptionsMenu.EnableColumnMenu = false;
            this.gvAuthorities.OptionsView.ColumnAutoWidth = false;
            this.gvAuthorities.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Menu Name";
            this.gridColumn1.FieldName = "MenuName";
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 339;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Button Text";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.MinWidth = 200;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 427;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Delete";
            this.gridColumn3.ColumnEdit = this.ribeDeleteAuthority;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // ribeDeleteAuthority
            // 
            this.ribeDeleteAuthority.AutoHeight = false;
            this.ribeDeleteAuthority.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.ribeDeleteAuthority.Name = "ribeDeleteAuthority";
            this.ribeDeleteAuthority.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeDeleteAuthority.Click += new System.EventHandler(this.ribeDeleteAuthority_Click);
            // 
            // repHyperLinkDownFile
            // 
            this.repHyperLinkDownFile.AutoHeight = false;
            this.repHyperLinkDownFile.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.repHyperLinkDownFile.Caption = "Download";
            this.repHyperLinkDownFile.Name = "repHyperLinkDownFile";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // rpLinkDownFile
            // 
            this.rpLinkDownFile.AutoHeight = false;
            this.rpLinkDownFile.Caption = "123";
            this.rpLinkDownFile.Name = "rpLinkDownFile";
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            // 
            // FrmAuthoritiesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.gcAuthorities);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAuthoritiesManagement";
            this.Text = "FrmAuthoritiesManagemrnt";
            this.Load += new System.EventHandler(this.FrmAuthoritiesManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teAuthorityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlueMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMenuName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQueryAuthorityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthorities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAuthorities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDeleteAuthority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repHyperLinkDownFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpLinkDownFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl panel1;
        private DevExpress.XtraEditors.TextEdit teAuthorityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TreeListLookUpEdit tlueMenu;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private PanelControl panel2;
        private DevExpress.XtraEditors.TextEdit teMenuName;
        private DevExpress.XtraEditors.TextEdit teQueryAuthorityName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton sbtnQuery;
        private DevExpress.XtraGrid.GridControl gcAuthorities;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAuthorities;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repHyperLinkDownFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit rpLinkDownFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeDeleteAuthority;
    }
}