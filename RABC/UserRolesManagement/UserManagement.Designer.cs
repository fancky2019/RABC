using DevExpress.XtraEditors;

namespace WMS.UserRolesManagement
{
    partial class UserManagement
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelSave = new DevExpress.XtraEditors.PanelControl();
            this.sbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.teConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teAccount = new DevExpress.XtraEditors.TextEdit();
            this.panelQuery = new DevExpress.XtraEditors.PanelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.teQueryAccount = new DevExpress.XtraEditors.TextEdit();
            this.sbtnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.pageNavigator = new RABC.UserControls.PageNavigator();
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribeDeleteUser = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repHyperLinkDownFile = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.rpLinkDownFile = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSave)).BeginInit();
            this.panelSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelQuery)).BeginInit();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teQueryAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDeleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repHyperLinkDownFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpLinkDownFile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.Location = new System.Drawing.Point(711, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 20);
            this.btnSave.TabIndex = 802;
            this.btnSave.Text = "Save[&S]";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.sbtnCancel);
            this.panelSave.Controls.Add(this.teConfirmPassword);
            this.panelSave.Controls.Add(this.tePassword);
            this.panelSave.Controls.Add(this.label3);
            this.panelSave.Controls.Add(this.label2);
            this.panelSave.Controls.Add(this.label1);
            this.panelSave.Controls.Add(this.teAccount);
            this.panelSave.Controls.Add(this.btnSave);
            this.panelSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSave.Location = new System.Drawing.Point(0, 0);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(865, 57);
            this.panelSave.TabIndex = 804;
            // 
            // sbtnCancel
            // 
            this.sbtnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.sbtnCancel.Appearance.Options.UseBackColor = true;
            this.sbtnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbtnCancel.Location = new System.Drawing.Point(789, 21);
            this.sbtnCancel.Name = "sbtnCancel";
            this.sbtnCancel.Size = new System.Drawing.Size(64, 20);
            this.sbtnCancel.TabIndex = 809;
            this.sbtnCancel.Text = "Cancel[&c]";
            this.sbtnCancel.Click += new System.EventHandler(this.sbtnCancel_Click);
            // 
            // teConfirmPassword
            // 
            this.teConfirmPassword.Location = new System.Drawing.Point(411, 21);
            this.teConfirmPassword.Name = "teConfirmPassword";
            this.teConfirmPassword.Properties.PasswordChar = '*';
            this.teConfirmPassword.Size = new System.Drawing.Size(86, 20);
            this.teConfirmPassword.TabIndex = 808;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(214, 21);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(86, 20);
            this.tePassword.TabIndex = 807;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 14);
            this.label3.TabIndex = 806;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 805;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 804;
            this.label1.Text = "Account:";
            // 
            // teAccount
            // 
            this.teAccount.Location = new System.Drawing.Point(64, 21);
            this.teAccount.Name = "teAccount";
            this.teAccount.Size = new System.Drawing.Size(86, 20);
            this.teAccount.TabIndex = 803;
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.label6);
            this.panelQuery.Controls.Add(this.teQueryAccount);
            this.panelQuery.Controls.Add(this.sbtnQuery);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 57);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(865, 57);
            this.panelQuery.TabIndex = 806;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 804;
            this.label6.Text = "Account:";
            // 
            // teQueryAccount
            // 
            this.teQueryAccount.Location = new System.Drawing.Point(64, 21);
            this.teQueryAccount.Name = "teQueryAccount";
            this.teQueryAccount.Size = new System.Drawing.Size(86, 20);
            this.teQueryAccount.TabIndex = 803;
            // 
            // sbtnQuery
            // 
            this.sbtnQuery.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.sbtnQuery.Appearance.Options.UseBackColor = true;
            this.sbtnQuery.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.sbtnQuery.Location = new System.Drawing.Point(711, 16);
            this.sbtnQuery.Name = "sbtnQuery";
            this.sbtnQuery.Size = new System.Drawing.Size(64, 20);
            this.sbtnQuery.TabIndex = 802;
            this.sbtnQuery.Text = "Query";
            this.sbtnQuery.Click += new System.EventHandler(this.sbtnQuery_Click);
            // 
            // pageNavigator
            // 
            this.pageNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageNavigator.Location = new System.Drawing.Point(0, 519);
            this.pageNavigator.Name = "pageNavigator";
            this.pageNavigator.Size = new System.Drawing.Size(865, 35);
            this.pageNavigator.Skip = 0;
            this.pageNavigator.TabIndex = 810;
            this.pageNavigator.Total = 0;
            this.pageNavigator.PageIndexChanged += new System.Action<int, int>(this.pageNavigator_PageIndexChanged);
            // 
            // gcUser
            // 
            this.gcUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUser.Location = new System.Drawing.Point(0, 114);
            this.gcUser.MainView = this.gvUser;
            this.gcUser.Margin = new System.Windows.Forms.Padding(0);
            this.gcUser.Name = "gcUser";
            this.gcUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repHyperLinkDownFile,
            this.repositoryItemImageEdit1,
            this.rpLinkDownFile,
            this.repositoryItemCheckEdit,
            this.ribeDeleteUser});
            this.gcUser.Size = new System.Drawing.Size(865, 405);
            this.gcUser.TabIndex = 811;
            this.gcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUser});
            // 
            // gvUser
            // 
            this.gvUser.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue;
            this.gvUser.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvUser.GridControl = this.gcUser;
            this.gvUser.IndicatorWidth = 35;
            this.gvUser.Name = "gvUser";
            this.gvUser.OptionsCustomization.AllowFilter = false;
            this.gvUser.OptionsCustomization.AllowSort = false;
            this.gvUser.OptionsMenu.EnableColumnMenu = false;
            this.gvUser.OptionsView.ColumnAutoWidth = false;
            this.gvUser.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Account";
            this.gridColumn1.FieldName = "Account";
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 339;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Password";
            this.gridColumn2.FieldName = "Password";
            this.gridColumn2.MinWidth = 200;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 427;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Checked";
            this.gridColumn3.ColumnEdit = this.repositoryItemCheckEdit;
            this.gridColumn3.FieldName = "Checked";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Delete";
            this.gridColumn4.ColumnEdit = this.ribeDeleteUser;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // ribeDeleteUser
            // 
            this.ribeDeleteUser.AutoHeight = false;
            this.ribeDeleteUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.ribeDeleteUser.Name = "ribeDeleteUser";
            this.ribeDeleteUser.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcUser);
            this.Controls.Add(this.pageNavigator);
            this.Controls.Add(this.panelQuery);
            this.Controls.Add(this.panelSave);
            this.Name = "UserManagement";
            this.Size = new System.Drawing.Size(865, 554);
            this.Load += new System.EventHandler(this.FrmUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelSave)).EndInit();
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelQuery)).EndInit();
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teQueryAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribeDeleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repHyperLinkDownFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpLinkDownFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private PanelControl panelSave;
        private DevExpress.XtraEditors.TextEdit teConfirmPassword;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit teAccount;
        private PanelControl panelQuery;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit teQueryAccount;
        private DevExpress.XtraEditors.SimpleButton sbtnQuery;
        private DevExpress.XtraEditors.SimpleButton sbtnCancel;
        private RABC.UserControls.PageNavigator pageNavigator;
        private DevExpress.XtraGrid.GridControl gcUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribeDeleteUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repHyperLinkDownFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit rpLinkDownFile;
    }
}