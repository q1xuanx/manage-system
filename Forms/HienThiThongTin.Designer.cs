namespace ManageSystem.Forms
{
    partial class HienThiThongTin
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
            this.label4 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_passnew = new System.Windows.Forms.TextBox();
            this.tb_confirmnewpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_Thaydoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu Cũ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới";
            // 
            // tb_pass
            // 
            this.tb_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_pass.Location = new System.Drawing.Point(223, 174);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(241, 22);
            this.tb_pass.TabIndex = 5;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_passnew
            // 
            this.tb_passnew.Location = new System.Drawing.Point(223, 234);
            this.tb_passnew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_passnew.Name = "tb_passnew";
            this.tb_passnew.Size = new System.Drawing.Size(241, 22);
            this.tb_passnew.TabIndex = 6;
            this.tb_passnew.UseSystemPasswordChar = true;
            // 
            // tb_confirmnewpass
            // 
            this.tb_confirmnewpass.Location = new System.Drawing.Point(223, 293);
            this.tb_confirmnewpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_confirmnewpass.Name = "tb_confirmnewpass";
            this.tb_confirmnewpass.Size = new System.Drawing.Size(241, 22);
            this.tb_confirmnewpass.TabIndex = 8;
            this.tb_confirmnewpass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Xác nhận mật khẩu mới";
            // 
            // tb_username
            // 
            this.tb_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_username.Location = new System.Drawing.Point(223, 117);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(241, 22);
            this.tb_username.TabIndex = 11;
            // 
            // btn_Thaydoi
            // 
            this.btn_Thaydoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Thaydoi.BackColor = System.Drawing.Color.Transparent;
            this.btn_Thaydoi.BorderRadius = 20;
            this.btn_Thaydoi.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_Thaydoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thaydoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thaydoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thaydoi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thaydoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Thaydoi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.btn_Thaydoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Thaydoi.ForeColor = System.Drawing.Color.White;
            this.btn_Thaydoi.Location = new System.Drawing.Point(223, 351);
            this.btn_Thaydoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thaydoi.Name = "btn_Thaydoi";
            this.btn_Thaydoi.Size = new System.Drawing.Size(101, 46);
            this.btn_Thaydoi.TabIndex = 14;
            this.btn_Thaydoi.Text = "Thay Đổi";
            this.btn_Thaydoi.Click += new System.EventHandler(this.btn_Thaydoi_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(615, 71);
            this.label8.TabIndex = 21;
            this.label8.Text = "Thay Đổi Mật Khẩu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Image = global::ManageSystem.Properties.Resources.icons8_return_40;
            this.button1.Location = new System.Drawing.Point(396, 350);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 47);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HienThiThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 462);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Thaydoi);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_confirmnewpass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_passnew);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HienThiThongTin";
            this.Text = "HienThiThongTin";
            this.Load += new System.EventHandler(this.HienThiThongTin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_passnew;
        private System.Windows.Forms.TextBox tb_confirmnewpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_username;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Thaydoi;
        private System.Windows.Forms.Label label8;
    }
}