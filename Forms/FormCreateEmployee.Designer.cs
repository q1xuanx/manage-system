namespace ManageSystem.Forms
{
    partial class FormCreateEmployee
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Anddress = new System.Windows.Forms.TextBox();
            this.cbb_BirthDay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DanToc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.rbt_Nam = new System.Windows.Forms.RadioButton();
            this.rbt_Nu = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.cmb_MaPhong = new System.Windows.Forms.ComboBox();
            this.cmb_TrinhDo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(243, 51);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(351, 22);
            this.txt_Name.TabIndex = 4;
            this.txt_Name.Text = "Tran HUus";
            // 
            // txt_Anddress
            // 
            this.txt_Anddress.Location = new System.Drawing.Point(243, 99);
            this.txt_Anddress.Name = "txt_Anddress";
            this.txt_Anddress.Size = new System.Drawing.Size(351, 22);
            this.txt_Anddress.TabIndex = 7;
            this.txt_Anddress.Text = "ssda";
            // 
            // cbb_BirthDay
            // 
            this.cbb_BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cbb_BirthDay.Location = new System.Drawing.Point(243, 150);
            this.cbb_BirthDay.Name = "cbb_BirthDay";
            this.cbb_BirthDay.Size = new System.Drawing.Size(99, 22);
            this.cbb_BirthDay.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dân Tộc";
            // 
            // txt_DanToc
            // 
            this.txt_DanToc.Location = new System.Drawing.Point(243, 264);
            this.txt_DanToc.Name = "txt_DanToc";
            this.txt_DanToc.Size = new System.Drawing.Size(351, 22);
            this.txt_DanToc.TabIndex = 10;
            this.txt_DanToc.Text = "ưqf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trình Độ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Phòng";
            // 
            // btn_Tao
            // 
            this.btn_Tao.Location = new System.Drawing.Point(345, 400);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(75, 38);
            this.btn_Tao.TabIndex = 16;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = true;
            this.btn_Tao.Click += new System.EventHandler(this.btn_Tao_Click);
            // 
            // rbt_Nam
            // 
            this.rbt_Nam.AutoSize = true;
            this.rbt_Nam.Location = new System.Drawing.Point(243, 209);
            this.rbt_Nam.Name = "rbt_Nam";
            this.rbt_Nam.Size = new System.Drawing.Size(57, 20);
            this.rbt_Nam.TabIndex = 17;
            this.rbt_Nam.TabStop = true;
            this.rbt_Nam.Text = "Nam";
            this.rbt_Nam.UseVisualStyleBackColor = true;
            // 
            // rbt_Nu
            // 
            this.rbt_Nu.AutoSize = true;
            this.rbt_Nu.Location = new System.Drawing.Point(306, 209);
            this.rbt_Nu.Name = "rbt_Nu";
            this.rbt_Nu.Size = new System.Drawing.Size(45, 20);
            this.rbt_Nu.TabIndex = 18;
            this.rbt_Nu.TabStop = true;
            this.rbt_Nu.Text = "Nữ";
            this.rbt_Nu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "THÊM NHÂN VIÊN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "SDT";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(435, 156);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(159, 22);
            this.txt_SDT.TabIndex = 22;
            this.txt_SDT.Text = "123";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(435, 201);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(159, 22);
            this.txt_Email.TabIndex = 23;
            this.txt_Email.Text = "abvc";
            // 
            // cmb_MaPhong
            // 
            this.cmb_MaPhong.FormattingEnabled = true;
            this.cmb_MaPhong.Location = new System.Drawing.Point(243, 315);
            this.cmb_MaPhong.Name = "cmb_MaPhong";
            this.cmb_MaPhong.Size = new System.Drawing.Size(351, 24);
            this.cmb_MaPhong.TabIndex = 24;
            this.cmb_MaPhong.SelectedIndexChanged += new System.EventHandler(this.cmb_MaPhong_SelectedIndexChanged);
            // 
            // cmb_TrinhDo
            // 
            this.cmb_TrinhDo.FormattingEnabled = true;
            this.cmb_TrinhDo.Location = new System.Drawing.Point(243, 360);
            this.cmb_TrinhDo.Name = "cmb_TrinhDo";
            this.cmb_TrinhDo.Size = new System.Drawing.Size(351, 24);
            this.cmb_TrinhDo.TabIndex = 25;
            // 
            // FormCreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_TrinhDo);
            this.Controls.Add(this.cmb_MaPhong);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbt_Nu);
            this.Controls.Add(this.rbt_Nam);
            this.Controls.Add(this.btn_Tao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_DanToc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_BirthDay);
            this.Controls.Add(this.txt_Anddress);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateEmployee";
            this.Text = "FormCreateEmployee";
            this.Load += new System.EventHandler(this.FormCreateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Anddress;
        private System.Windows.Forms.DateTimePicker cbb_BirthDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DanToc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.RadioButton rbt_Nam;
        private System.Windows.Forms.RadioButton rbt_Nu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.ComboBox cmb_MaPhong;
        private System.Windows.Forms.ComboBox cmb_TrinhDo;
    }
}