namespace ManageSystem.Forms
{
    partial class BaoCaoTTNhanVien
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
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPhongBan = new System.Windows.Forms.ComboBox();
            this.rpvTTSV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ggbtn_Chon = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataSource = typeof(ManageSystem.Models.NHANVIEN);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo Cáo Thông Tin Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(365, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn phòng ban";
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.FormattingEnabled = true;
            this.cmbPhongBan.Location = new System.Drawing.Point(582, 92);
            this.cmbPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPhongBan.Name = "cmbPhongBan";
            this.cmbPhongBan.Size = new System.Drawing.Size(226, 24);
            this.cmbPhongBan.TabIndex = 3;
            // 
            // rpvTTSV
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nHANVIENBindingSource;
            this.rpvTTSV.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvTTSV.LocalReport.ReportEmbeddedResource = "ManageSystem.MakeReport.ReportNhanVien.rdlc";
            this.rpvTTSV.Location = new System.Drawing.Point(1, 227);
            this.rpvTTSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rpvTTSV.Name = "rpvTTSV";
            this.rpvTTSV.ServerReport.BearerToken = null;
            this.rpvTTSV.Size = new System.Drawing.Size(1212, 461);
            this.rpvTTSV.TabIndex = 5;
            // 
            // ggbtn_Chon
            // 
            this.ggbtn_Chon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ggbtn_Chon.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Chon.BorderRadius = 20;
            this.ggbtn_Chon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Chon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Chon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Chon.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Chon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Chon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.ggbtn_Chon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(250)))));
            this.ggbtn_Chon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_Chon.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Chon.Location = new System.Drawing.Point(540, 136);
            this.ggbtn_Chon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_Chon.Name = "ggbtn_Chon";
            this.ggbtn_Chon.Size = new System.Drawing.Size(121, 59);
            this.ggbtn_Chon.TabIndex = 13;
            this.ggbtn_Chon.Text = "Chọn";
            this.ggbtn_Chon.Click += new System.EventHandler(this.button1_Click);
            // 
            // BaoCaoTTNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 686);
            this.Controls.Add(this.ggbtn_Chon);
            this.Controls.Add(this.rpvTTSV);
            this.Controls.Add(this.cmbPhongBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BaoCaoTTNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCaoTTNhanVien";
            this.Load += new System.EventHandler(this.BaoCaoTTNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPhongBan;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTTSV;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Chon;
    }
}