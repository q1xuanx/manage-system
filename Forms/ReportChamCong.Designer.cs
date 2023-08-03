namespace ManageSystem.Forms
{
    partial class ReportChamCong
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cHITIETBANGCHAMCONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptCTCC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayBC = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ggbtn_Chon = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETBANGCHAMCONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cHITIETBANGCHAMCONGBindingSource
            // 
            this.cHITIETBANGCHAMCONGBindingSource.DataSource = typeof(ManageSystem.Models.CHITIETBANGCHAMCONG);
            // 
            // rptCTCC
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cHITIETBANGCHAMCONGBindingSource;
            this.rptCTCC.LocalReport.DataSources.Add(reportDataSource1);
            this.rptCTCC.LocalReport.ReportEmbeddedResource = "ManageSystem.MakeReport.re.rdlc";
            this.rptCTCC.Location = new System.Drawing.Point(16, 210);
            this.rptCTCC.Margin = new System.Windows.Forms.Padding(4);
            this.rptCTCC.Name = "rptCTCC";
            this.rptCTCC.ServerReport.BearerToken = null;
            this.rptCTCC.Size = new System.Drawing.Size(985, 332);
            this.rptCTCC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ngày cần báo cáo";
            // 
            // dtpNgayBC
            // 
            this.dtpNgayBC.Location = new System.Drawing.Point(511, 92);
            this.dtpNgayBC.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayBC.Name = "dtpNgayBC";
            this.dtpNgayBC.Size = new System.Drawing.Size(296, 22);
            this.dtpNgayBC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("UTM Alexander", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xuất Chi Tiết Chấm Công ";
            // 
            // ggbtn_Chon
            // 
            this.ggbtn_Chon.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Chon.BorderRadius = 20;
            this.ggbtn_Chon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Chon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Chon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Chon.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Chon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Chon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_Chon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggbtn_Chon.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Chon.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ggbtn_Chon.Location = new System.Drawing.Point(453, 136);
            this.ggbtn_Chon.Name = "ggbtn_Chon";
            this.ggbtn_Chon.Size = new System.Drawing.Size(116, 52);
            this.ggbtn_Chon.TabIndex = 53;
            this.ggbtn_Chon.Text = "Chọn";
            this.ggbtn_Chon.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.ClientSize = new System.Drawing.Size(1018, 562);
            this.Controls.Add(this.ggbtn_Chon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayBC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptCTCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportChamCong";
            this.Text = "ReportChamCong";
            this.Load += new System.EventHandler(this.ReportChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETBANGCHAMCONGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptCTCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cHITIETBANGCHAMCONGBindingSource;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Chon;
    }
}