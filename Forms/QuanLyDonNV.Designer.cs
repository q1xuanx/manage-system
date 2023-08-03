namespace ManageSystem.Forms
{
    partial class QuanLyDon
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
            this.tb_Ma = new System.Windows.Forms.TextBox();
            this.cb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.rtb_nd = new System.Windows.Forms.RichTextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDSDT = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.ggbtn_CapNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ggbtn_Huy = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDT)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Ma
            // 
            this.tb_Ma.Location = new System.Drawing.Point(176, 169);
            this.tb_Ma.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tb_Ma.Name = "tb_Ma";
            this.tb_Ma.Size = new System.Drawing.Size(232, 22);
            this.tb_Ma.TabIndex = 2;
            // 
            // cb_TinhTrang
            // 
            this.cb_TinhTrang.FormattingEnabled = true;
            this.cb_TinhTrang.Location = new System.Drawing.Point(176, 413);
            this.cb_TinhTrang.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cb_TinhTrang.Name = "cb_TinhTrang";
            this.cb_TinhTrang.Size = new System.Drawing.Size(232, 24);
            this.cb_TinhTrang.TabIndex = 8;
            // 
            // rtb_nd
            // 
            this.rtb_nd.Location = new System.Drawing.Point(176, 266);
            this.rtb_nd.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.rtb_nd.Name = "rtb_nd";
            this.rtb_nd.Size = new System.Drawing.Size(229, 105);
            this.rtb_nd.TabIndex = 7;
            this.rtb_nd.Text = "";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(176, 212);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(229, 22);
            this.dtpNgayLap.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tình Trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("UTM Alexander", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(646, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 50);
            this.label6.TabIndex = 9;
            this.label6.Text = "Danh Sách Đơn Từ";
            // 
            // dgvDSDT
            // 
            this.dgvDSDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDSDT.Location = new System.Drawing.Point(437, 151);
            this.dgvDSDT.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvDSDT.Name = "dgvDSDT";
            this.dgvDSDT.RowHeadersWidth = 62;
            this.dgvDSDT.RowTemplate.Height = 28;
            this.dgvDSDT.Size = new System.Drawing.Size(749, 366);
            this.dgvDSDT.TabIndex = 11;
            this.dgvDSDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã Đơn";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Lập";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nội Dung";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tình Trạng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nội dung";
            // 
            // ggbtn_CapNhap
            // 
            this.ggbtn_CapNhap.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_CapNhap.BorderRadius = 20;
            this.ggbtn_CapNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_CapNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_CapNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_CapNhap.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_CapNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_CapNhap.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_CapNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_CapNhap.ForeColor = System.Drawing.Color.White;
            this.ggbtn_CapNhap.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ggbtn_CapNhap.Location = new System.Drawing.Point(90, 469);
            this.ggbtn_CapNhap.Name = "ggbtn_CapNhap";
            this.ggbtn_CapNhap.Size = new System.Drawing.Size(130, 48);
            this.ggbtn_CapNhap.TabIndex = 53;
            this.ggbtn_CapNhap.Text = "Cập Nhật";
            this.ggbtn_CapNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // ggbtn_Huy
            // 
            this.ggbtn_Huy.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Huy.BorderRadius = 20;
            this.ggbtn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Huy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Huy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_Huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_Huy.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Huy.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ggbtn_Huy.Location = new System.Drawing.Point(275, 469);
            this.ggbtn_Huy.Name = "ggbtn_Huy";
            this.ggbtn_Huy.Size = new System.Drawing.Size(130, 48);
            this.ggbtn_Huy.TabIndex = 53;
            this.ggbtn_Huy.Text = "Huỷ Bỏ";
            this.ggbtn_Huy.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuanLyDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 686);
            this.Controls.Add(this.ggbtn_Huy);
            this.Controls.Add(this.ggbtn_CapNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_TinhTrang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDSDT);
            this.Controls.Add(this.rtb_nd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Ma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayLap);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "QuanLyDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDonNV";
            this.Load += new System.EventHandler(this.QuanLyDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Ma;
        private System.Windows.Forms.ComboBox cb_TinhTrang;
        private System.Windows.Forms.RichTextBox rtb_nd;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_CapNhap;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Huy;
    }
}