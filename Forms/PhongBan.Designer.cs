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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongBan));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Capnhat = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_MaPhongBan,
            this.clm_PhongBan,
            this.clm_TinhTrang});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 327);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(898, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.label2.Location = new System.Drawing.Point(262, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Phòng Ban";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Phòng Ban";
            // 
            // cb_MaPhong
            // 
            this.cb_MaPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_MaPhong.Location = new System.Drawing.Point(342, 90);
            this.cb_MaPhong.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cb_MaPhong.Name = "cb_MaPhong";
            this.cb_MaPhong.Size = new System.Drawing.Size(133, 20);
            this.cb_MaPhong.TabIndex = 4;
            // 
            // cb_TenPhong
            // 
            this.cb_TenPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TenPhong.Location = new System.Drawing.Point(342, 121);
            this.cb_TenPhong.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cb_TenPhong.Name = "cb_TenPhong";
            this.cb_TenPhong.Size = new System.Drawing.Size(133, 20);
            this.cb_TenPhong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tình Trạng";
            // 
            // cb_TinhTrang
            // 
            this.cb_TinhTrang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TinhTrang.FormattingEnabled = true;
            this.cb_TinhTrang.Location = new System.Drawing.Point(588, 89);
            this.cb_TinhTrang.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cb_TinhTrang.Name = "cb_TinhTrang";
            this.cb_TinhTrang.Size = new System.Drawing.Size(133, 21);
            this.cb_TinhTrang.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 36);
            this.label1.TabIndex = 47;
            this.label1.Text = "Danh Sách Phòng Ban ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 29);
            this.button2.TabIndex = 49;
            this.button2.Text = "Danh Sách Chức Vụ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BorderRadius = 20;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::ManageSystem.Properties.Resources.icons8_delete_50;
            this.btn_Xoa.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Xoa.Location = new System.Drawing.Point(567, 175);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(67, 49);
            this.btn_Xoa.TabIndex = 43;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.Animated = true;
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.BackgroundImage = global::ManageSystem.Properties.Resources.icons8_add_50;
            this.btn_Them.BorderRadius = 20;
            this.btn_Them.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = global::ManageSystem.Properties.Resources.icons8_add_50;
            this.btn_Them.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Them.Location = new System.Drawing.Point(313, 175);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(67, 49);
            this.btn_Them.TabIndex = 44;
            this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Capnhat
            // 
            this.btn_Capnhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Capnhat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Capnhat.BorderRadius = 20;
            this.btn_Capnhat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_Capnhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Capnhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Capnhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Capnhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Capnhat.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_Capnhat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Capnhat.ForeColor = System.Drawing.Color.White;
            this.btn_Capnhat.Image = global::ManageSystem.Properties.Resources.icons8_edit_24__1_;
            this.btn_Capnhat.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Capnhat.Location = new System.Drawing.Point(441, 175);
            this.btn_Capnhat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Capnhat.Name = "btn_Capnhat";
            this.btn_Capnhat.Size = new System.Drawing.Size(67, 49);
            this.btn_Capnhat.TabIndex = 45;
            this.btn_Capnhat.UseTransparentBackground = true;
            this.btn_Capnhat.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(133)))), ((int)(((byte)(216)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(898, 59);
            this.label6.TabIndex = 20;
            this.label6.Text = "   Danh Sách Phòng Ban";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.ClientSize = new System.Drawing.Size(898, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Capnhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_TinhTrang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_TenPhong);
            this.Controls.Add(this.cb_MaPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "PhongBan";
            this.Text = "PhongBan";
            this.Load += new System.EventHandler(this.PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2Button btn_Capnhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}