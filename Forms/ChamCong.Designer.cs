namespace ManageSystem.Forms
{
    partial class ChamCong
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
            this.dtpNgayChamCong = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.ggbtn_Tim = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.ggbtn_XuatBC = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayChamCong
            // 
            this.dtpNgayChamCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayChamCong.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChamCong.Location = new System.Drawing.Point(473, 162);
            this.dtpNgayChamCong.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtpNgayChamCong.Name = "dtpNgayChamCong";
            this.dtpNgayChamCong.Size = new System.Drawing.Size(291, 22);
            this.dtpNgayChamCong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày Chấm Công ";
            // 
            // dgvDSCC
            // 
            this.dgvDSCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSCC.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvDSCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSCC.GridColor = System.Drawing.Color.White;
            this.dgvDSCC.Location = new System.Drawing.Point(0, 368);
            this.dgvDSCC.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvDSCC.Name = "dgvDSCC";
            this.dgvDSCC.RowHeadersWidth = 62;
            this.dgvDSCC.RowTemplate.Height = 28;
            this.dgvDSCC.Size = new System.Drawing.Size(1211, 318);
            this.dgvDSCC.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Chấm Công";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("UTM Alexander", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh Sách Chấm Công";
            // 
            // ggbtn_Tim
            // 
            this.ggbtn_Tim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ggbtn_Tim.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_Tim.BorderRadius = 20;
            this.ggbtn_Tim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Tim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_Tim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Tim.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_Tim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_Tim.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_Tim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_Tim.ForeColor = System.Drawing.Color.White;
            this.ggbtn_Tim.Image = global::ManageSystem.Properties.Resources.icons8_search_30;
            this.ggbtn_Tim.ImageSize = new System.Drawing.Size(30, 30);
            this.ggbtn_Tim.Location = new System.Drawing.Point(446, 228);
            this.ggbtn_Tim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_Tim.Name = "ggbtn_Tim";
            this.ggbtn_Tim.Size = new System.Drawing.Size(151, 44);
            this.ggbtn_Tim.TabIndex = 5;
            this.ggbtn_Tim.Text = "Tìm kiếm";
            this.ggbtn_Tim.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("UTM Alexander", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1211, 86);
            this.label8.TabIndex = 22;
            this.label8.Text = "   Quản Lý Chấm Công";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ggbtn_XuatBC
            // 
            this.ggbtn_XuatBC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ggbtn_XuatBC.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_XuatBC.BorderRadius = 20;
            this.ggbtn_XuatBC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_XuatBC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_XuatBC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_XuatBC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_XuatBC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_XuatBC.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_XuatBC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_XuatBC.ForeColor = System.Drawing.Color.White;
            this.ggbtn_XuatBC.Image = global::ManageSystem.Properties.Resources.icons8_search_30__1_;
            this.ggbtn_XuatBC.ImageSize = new System.Drawing.Size(30, 30);
            this.ggbtn_XuatBC.Location = new System.Drawing.Point(634, 228);
            this.ggbtn_XuatBC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ggbtn_XuatBC.Name = "ggbtn_XuatBC";
            this.ggbtn_XuatBC.Size = new System.Drawing.Size(159, 44);
            this.ggbtn_XuatBC.TabIndex = 23;
            this.ggbtn_XuatBC.Text = "Xuất báo cáo";
            this.ggbtn_XuatBC.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 686);
            this.Controls.Add(this.ggbtn_XuatBC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ggbtn_Tim);
            this.Controls.Add(this.dgvDSCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayChamCong);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "ChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChamCong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayChamCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_Tim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_XuatBC;
    }
}