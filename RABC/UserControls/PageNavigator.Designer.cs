namespace RABC.UserControls
{
    partial class PageNavigator
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbtnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnUp = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnNext = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnLast = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCount = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblInfo = new DevExpress.XtraEditors.LabelControl();
            this.tePageIndex = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePageIndex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tePageIndex);
            this.panelControl1.Controls.Add(this.lblInfo);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cmbCount);
            this.panelControl1.Controls.Add(this.sbtnLast);
            this.panelControl1.Controls.Add(this.sbtnNext);
            this.panelControl1.Controls.Add(this.sbtnUp);
            this.panelControl1.Controls.Add(this.sbtnFirst);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(550, 35);
            this.panelControl1.TabIndex = 0;
            // 
            // sbtnFirst
            // 
            this.sbtnFirst.Location = new System.Drawing.Point(30, 7);
            this.sbtnFirst.Name = "sbtnFirst";
            this.sbtnFirst.Size = new System.Drawing.Size(50, 23);
            this.sbtnFirst.TabIndex = 0;
            this.sbtnFirst.Text = "首页";
            this.sbtnFirst.Click += new System.EventHandler(this.sbtnFirst_Click);
            // 
            // sbtnUp
            // 
            this.sbtnUp.Location = new System.Drawing.Point(100, 7);
            this.sbtnUp.Name = "sbtnUp";
            this.sbtnUp.Size = new System.Drawing.Size(50, 23);
            this.sbtnUp.TabIndex = 2;
            this.sbtnUp.Text = "上一页";
            this.sbtnUp.Click += new System.EventHandler(this.sbtnUp_Click);
            // 
            // sbtnNext
            // 
            this.sbtnNext.Location = new System.Drawing.Point(240, 7);
            this.sbtnNext.Name = "sbtnNext";
            this.sbtnNext.Size = new System.Drawing.Size(50, 23);
            this.sbtnNext.TabIndex = 3;
            this.sbtnNext.Text = "下一页";
            this.sbtnNext.Click += new System.EventHandler(this.sbtnNext_Click);
            // 
            // sbtnLast
            // 
            this.sbtnLast.Location = new System.Drawing.Point(310, 7);
            this.sbtnLast.Name = "sbtnLast";
            this.sbtnLast.Size = new System.Drawing.Size(50, 23);
            this.sbtnLast.TabIndex = 4;
            this.sbtnLast.Text = "尾页";
            this.sbtnLast.Click += new System.EventHandler(this.sbtnLast_Click);
            // 
            // cmbCount
            // 
            this.cmbCount.Location = new System.Drawing.Point(410, 8);
            this.cmbCount.Name = "cmbCount";
            this.cmbCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCount.Properties.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "50",
            "100"});
            this.cmbCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCount.Size = new System.Drawing.Size(57, 20);
            this.cmbCount.TabIndex = 5;
            this.cmbCount.SelectedIndexChanged += new System.EventHandler(this.cmbCount_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(380, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "每页";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(473, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(12, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "条";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(521, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(24, 14);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "每页";
            // 
            // tePageIndex
            // 
            this.tePageIndex.EditValue = "1";
            this.tePageIndex.Location = new System.Drawing.Point(170, 10);
            this.tePageIndex.Name = "tePageIndex";
            this.tePageIndex.Properties.ReadOnly = true;
            this.tePageIndex.Size = new System.Drawing.Size(50, 20);
            this.tePageIndex.TabIndex = 9;
            // 
            // PageNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "PageNavigator";
            this.Size = new System.Drawing.Size(550, 35);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePageIndex.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCount;
        private DevExpress.XtraEditors.SimpleButton sbtnLast;
        private DevExpress.XtraEditors.SimpleButton sbtnNext;
        private DevExpress.XtraEditors.SimpleButton sbtnUp;
        private DevExpress.XtraEditors.SimpleButton sbtnFirst;
        private DevExpress.XtraEditors.TextEdit tePageIndex;
        private DevExpress.XtraEditors.LabelControl lblInfo;
    }
}
