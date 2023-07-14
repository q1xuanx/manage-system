namespace ManageSystem
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_1
            // 
            this.tb_1.BackColor = System.Drawing.SystemColors.Info;
            this.tb_1.Location = new System.Drawing.Point(160, 87);
            this.tb_1.Margin = new System.Windows.Forms.Padding(2);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(186, 20);
            this.tb_1.TabIndex = 1;
            this.tb_1.TextChanged += new System.EventHandler(this.tb_1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // tb_2
            // 
            this.tb_2.BackColor = System.Drawing.SystemColors.Info;
            this.tb_2.Location = new System.Drawing.Point(160, 119);
            this.tb_2.Margin = new System.Windows.Forms.Padding(2);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(186, 20);
            this.tb_2.TabIndex = 4;
            this.tb_2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hệ Thống Quản Lý Nhân Sự";
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(193, 158);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(82, 23);
            this.bt_1.TabIndex = 6;
            this.bt_1.Text = "Đăng Nhập";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(364, 198);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(75, 23);
            this.bt_2.TabIndex = 7;
            this.bt_2.Text = "Thoát";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 233);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
    }
}

