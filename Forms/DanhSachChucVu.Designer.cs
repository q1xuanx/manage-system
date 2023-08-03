namespace ManageSystem.Forms
{
    partial class DanhSachChucVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_macv = new System.Windows.Forms.TextBox();
            this.tb_tencv = new System.Windows.Forms.TextBox();
            this.dgvDSCV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ggbtn_CapNhat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ggbtn_Huy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ggbtn_Xoa = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Chức Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(191, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // tb_macv
            // 
            this.tb_macv.Location = new System.Drawing.Point(353, 178);
            this.tb_macv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_macv.Name = "tb_macv";
            this.tb_macv.Size = new System.Drawing.Size(320, 22);
            this.tb_macv.TabIndex = 3;
            // 
            // tb_tencv
            // 
            this.tb_tencv.Location = new System.Drawing.Point(353, 223);
            this.tb_tencv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tencv.Name = "tb_tencv";
            this.tb_tencv.Size = new System.Drawing.Size(320, 22);
            this.tb_tencv.TabIndex = 4;
            // 
            // dgvDSCV
            // 
            this.dgvDSCV.AllowDrop = true;
            this.dgvDSCV.AllowUserToAddRows = false;
            this.dgvDSCV.AllowUserToOrderColumns = true;
            this.dgvDSCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvDSCV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDSCV.Location = new System.Drawing.Point(68, 409);
            this.dgvDSCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSCV.Name = "dgvDSCV";
            this.dgvDSCV.ReadOnly = true;
            this.dgvDSCV.RowHeadersWidth = 62;
            this.dgvDSCV.RowTemplate.Height = 28;
            this.dgvDSCV.Size = new System.Drawing.Size(777, 166);
            this.dgvDSCV.TabIndex = 6;
            this.dgvDSCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Chức Vụ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Chức Vụ";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(545, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tìm Kiếm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(624, 374);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(200, 22);
            this.txtTim.TabIndex = 8;
            this.txtTim.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("UTM Alexander", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(916, 119);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh Sách Chức Vụ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ggbtn_CapNhat
            // 
            this.ggbtn_CapNhat.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_CapNhat.BorderRadius = 20;
            this.ggbtn_CapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_CapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_CapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_CapNhat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_CapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_CapNhat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.ggbtn_CapNhat.Location = new System.Drawing.Point(194, 282);
            this.ggbtn_CapNhat.Name = "ggbtn_CapNhat";
            this.ggbtn_CapNhat.Size = new System.Drawing.Size(121, 43);
            this.ggbtn_CapNhat.TabIndex = 50;
            this.ggbtn_CapNhat.Text = "Cập Nhật";
            this.ggbtn_CapNhat.Click += new System.EventHandler(this.button1_Click);
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
            this.ggbtn_Huy.Location = new System.Drawing.Point(372, 282);
            this.ggbtn_Huy.Name = "ggbtn_Huy";
            this.ggbtn_Huy.Size = new System.Drawing.Size(121, 43);
            this.ggbtn_Huy.TabIndex = 50;
            this.ggbtn_Huy.Text = "Huỷ Bỏ";
            this.ggbtn_Huy.Click += new System.EventHandler(this.button2_Click);
            // 
            // ggbtn_Xoa
            // 
            this.ggbtn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Xoa.BorderRadius = 20;
            this.ggbtn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Xoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Xoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_Xoa.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Xoa.Location = new System.Drawing.Point(552, 282);
            this.ggbtn_Xoa.Name = "ggbtn_Xoa";
            this.ggbtn_Xoa.Size = new System.Drawing.Size(121, 43);
            this.ggbtn_Xoa.TabIndex = 50;
            this.ggbtn_Xoa.Text = "Xoá";
            this.ggbtn_Xoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // DanhSachChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 598);
            this.Controls.Add(this.ggbtn_Xoa);
            this.Controls.Add(this.ggbtn_Huy);
            this.Controls.Add(this.ggbtn_CapNhat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDSCV);
            this.Controls.Add(this.tb_tencv);
            this.Controls.Add(this.tb_macv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DanhSachChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachChucVu";
            this.Load += new System.EventHandler(this.DanhSachChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_macv;
        private System.Windows.Forms.TextBox tb_tencv;
        private System.Windows.Forms.DataGridView dgvDSCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_CapNhat;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Huy;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Xoa;
    }
}