namespace ManageSystem.Forms
{
    partial class HienThiBangLuong
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvChinhBangLuong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_BL = new System.Windows.Forms.TextBox();
            this.tb_PC = new System.Windows.Forms.TextBox();
            this.tb_HSL = new System.Windows.Forms.TextBox();
            this.tb_LCB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ggbtn_Dieuchinh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.ggbtn_Huy = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChinhBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bảng Lương";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ Số Phụ Cấp";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(255, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ Số Lương";
            // 
            // dgvChinhBangLuong
            // 
            this.dgvChinhBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChinhBangLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvChinhBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChinhBangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvChinhBangLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChinhBangLuong.Location = new System.Drawing.Point(0, 326);
            this.dgvChinhBangLuong.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvChinhBangLuong.Name = "dgvChinhBangLuong";
            this.dgvChinhBangLuong.ReadOnly = true;
            this.dgvChinhBangLuong.RowHeadersWidth = 62;
            this.dgvChinhBangLuong.RowTemplate.Height = 28;
            this.dgvChinhBangLuong.Size = new System.Drawing.Size(881, 166);
            this.dgvChinhBangLuong.TabIndex = 3;
            this.dgvChinhBangLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Bảng Lương";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hệ Số Phụ Cấp";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hệ Số Lương";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lương Cơ Bản";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tb_BL
            // 
            this.tb_BL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_BL.Location = new System.Drawing.Point(404, 92);
            this.tb_BL.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tb_BL.Name = "tb_BL";
            this.tb_BL.Size = new System.Drawing.Size(224, 22);
            this.tb_BL.TabIndex = 4;
            // 
            // tb_PC
            // 
            this.tb_PC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_PC.Location = new System.Drawing.Point(404, 134);
            this.tb_PC.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tb_PC.Name = "tb_PC";
            this.tb_PC.Size = new System.Drawing.Size(224, 22);
            this.tb_PC.TabIndex = 5;
            // 
            // tb_HSL
            // 
            this.tb_HSL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_HSL.Location = new System.Drawing.Point(404, 180);
            this.tb_HSL.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tb_HSL.Name = "tb_HSL";
            this.tb_HSL.Size = new System.Drawing.Size(224, 22);
            this.tb_HSL.TabIndex = 6;
            // 
            // tb_LCB
            // 
            this.tb_LCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_LCB.Location = new System.Drawing.Point(404, 225);
            this.tb_LCB.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tb_LCB.Name = "tb_LCB";
            this.tb_LCB.Size = new System.Drawing.Size(224, 22);
            this.tb_LCB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(255, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lương Cơ Bản";
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
            this.ggbtn_Dieuchinh.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_Dieuchinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggbtn_Dieuchinh.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Dieuchinh.Location = new System.Drawing.Point(258, 266);
            this.ggbtn_Dieuchinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_Dieuchinh.Name = "ggbtn_Dieuchinh";
            this.ggbtn_Dieuchinh.Size = new System.Drawing.Size(145, 44);
            this.ggbtn_Dieuchinh.TabIndex = 12;
            this.ggbtn_Dieuchinh.Text = "Điều chỉnh";
            this.ggbtn_Dieuchinh.Click += new System.EventHandler(this.btn_Dieuchinh_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("UTM Alexander", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(881, 80);
            this.label8.TabIndex = 21;
            this.label8.Text = "    Điều chỉnh bảng lương";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ggbtn_Huy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_Huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggbtn_Huy.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Huy.Location = new System.Drawing.Point(484, 266);
            this.ggbtn_Huy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_Huy.Name = "ggbtn_Huy";
            this.ggbtn_Huy.Size = new System.Drawing.Size(145, 44);
            this.ggbtn_Huy.TabIndex = 22;
            this.ggbtn_Huy.Text = "Hủy Bỏ";
            this.ggbtn_Huy.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // HienThiBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 492);
            this.Controls.Add(this.ggbtn_Huy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ggbtn_Dieuchinh);
            this.Controls.Add(this.tb_LCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_HSL);
            this.Controls.Add(this.tb_PC);
            this.Controls.Add(this.tb_BL);
            this.Controls.Add(this.dgvChinhBangLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "HienThiBangLuong";
            this.Text = "HienThiBangLuong";
            this.Load += new System.EventHandler(this.HienThiBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChinhBangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvChinhBangLuong;
        private System.Windows.Forms.TextBox tb_BL;
        private System.Windows.Forms.TextBox tb_PC;
        private System.Windows.Forms.TextBox tb_HSL;
        private System.Windows.Forms.TextBox tb_LCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Dieuchinh;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Huy;
    }
}