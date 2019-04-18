using DevExpress.XtraEditors;

namespace WMS.UserRolesManagement
{
    partial class DistributeRoleMenuAuthorities
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
            this.tllueAddMenu = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lueAuthority = new DevExpress.XtraEditors.LookUpEdit();
            this.lueAddRole = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new PanelControl();
            this.teQueryMenu = new DevExpress.XtraEditors.TextEdit();
            this.teQueryRole = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sbtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.gcRoleMenuAuthority = new DevExpress.XtraGrid.GridControl();
            this.gvRoleMenuAuthority = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeDeleteRoleMenuAuthority = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repHyperLinkDownFile = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.rpLinkDownFile = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tllueAddMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAuthority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAddRole.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teQueryMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQueryRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoleMenuAuthority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoleMenuAuthority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDeleteRoleMenuAuthority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repHyperLinkDownFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpLinkDownFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tllueAddMenu);
            this.panel1.Controls.Add(this.lueAuthority);
            this.panel1.Controls.Add(this.lueAddRole);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 54);
            this.panel1.TabIndex = 1;
            // 
            // tllueAddMenu
            // 
            this.tllueAddMenu.Location = new System.Drawing.Point(291, 22);
            this.tllueAddMenu.Name = "tllueAddMenu";
            this.tllueAddMenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tllueAddMenu.Properties.DisplayMember = "MenuName";
            this.tllueAddMenu.Properties.KeyMember = "MenuID";
            this.tllueAddMenu.Properties.NullText = "select  a menu";
            this.tllueAddMenu.Properties.NullValuePrompt = "select  a menu";
            this.tllueAddMenu.Properties.NullValuePromptShowForEmptyValue = true;
            this.tllueAddMenu.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.tllueAddMenu.Size = new System.Drawing.Size(188, 20);
            this.tllueAddMenu.TabIndex = 817;
            this.tllueAddMenu.EditValueChanged += new System.EventHandler(this.tllueAddMenu_EditValueChanged);
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeListLookUpEdit1TreeList.KeyFieldName = "MenuID";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "MenuName";
            this.treeListColumn1.FieldName = "MenuName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // lueAuthority
            // 
            this.lueAuthority.Location = new System.Drawing.Point(574, 20);
            this.lueAuthority.Name = "lueAuthority";
            this.lueAuthority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAuthority.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Authority Name")});
            this.lueAuthority.Properties.DisplayMember = "Name";
            this.lueAuthority.Properties.KeyMember = "ID";
            this.lueAuthority.Properties.NullText = "Select  a text";
            this.lueAuthority.Properties.NullValuePrompt = "Select  a text";
            this.lueAuthority.Properties.NullValuePromptShowForEmptyValue = true;
            this.lueAuthority.Size = new System.Drawing.Size(189, 20);
            this.lueAuthority.TabIndex = 816;
            // 
            // lueAddRole
            // 
            this.lueAddRole.Location = new System.Drawing.Point(52, 20);
            this.lueAddRole.Name = "lueAddRole";
            this.lueAddRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAddRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Role Name")});
            this.lueAddRole.Properties.DisplayMember = "Name";
            this.lueAddRole.Properties.KeyMember = "ID";
            this.lueAddRole.Properties.NullText = "Select  a role";
            this.lueAddRole.Properties.NullValuePrompt = "Select  a role";
            this.lueAddRole.Properties.NullValuePromptShowForEmptyValue = true;
            this.lueAddRole.Size = new System.Drawing.Size(189, 20);
            this.lueAddRole.TabIndex = 814;
            this.lueAddRole.EditValueChanged += new System.EventHandler(this.lueAddRole_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 813;
            this.label3.Text = "Menu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 811;
            this.label2.Text = "Button Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 810;
            this.label1.Text = "Role:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.Location = new System.Drawing.Point(787, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 803;
            this.btnSave.Text = "Save[&S]";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.teQueryMenu);
            this.panel2.Controls.Add(this.teQueryRole);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.sbtnQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 54);
            this.panel2.TabIndex = 813;
            // 
            // teQueryMenu
            // 
            this.teQueryMenu.Location = new System.Drawing.Point(291, 21);
            this.teQueryMenu.Name = "teQueryMenu";
            this.teQueryMenu.Size = new System.Drawing.Size(188, 20);
            this.teQueryMenu.TabIndex = 815;
            // 
            // teQueryRole
            // 
            this.teQueryRole.Location = new System.Drawing.Point(53, 20);
            this.teQueryRole.Name = "teQueryRole";
            this.teQueryRole.Size = new System.Drawing.Size(188, 20);
            this.teQueryRole.TabIndex = 814;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 813;
            this.label4.Text = "Menu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 14);
            this.label6.TabIndex = 810;
            this.label6.Text = "Role:";
            // 
            // sbtnQuery
            // 
            this.sbtnQuery.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.sbtnQuery.Appearance.Options.UseBackColor = true;
            this.sbtnQuery.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbtnQuery.Location = new System.Drawing.Point(787, 16);
            this.sbtnQuery.Name = "sbtnQuery";
            this.sbtnQuery.Size = new System.Drawing.Size(87, 27);
            this.sbtnQuery.TabIndex = 803;
            this.sbtnQuery.Text = "Query[&Q]";
            this.sbtnQuery.Click += new System.EventHandler(this.sbtnQuery_Click);
            // 
            // gcRoleMenuAuthority
            // 
            this.gcRoleMenuAuthority.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcRoleMenuAuthority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoleMenuAuthority.Location = new System.Drawing.Point(0, 108);
            this.gcRoleMenuAuthority.MainView = this.gvRoleMenuAuthority;
            this.gcRoleMenuAuthority.Margin = new System.Windows.Forms.Padding(0);
            this.gcRoleMenuAuthority.Name = "gcRoleMenuAuthority";
            this.gcRoleMenuAuthority.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repHyperLinkDownFile,
            this.repositoryItemImageEdit1,
            this.rpLinkDownFile,
            this.repositoryItemCheckEdit,
            this.ribeDeleteRoleMenuAuthority});
            this.gcRoleMenuAuthority.Size = new System.Drawing.Size(933, 417);
            this.gcRoleMenuAuthority.TabIndex = 814;
            this.gcRoleMenuAuthority.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRoleMenuAuthority});
            // 
            // gvRoleMenuAuthority
            // 
            this.gvRoleMenuAuthority.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.gvRoleMenuAuthority.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRoleMenuAuthority.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4});
            this.gvRoleMenuAuthority.GridControl = this.gcRoleMenuAuthority;
            this.gvRoleMenuAuthority.IndicatorWidth = 35;
            this.gvRoleMenuAuthority.Name = "gvRoleMenuAuthority";
            this.gvRoleMenuAuthority.OptionsCustomization.AllowFilter = false;
            this.gvRoleMenuAuthority.OptionsCustomization.AllowSort = false;
            this.gvRoleMenuAuthority.OptionsMenu.EnableColumnMenu = false;
            this.gvRoleMenuAuthority.OptionsView.ColumnAutoWidth = false;
            this.gvRoleMenuAuthority.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Role  Name";
            this.gridColumn3.FieldName = "RoleName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 206;
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
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 239;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Button Text";
            this.gridColumn2.FieldName = "AuthorityName";
            this.gridColumn2.MinWidth = 200;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 254;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Delete";
            this.gridColumn4.ColumnEdit = this.ribeDeleteRoleMenuAuthority;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // ribeDeleteRoleMenuAuthority
            // 
            this.ribeDeleteRoleMenuAuthority.AutoHeight = false;
            this.ribeDeleteRoleMenuAuthority.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.ribeDeleteRoleMenuAuthority.Name = "ribeDeleteRoleMenuAuthority";
            this.ribeDeleteRoleMenuAuthority.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ribeDeleteRoleMenuAuthority.Click += new System.EventHandler(this.ribeDeleteRoleMenuAuthority_Click);
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
            // FrmDistributeRoleMenuAuthorities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.gcRoleMenuAuthority);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDistributeRoleMenuAuthorities";
            this.Text = "FrmDistributeRoleMenuAuthorities";
            this.Load += new System.EventHandler(this.FrmDistributeRoleMenuAuthorities_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tllueAddMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAuthority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAddRole.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teQueryMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQueryRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoleMenuAuthority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoleMenuAuthority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDeleteRoleMenuAuthority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repHyperLinkDownFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpLinkDownFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl panel1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private PanelControl panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton sbtnQuery;
        private DevExpress.XtraGrid.GridControl gcRoleMenuAuthority;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRoleMenuAuthority;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repHyperLinkDownFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit rpLinkDownFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraEditors.TextEdit teQueryMenu;
        private DevExpress.XtraEditors.TextEdit teQueryRole;
        private DevExpress.XtraEditors.LookUpEdit lueAuthority;
        private DevExpress.XtraEditors.LookUpEdit lueAddRole;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeDeleteRoleMenuAuthority;
        private DevExpress.XtraEditors.TreeListLookUpEdit tllueAddMenu;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}