namespace ManageSystem.Forms
{
    partial class FormPhongBan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenPhongBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SLNhanVien = new System.Windows.Forms.TextBox();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.cmb_TrangThai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phòng Ban :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng Ban";
            // 
            // txt_TenPhongBan
            // 
            this.txt_TenPhongBan.Location = new System.Drawing.Point(317, 218);
            this.txt_TenPhongBan.Name = "txt_TenPhongBan";
            this.txt_TenPhongBan.Size = new System.Drawing.Size(284, 22);
            this.txt_TenPhongBan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số Lượng Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trạng Thái";
            // 
            // txt_SLNhanVien
            // 
            this.txt_SLNhanVien.Location = new System.Drawing.Point(317, 263);
            this.txt_SLNhanVien.Name = "txt_SLNhanVien";
            this.txt_SLNhanVien.Size = new System.Drawing.Size(284, 22);
            this.txt_SLNhanVien.TabIndex = 7;
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Location = new System.Drawing.Point(317, 364);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(87, 43);
            this.btn_HoanTat.TabIndex = 8;
            this.btn_HoanTat.Text = "Hoàn Tất";
            this.btn_HoanTat.UseVisualStyleBackColor = true;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(483, 364);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(87, 43);
            this.btn_Dong.TabIndex = 9;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            // 
            // cmb_TrangThai
            // 
            this.cmb_TrangThai.FormattingEnabled = true;
            this.cmb_TrangThai.Items.AddRange(new object[] {
            "Đóng",
            "Mở"});
            this.cmb_TrangThai.Location = new System.Drawing.Point(317, 312);
            this.cmb_TrangThai.Name = "cmb_TrangThai";
            this.cmb_TrangThai.Size = new System.Drawing.Size(284, 24);
            this.cmb_TrangThai.TabIndex = 10;
            // 
            // FormPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_TrangThai);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.txt_SLNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenPhongBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormPhongBan";
            this.Text = "PhongBan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SLNhanVien;
        private System.Windows.Forms.Button btn_HoanTat;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.ComboBox cmb_TrangThai;
    }
}