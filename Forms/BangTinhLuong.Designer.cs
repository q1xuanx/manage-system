namespace ManageSystem.Forms
{
    partial class BangTinhLuong
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
            this.cmbPhongBan = new System.Windows.Forms.ComboBox();
            this.dgvBangLuongNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTG = new System.Windows.Forms.DateTimePicker();
            this.ggbtn_TinhLuong = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ggbtn_Dieuchinh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.ggbtn_Huy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuongNV)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPhongBan.BackColor = System.Drawing.Color.White;
            this.cmbPhongBan.FormattingEnabled = true;
            this.cmbPhongBan.Location = new System.Drawing.Point(505, 102);
            this.cmbPhongBan.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cmbPhongBan.Name = "cmbPhongBan";
            this.cmbPhongBan.Size = new System.Drawing.Size(221, 24);
            this.cmbPhongBan.TabIndex = 5;
            // 
            // dgvBangLuongNV
            // 
            this.dgvBangLuongNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangLuongNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBangLuongNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuongNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4});
            this.dgvBangLuongNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBangLuongNV.Location = new System.Drawing.Point(0, 396);
            this.dgvBangLuongNV.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvBangLuongNV.Name = "dgvBangLuongNV";
            this.dgvBangLuongNV.RowHeadersWidth = 62;
            this.dgvBangLuongNV.RowTemplate.Height = 28;
            this.dgvBangLuongNV.Size = new System.Drawing.Size(1211, 290);
            this.dgvBangLuongNV.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Bảng Lương";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số ngày đi trễ";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số ngày về sớm";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số giờ làm";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng Tiền";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // dtpTG
            // 
            this.dtpTG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpTG.CustomFormat = "MMMM/ yyyy";
            this.dtpTG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTG.Location = new System.Drawing.Point(507, 150);
            this.dtpTG.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtpTG.Name = "dtpTG";
            this.dtpTG.Size = new System.Drawing.Size(220, 22);
            this.dtpTG.TabIndex = 8;
            // 
            // ggbtn_TinhLuong
            // 
            this.ggbtn_TinhLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ggbtn_TinhLuong.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_TinhLuong.BorderRadius = 20;
            this.ggbtn_TinhLuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_TinhLuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_TinhLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_TinhLuong.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_TinhLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_TinhLuong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.ggbtn_TinhLuong.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(250)))));
            this.ggbtn_TinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_TinhLuong.ForeColor = System.Drawing.Color.White;
            this.ggbtn_TinhLuong.Location = new System.Drawing.Point(321, 216);
            this.ggbtn_TinhLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_TinhLuong.Name = "ggbtn_TinhLuong";
            this.ggbtn_TinhLuong.Size = new System.Drawing.Size(135, 59);
            this.ggbtn_TinhLuong.TabIndex = 11;
            this.ggbtn_TinhLuong.Text = "Tính Lương";
            this.ggbtn_TinhLuong.Click += new System.EventHandler(this.btn_TinhLuong_Click);
            // 
            // ggbtn_Dieuchinh
            // 
            this.ggbtn_Dieuchinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ggbtn_Dieuchinh.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Dieuchinh.BorderRadius = 20;
            this.ggbtn_Dieuchinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Dieuchinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Dieuchinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Dieuchinh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Dieuchinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Dieuchinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.ggbtn_Dieuchinh.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(250)))));
            this.ggbtn_Dieuchinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_Dieuchinh.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Dieuchinh.Location = new System.Drawing.Point(742, 216);
            this.ggbtn_Dieuchinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_Dieuchinh.Name = "ggbtn_Dieuchinh";
            this.ggbtn_Dieuchinh.Size = new System.Drawing.Size(121, 59);
            this.ggbtn_Dieuchinh.TabIndex = 12;
            this.ggbtn_Dieuchinh.Text = "Điều chỉnh";
            this.ggbtn_Dieuchinh.Click += new System.EventHandler(this.btn_Dieuchinh_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(391, 103);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 13;
            this.metroSetLabel1.Text = "Phòng Ban";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(391, 150);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 14;
            this.metroSetLabel2.Text = "Thời gian";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.metroSetLabel3);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-29, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1269, 79);
            this.guna2GradientPanel1.TabIndex = 15;
            this.guna2GradientPanel1.Tag = "Phòng Ban";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroSetLabel3.Font = new System.Drawing.Font("UTM Alexander", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(492, 17);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(295, 56);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 0;
            this.metroSetLabel3.Text = "Bảng Tính Lương";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // ggbtn_Huy
            // 
            this.ggbtn_Huy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ggbtn_Huy.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Huy.BorderRadius = 20;
            this.ggbtn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Huy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.ggbtn_Huy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(250)))));
            this.ggbtn_Huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_Huy.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Huy.Location = new System.Drawing.Point(534, 216);
            this.ggbtn_Huy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_Huy.Name = "ggbtn_Huy";
            this.ggbtn_Huy.Size = new System.Drawing.Size(135, 59);
            this.ggbtn_Huy.TabIndex = 16;
            this.ggbtn_Huy.Text = "Hủy Bỏ ";
            this.ggbtn_Huy.Click += new System.EventHandler(this.guna2GradientButton1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bảng Lương Nhân Viên ";
            // 
            // BangTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 686);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ggbtn_Huy);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.ggbtn_Dieuchinh);
            this.Controls.Add(this.ggbtn_TinhLuong);
            this.Controls.Add(this.dtpTG);
            this.Controls.Add(this.dgvBangLuongNV);
            this.Controls.Add(this.cmbPhongBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "BangTinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BangTinhLuong";
            this.Load += new System.EventHandler(this.BangTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuongNV)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPhongBan;
        private System.Windows.Forms.DataGridView dgvBangLuongNV;
        private System.Windows.Forms.DateTimePicker dtpTG;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_TinhLuong;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Dieuchinh;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Huy;
        private System.Windows.Forms.Label label1;
    }
}