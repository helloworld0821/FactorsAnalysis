namespace FactorsAnalysis
{
    partial class Form1
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridResult = new DevExpress.XtraGrid.GridControl();
            this.gridViewResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblResult = new DevExpress.XtraEditors.LabelControl();
            this.txtResultPath = new DevExpress.XtraEditors.TextEdit();
            this.btnResult = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblFA = new DevExpress.XtraEditors.LabelControl();
            this.txtFAPath = new DevExpress.XtraEditors.TextEdit();
            this.btnOpenFA = new DevExpress.XtraEditors.SimpleButton();
            this.lblLTK = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.txtLTKPath = new DevExpress.XtraEditors.TextEdit();
            this.btnOpenLTK = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::FactorsAnalysis.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFAPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLTKPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(534, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(430, 370);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridResult);
            this.panelControl1.Controls.Add(this.lblResult);
            this.panelControl1.Controls.Add(this.txtResultPath);
            this.panelControl1.Controls.Add(this.btnResult);
            this.panelControl1.Controls.Add(this.cmbDate);
            this.panelControl1.Controls.Add(this.lblFA);
            this.panelControl1.Controls.Add(this.txtFAPath);
            this.panelControl1.Controls.Add(this.btnOpenFA);
            this.panelControl1.Controls.Add(this.lblLTK);
            this.panelControl1.Controls.Add(this.lblDate);
            this.panelControl1.Controls.Add(this.txtLTKPath);
            this.panelControl1.Controls.Add(this.btnOpenLTK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(674, 422);
            this.panelControl1.TabIndex = 11;
            // 
            // gridResult
            // 
            this.gridResult.Location = new System.Drawing.Point(5, 313);
            this.gridResult.MainView = this.gridViewResult;
            this.gridResult.Name = "gridResult";
            this.gridResult.Size = new System.Drawing.Size(400, 82);
            this.gridResult.TabIndex = 25;
            this.gridResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResult});
            // 
            // gridViewResult
            // 
            this.gridViewResult.GridControl = this.gridResult;
            this.gridViewResult.Name = "gridViewResult";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(39, 245);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(87, 14);
            this.lblResult.TabIndex = 24;
            this.lblResult.Text = "文件另存为(.xls)";
            // 
            // txtResultPath
            // 
            this.txtResultPath.Enabled = false;
            this.txtResultPath.Location = new System.Drawing.Point(112, 279);
            this.txtResultPath.Name = "txtResultPath";
            this.txtResultPath.Size = new System.Drawing.Size(349, 20);
            this.txtResultPath.TabIndex = 23;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(474, 276);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 22;
            this.btnResult.Text = "选择";
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // cmbDate
            // 
            this.cmbDate.Location = new System.Drawing.Point(113, 208);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbDate.Size = new System.Drawing.Size(349, 20);
            this.cmbDate.TabIndex = 21;
            this.cmbDate.SelectedIndexChanged += new System.EventHandler(this.cmbDate_SelectedIndexChanged);
            // 
            // lblFA
            // 
            this.lblFA.Location = new System.Drawing.Point(39, 35);
            this.lblFA.Name = "lblFA";
            this.lblFA.Size = new System.Drawing.Size(96, 14);
            this.lblFA.TabIndex = 20;
            this.lblFA.Text = "影响因素文件选择";
            // 
            // txtFAPath
            // 
            this.txtFAPath.Enabled = false;
            this.txtFAPath.Location = new System.Drawing.Point(113, 66);
            this.txtFAPath.Name = "txtFAPath";
            this.txtFAPath.Size = new System.Drawing.Size(349, 20);
            this.txtFAPath.TabIndex = 19;
            // 
            // btnOpenFA
            // 
            this.btnOpenFA.Location = new System.Drawing.Point(474, 65);
            this.btnOpenFA.Name = "btnOpenFA";
            this.btnOpenFA.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFA.TabIndex = 18;
            this.btnOpenFA.Text = "打开";
            this.btnOpenFA.Click += new System.EventHandler(this.btnOpenFA_Click);
            // 
            // lblLTK
            // 
            this.lblLTK.Location = new System.Drawing.Point(39, 106);
            this.lblLTK.Name = "lblLTK";
            this.lblLTK.Size = new System.Drawing.Size(111, 14);
            this.lblLTK.TabIndex = 17;
            this.lblLTK.Text = "连通库文件选择(.xls)";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(39, 181);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 14);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "日期选择";
            // 
            // txtLTKPath
            // 
            this.txtLTKPath.Enabled = false;
            this.txtLTKPath.Location = new System.Drawing.Point(113, 137);
            this.txtLTKPath.Name = "txtLTKPath";
            this.txtLTKPath.Size = new System.Drawing.Size(349, 20);
            this.txtLTKPath.TabIndex = 12;
            // 
            // btnOpenLTK
            // 
            this.btnOpenLTK.Location = new System.Drawing.Point(474, 136);
            this.btnOpenLTK.Name = "btnOpenLTK";
            this.btnOpenLTK.Size = new System.Drawing.Size(75, 23);
            this.btnOpenLTK.TabIndex = 10;
            this.btnOpenLTK.Text = "打开";
            this.btnOpenLTK.Click += new System.EventHandler(this.btnOpenLTK_Click);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 422);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "影响因素分析";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFAPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLTKPath.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDate;
        private DevExpress.XtraEditors.LabelControl lblFA;
        private DevExpress.XtraEditors.TextEdit txtFAPath;
        private DevExpress.XtraEditors.SimpleButton btnOpenFA;
        private DevExpress.XtraEditors.LabelControl lblLTK;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.TextEdit txtLTKPath;
        private DevExpress.XtraEditors.SimpleButton btnOpenLTK;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraEditors.TextEdit txtResultPath;
        private DevExpress.XtraEditors.SimpleButton btnResult;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.GridControl gridResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResult;
    }
}

