namespace ManageSystem.Forms
{
    partial class ChamCongNhanVienMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamCongNhanVienMode));
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_ChamCong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ggbtn_ChamCong = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.BackgroundColor = System.Drawing.Color.White;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvChamCong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChamCong.Location = new System.Drawing.Point(0, 251);
            this.dgvChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 62;
            this.dgvChamCong.RowTemplate.Height = 28;
            this.dgvChamCong.Size = new System.Drawing.Size(838, 210);
            this.dgvChamCong.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Chấm Công ";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giờ vào";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giờ ra ";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(64, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(779, 66);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chấm Công Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTP_ChamCong
            // 
            this.DTP_ChamCong.BackColor = System.Drawing.Color.White;
            this.DTP_ChamCong.Checked = true;
            this.DTP_ChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTP_ChamCong.FillColor = System.Drawing.Color.White;
            this.DTP_ChamCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTP_ChamCong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTP_ChamCong.Location = new System.Drawing.Point(327, 87);
            this.DTP_ChamCong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_ChamCong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_ChamCong.Name = "DTP_ChamCong";
            this.DTP_ChamCong.Size = new System.Drawing.Size(268, 35);
            this.DTP_ChamCong.TabIndex = 4;
            this.DTP_ChamCong.Value = new System.DateTime(2023, 7, 24, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 147);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 22);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // ggbtn_ChamCong
            // 
            this.ggbtn_ChamCong.BackColor = System.Drawing.Color.Transparent;
            this.ggbtn_ChamCong.BorderRadius = 20;
            this.ggbtn_ChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ggbtn_ChamCong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_ChamCong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ggbtn_ChamCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_ChamCong.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ggbtn_ChamCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ggbtn_ChamCong.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.ggbtn_ChamCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggbtn_ChamCong.ForeColor = System.Drawing.Color.White;
            this.ggbtn_ChamCong.Location = new System.Drawing.Point(382, 186);
            this.ggbtn_ChamCong.Name = "ggbtn_ChamCong";
            this.ggbtn_ChamCong.Size = new System.Drawing.Size(156, 44);
            this.ggbtn_ChamCong.TabIndex = 48;
            this.ggbtn_ChamCong.Text = "Chấm Công";
            this.ggbtn_ChamCong.Click += new System.EventHandler(this.btn_Chamcong_Click_1);
            // 
            // ChamCongNhanVienMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 461);
            this.Controls.Add(this.ggbtn_ChamCong);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DTP_ChamCong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChamCong);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChamCongNhanVienMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChamCongNhanVienMode";
            this.Load += new System.EventHandler(this.ChamCongNhanVienMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_ChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2GradientButton ggbtn_ChamCong;
    }
}