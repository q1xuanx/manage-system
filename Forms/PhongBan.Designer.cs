namespace ManageSystem.Forms
{
    partial class PhongBan
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
            this.dgvDSPB = new System.Windows.Forms.DataGridView();
            this.clm_MaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_PhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_MaPhong = new System.Windows.Forms.TextBox();
            this.cb_TenPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ggbtn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.ggbtn_Capnhat = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ggbtn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ggbtn_DSCV = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSPB
            // 
            this.dgvDSPB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDSPB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSPB.ColumnHeadersHeight = 29;
            this.dgvDSPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDSPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_MaPhongBan,
            this.clm_PhongBan,
            this.clm_TinhTrang});
            this.dgvDSPB.Location = new System.Drawing.Point(0, 394);
            this.dgvDSPB.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvDSPB.Name = "dgvDSPB";
            this.dgvDSPB.RowHeadersWidth = 62;
            this.dgvDSPB.RowTemplate.Height = 28;
            this.dgvDSPB.Size = new System.Drawing.Size(1243, 295);
            this.dgvDSPB.TabIndex = 0;
            this.dgvDSPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clm_MaPhongBan
            // 
            this.clm_MaPhongBan.HeaderText = "Mã Phòng Ban";
            this.clm_MaPhongBan.MinimumWidth = 8;
            this.clm_MaPhongBan.Name = "clm_MaPhongBan";
            // 
            // clm_PhongBan
            // 
            this.clm_PhongBan.HeaderText = "Tên Phòng Ban";
            this.clm_PhongBan.MinimumWidth = 8;
            this.clm_PhongBan.Name = "clm_PhongBan";
            // 
            // clm_TinhTrang
            // 
            this.clm_TinhTrang.HeaderText = "Tình Trạng";
            this.clm_TinhTrang.MinimumWidth = 8;
            this.clm_TinhTrang.Name = "clm_TinhTrang";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(377, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Phòng Ban";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(377, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Phòng Ban";
            // 
            // cb_MaPhong
            // 
            this.cb_MaPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_MaPhong.Location = new System.Drawing.Point(515, 113);
            this.cb_MaPhong.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cb_MaPhong.Name = "cb_MaPhong";
            this.cb_MaPhong.Size = new System.Drawing.Size(176, 22);
            this.cb_MaPhong.TabIndex = 4;
            // 
            // cb_TenPhong
            // 
            this.cb_TenPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TenPhong.Location = new System.Drawing.Point(515, 151);
            this.cb_TenPhong.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cb_TenPhong.Name = "cb_TenPhong";
            this.cb_TenPhong.Size = new System.Drawing.Size(176, 22);
            this.cb_TenPhong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(742, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tình Trạng";
            // 
            // cb_TinhTrang
            // 
            this.cb_TinhTrang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TinhTrang.FormattingEnabled = true;
            this.cb_TinhTrang.Location = new System.Drawing.Point(845, 113);
            this.cb_TinhTrang.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cb_TinhTrang.Name = "cb_TinhTrang";
            this.cb_TinhTrang.Size = new System.Drawing.Size(176, 24);
            this.cb_TinhTrang.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 42);
            this.label1.TabIndex = 47;
            this.label1.Text = "Danh Sách Phòng Ban ";
            // 
            // ggbtn_Xoa
            // 
            this.ggbtn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Xoa.BorderRadius = 20;
            this.ggbtn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ggbtn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Xoa.FillColor = System.Drawing.Color.Red;
            this.ggbtn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggbtn_Xoa.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Xoa.Image = global::ManageSystem.Properties.Resources.icons8_delete_50;
            this.ggbtn_Xoa.ImageSize = new System.Drawing.Size(35, 35);
            this.ggbtn_Xoa.Location = new System.Drawing.Point(932, 217);
            this.ggbtn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_Xoa.Name = "ggbtn_Xoa";
            this.ggbtn_Xoa.Size = new System.Drawing.Size(89, 60);
            this.ggbtn_Xoa.TabIndex = 43;
            this.ggbtn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // ggbtn_Capnhat
            // 
            this.ggbtn_Capnhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ggbtn_Capnhat.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Capnhat.BorderRadius = 20;
            this.ggbtn_Capnhat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.ggbtn_Capnhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Capnhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Capnhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Capnhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Capnhat.FillColor = System.Drawing.Color.SkyBlue;
            this.ggbtn_Capnhat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggbtn_Capnhat.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Capnhat.Image = global::ManageSystem.Properties.Resources.icons8_edit_24__1_;
            this.ggbtn_Capnhat.ImageSize = new System.Drawing.Size(35, 35);
            this.ggbtn_Capnhat.Location = new System.Drawing.Point(724, 217);
            this.ggbtn_Capnhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_Capnhat.Name = "ggbtn_Capnhat";
            this.ggbtn_Capnhat.Size = new System.Drawing.Size(89, 60);
            this.ggbtn_Capnhat.TabIndex = 45;
            this.ggbtn_Capnhat.UseTransparentBackground = true;
            this.ggbtn_Capnhat.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1211, 73);
            this.label6.TabIndex = 20;
            this.label6.Text = "   Danh Sách Phòng Ban";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ggbtn_Them
            // 
            this.ggbtn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ggbtn_Them.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Them.BorderRadius = 20;
            this.ggbtn_Them.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.ggbtn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Them.FillColor = System.Drawing.Color.LimeGreen;
            this.ggbtn_Them.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.ggbtn_Them.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Them.Image = global::ManageSystem.Properties.Resources.icons8_add_50;
            this.ggbtn_Them.ImageSize = new System.Drawing.Size(35, 35);
            this.ggbtn_Them.Location = new System.Drawing.Point(515, 217);
            this.ggbtn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_Them.Name = "ggbtn_Them";
            this.ggbtn_Them.Size = new System.Drawing.Size(89, 60);
            this.ggbtn_Them.TabIndex = 50;
            this.ggbtn_Them.UseTransparentBackground = true;
            this.ggbtn_Them.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ManageSystem.Properties.Resources.Whrite_Tím_Hiện_đại_Logo_Công_nghệ___Trò_chơi;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // ggbtn_DSCV
            // 
            this.ggbtn_DSCV.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_DSCV.BorderRadius = 20;
            this.ggbtn_DSCV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_DSCV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_DSCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_DSCV.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_DSCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_DSCV.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_DSCV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_DSCV.ForeColor = System.Drawing.Color.White;
            this.ggbtn_DSCV.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ggbtn_DSCV.Location = new System.Drawing.Point(900, 314);
            this.ggbtn_DSCV.Name = "ggbtn_DSCV";
            this.ggbtn_DSCV.Size = new System.Drawing.Size(180, 56);
            this.ggbtn_DSCV.TabIndex = 52;
            this.ggbtn_DSCV.Text = "Danh Sách Chức Vụ";
            this.ggbtn_DSCV.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 686);
            this.Controls.Add(this.ggbtn_DSCV);
            this.Controls.Add(this.ggbtn_Them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ggbtn_Xoa);
            this.Controls.Add(this.ggbtn_Capnhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_TinhTrang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_TenPhong);
            this.Controls.Add(this.cb_MaPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDSPB);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "PhongBan";
            this.Text = "PhongBan";
            this.Load += new System.EventHandler(this.PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cb_MaPhong;
        private System.Windows.Forms.TextBox cb_TenPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_MaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_PhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TinhTrang;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button ggbtn_Xoa;
        private Guna.UI2.WinForms.Guna2Button ggbtn_Capnhat;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ggbtn_Them;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_DSCV;
    }
}