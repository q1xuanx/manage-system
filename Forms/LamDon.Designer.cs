namespace ManageSystem.Forms
{
    partial class LamDon
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
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.dtpNgayNop = new System.Windows.Forms.DateTimePicker();
            this.rtb_nd = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDSDaNop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ggbtn_NopDon = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.ggbtn_Huy = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDaNop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Nộp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(420, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nội Dung ";
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(109, 92);
            this.tb_manv.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.ReadOnly = true;
            this.tb_manv.Size = new System.Drawing.Size(277, 22);
            this.tb_manv.TabIndex = 3;
            // 
            // dtpNgayNop
            // 
            this.dtpNgayNop.Enabled = false;
            this.dtpNgayNop.Location = new System.Drawing.Point(109, 132);
            this.dtpNgayNop.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtpNgayNop.Name = "dtpNgayNop";
            this.dtpNgayNop.Size = new System.Drawing.Size(277, 22);
            this.dtpNgayNop.TabIndex = 4;
            // 
            // rtb_nd
            // 
            this.rtb_nd.Location = new System.Drawing.Point(521, 90);
            this.rtb_nd.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.rtb_nd.Name = "rtb_nd";
            this.rtb_nd.Size = new System.Drawing.Size(445, 152);
            this.rtb_nd.TabIndex = 5;
            this.rtb_nd.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(303, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Danh Sách Đơn Đã Nộp";
            // 
            // dgvDSDaNop
            // 
            this.dgvDSDaNop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDaNop.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDaNop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDaNop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDSDaNop.Location = new System.Drawing.Point(-2, 295);
            this.dgvDSDaNop.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvDSDaNop.Name = "dgvDSDaNop";
            this.dgvDSDaNop.RowHeadersWidth = 62;
            this.dgvDSDaNop.RowTemplate.Height = 28;
            this.dgvDSDaNop.Size = new System.Drawing.Size(980, 198);
            this.dgvDSDaNop.TabIndex = 9;
            this.dgvDSDaNop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Nộp";
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
            // ggbtn_NopDon
            // 
            this.ggbtn_NopDon.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_NopDon.BorderRadius = 20;
            this.ggbtn_NopDon.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ggbtn_NopDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_NopDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_NopDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_NopDon.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_NopDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_NopDon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_NopDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggbtn_NopDon.ForeColor = System.Drawing.Color.White;
            this.ggbtn_NopDon.Location = new System.Drawing.Point(68, 198);
            this.ggbtn_NopDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_NopDon.Name = "ggbtn_NopDon";
            this.ggbtn_NopDon.Size = new System.Drawing.Size(137, 44);
            this.ggbtn_NopDon.TabIndex = 11;
            this.ggbtn_NopDon.Text = "Nộp Đơn";
            this.ggbtn_NopDon.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("UTM Alexander", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(908, 83);
            this.label8.TabIndex = 21;
            this.label8.Text = "    Làm Đơn";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ggbtn_Huy
            // 
            this.ggbtn_Huy.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Huy.BorderRadius = 20;
            this.ggbtn_Huy.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ggbtn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Huy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Huy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_Huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggbtn_Huy.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Huy.Location = new System.Drawing.Point(249, 198);
            this.ggbtn_Huy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_Huy.Name = "ggbtn_Huy";
            this.ggbtn_Huy.Size = new System.Drawing.Size(137, 44);
            this.ggbtn_Huy.TabIndex = 22;
            this.ggbtn_Huy.Text = "Hủy Bỏ";
            this.ggbtn_Huy.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // LamDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 492);
            this.Controls.Add(this.ggbtn_Huy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ggbtn_NopDon);
            this.Controls.Add(this.dgvDSDaNop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_nd);
            this.Controls.Add(this.dtpNgayNop);
            this.Controls.Add(this.tb_manv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "LamDon";
            this.Text = "LamDon";
            this.Load += new System.EventHandler(this.LamDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDaNop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.DateTimePicker dtpNgayNop;
        private System.Windows.Forms.RichTextBox rtb_nd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDSDaNop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_NopDon;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Huy;
    }
}