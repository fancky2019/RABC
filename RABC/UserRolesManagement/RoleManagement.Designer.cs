using DevExpress.XtraEditors;

namespace WMS.UserRolesManagement
{
    partial class RoleManagement
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
            this.panel1 = new PanelControl();
            this.sbtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.teQueryName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.sbtDelete = new DevExpress.XtraEditors.SimpleButton();
            this.teRoleName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gcRoles = new DevExpress.XtraGrid.GridControl();
            this.gvRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repHyperLinkDownFile = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.rpLinkDownFile = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teQueryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repHyperLinkDownFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpLinkDownFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbtnQuery);
            this.panel1.Controls.Add(this.teQueryName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sbtDelete);
            this.panel1.Controls.Add(this.teRoleName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 125);
            this.panel1.TabIndex = 2;
            // 
            // sbtnQuery
            // 
            this.sbtnQuery.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.sbtnQuery.Appearance.Options.UseBackColor = true;
            this.sbtnQuery.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbtnQuery.Location = new System.Drawing.Point(400, 57);
            this.sbtnQuery.Name = "sbtnQuery";
            this.sbtnQuery.Size = new System.Drawing.Size(87, 27);
            this.sbtnQuery.TabIndex = 810;
            this.sbtnQuery.Text = "Query[&Q]";
            this.sbtnQuery.Click += new System.EventHandler(this.sbtnQuery_Click);
            // 
            // teQueryName
            // 
            this.teQueryName.Location = new System.Drawing.Point(111, 59);
            this.teQueryName.Name = "teQueryName";
            this.teQueryName.Size = new System.Drawing.Size(229, 20);
            this.teQueryName.TabIndex = 809;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 808;
            this.label2.Text = "RoleName:";
            // 
            // sbtDelete
            // 
            this.sbtDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.sbtDelete.Appearance.Options.UseBackColor = true;
            this.sbtDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbtDelete.Location = new System.Drawing.Point(40, 92);
            this.sbtDelete.Name = "sbtDelete";
            this.sbtDelete.Size = new System.Drawing.Size(87, 27);
            this.sbtDelete.TabIndex = 807;
            this.sbtDelete.Text = "Delete[&D]";
            this.sbtDelete.Click += new System.EventHandler(this.sbtDelete_Click);
            // 
            // teRoleName
            // 
            this.teRoleName.Location = new System.Drawing.Point(111, 24);
            this.teRoleName.Name = "teRoleName";
            this.teRoleName.Size = new System.Drawing.Size(229, 20);
            this.teRoleName.TabIndex = 806;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 805;
            this.label1.Text = "RoleName:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.Location = new System.Drawing.Point(400, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 804;
            this.btnSave.Text = "Save[&S]";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gcRoles
            // 
            this.gcRoles.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoles.Location = new System.Drawing.Point(0, 125);
            this.gcRoles.MainView = this.gvRoles;
            this.gcRoles.Margin = new System.Windows.Forms.Padding(0);
            this.gcRoles.Name = "gcRoles";
            this.gcRoles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repHyperLinkDownFile,
            this.repositoryItemImageEdit1,
            this.rpLinkDownFile,
            this.repositoryItemCheckEdit});
            this.gcRoles.Size = new System.Drawing.Size(933, 400);
            this.gcRoles.TabIndex = 811;
            this.gcRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRoles});
            // 
            // gvRoles
            // 
            this.gvRoles.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.gvRoles.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gvRoles.GridControl = this.gcRoles;
            this.gvRoles.IndicatorWidth = 35;
            this.gvRoles.Name = "gvRoles";
            this.gvRoles.OptionsCustomization.AllowFilter = false;
            this.gvRoles.OptionsCustomization.AllowSort = false;
            this.gvRoles.OptionsMenu.EnableColumnMenu = false;
            this.gvRoles.OptionsSelection.MultiSelect = true;
            this.gvRoles.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvRoles.OptionsView.ColumnAutoWidth = false;
            this.gvRoles.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Name";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 583;
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
            // FrmRoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.gcRoles);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRoleManagement";
            this.Text = "FrmRoleManagement";
            this.Load += new System.EventHandler(this.FrmRoleManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teQueryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repHyperLinkDownFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpLinkDownFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl panel1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit teRoleName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRoles;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repHyperLinkDownFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit rpLinkDownFile;
        private DevExpress.XtraEditors.SimpleButton sbtDelete;
        private DevExpress.XtraEditors.SimpleButton sbtnQuery;
        private DevExpress.XtraEditors.TextEdit teQueryName;
        private System.Windows.Forms.Label label2;
    }
}