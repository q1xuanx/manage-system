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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbt_Nam = new System.Windows.Forms.RadioButton();
            this.rbt_Nu = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clm_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_PhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_dell = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_findName = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.cb_ChucVu = new System.Windows.Forms.ComboBox();
            this.cb_PhongBan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(458, 162);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(256, 26);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Anddress
            // 
            this.txt_Anddress.Location = new System.Drawing.Point(461, 220);
            this.txt_Anddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Anddress.Name = "txt_Anddress";
            this.txt_Anddress.Size = new System.Drawing.Size(256, 26);
            this.txt_Anddress.TabIndex = 7;
            // 
            // cbb_BirthDay
            // 
            this.cbb_BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cbb_BirthDay.Location = new System.Drawing.Point(461, 281);
            this.cbb_BirthDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_BirthDay.Name = "cbb_BirthDay";
            this.cbb_BirthDay.Size = new System.Drawing.Size(256, 26);
            this.cbb_BirthDay.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(778, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chức Vụ ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(778, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tình Trạng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(758, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã Phòng Ban";
            // 
            // rbt_Nam
            // 
            this.rbt_Nam.AutoSize = true;
            this.rbt_Nam.Location = new System.Drawing.Point(484, 340);
            this.rbt_Nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbt_Nam.Name = "rbt_Nam";
            this.rbt_Nam.Size = new System.Drawing.Size(67, 24);
            this.rbt_Nam.TabIndex = 17;
            this.rbt_Nam.TabStop = true;
            this.rbt_Nam.Text = "Nam";
            this.rbt_Nam.UseVisualStyleBackColor = true;
            // 
            // rbt_Nu
            // 
            this.rbt_Nu.AutoSize = true;
            this.rbt_Nu.Location = new System.Drawing.Point(588, 340);
            this.rbt_Nu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbt_Nu.Name = "rbt_Nu";
            this.rbt_Nu.Size = new System.Drawing.Size(54, 24);
            this.rbt_Nu.TabIndex = 18;
            this.rbt_Nu.TabStop = true;
            this.rbt_Nu.Text = "Nữ";
            this.rbt_Nu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1499, 57);
            this.label6.TabIndex = 19;
            this.label6.Text = "Thông Tin Nhân Viên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_MaNV,
            this.clm_TenNV,
            this.clm_GioiTinh,
            this.clm_DiaChi,
            this.clm_TinhTrang,
            this.clm_NgaySinh,
            this.clm_PhongBan,
            this.clm_ChucVu});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 556);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1499, 276);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clm_MaNV
            // 
            this.clm_MaNV.HeaderText = "Mã NV";
            this.clm_MaNV.MinimumWidth = 8;
            this.clm_MaNV.Name = "clm_MaNV";
            this.clm_MaNV.ReadOnly = true;
            this.clm_MaNV.Width = 150;
            // 
            // clm_TenNV
            // 
            this.clm_TenNV.HeaderText = "Tên NV";
            this.clm_TenNV.MinimumWidth = 8;
            this.clm_TenNV.Name = "clm_TenNV";
            this.clm_TenNV.ReadOnly = true;
            this.clm_TenNV.Width = 150;
            // 
            // clm_GioiTinh
            // 
            this.clm_GioiTinh.HeaderText = "Giới Tính";
            this.clm_GioiTinh.MinimumWidth = 8;
            this.clm_GioiTinh.Name = "clm_GioiTinh";
            this.clm_GioiTinh.ReadOnly = true;
            this.clm_GioiTinh.Width = 150;
            // 
            // clm_DiaChi
            // 
            this.clm_DiaChi.HeaderText = "Địa Chỉ ";
            this.clm_DiaChi.MinimumWidth = 8;
            this.clm_DiaChi.Name = "clm_DiaChi";
            this.clm_DiaChi.ReadOnly = true;
            this.clm_DiaChi.Width = 150;
            // 
            // clm_TinhTrang
            // 
            this.clm_TinhTrang.HeaderText = "Tình Trạng";
            this.clm_TinhTrang.MinimumWidth = 8;
            this.clm_TinhTrang.Name = "clm_TinhTrang";
            this.clm_TinhTrang.ReadOnly = true;
            this.clm_TinhTrang.Width = 150;
            // 
            // clm_NgaySinh
            // 
            this.clm_NgaySinh.HeaderText = "Ngày Sinh";
            this.clm_NgaySinh.MinimumWidth = 8;
            this.clm_NgaySinh.Name = "clm_NgaySinh";
            this.clm_NgaySinh.ReadOnly = true;
            this.clm_NgaySinh.Width = 150;
            // 
            // clm_PhongBan
            // 
            this.clm_PhongBan.HeaderText = "Mã Phòng Ban ";
            this.clm_PhongBan.MinimumWidth = 8;
            this.clm_PhongBan.Name = "clm_PhongBan";
            this.clm_PhongBan.ReadOnly = true;
            this.clm_PhongBan.Width = 150;
            // 
            // clm_ChucVu
            // 
            this.clm_ChucVu.HeaderText = "Chức Vụ";
            this.clm_ChucVu.MinimumWidth = 8;
            this.clm_ChucVu.Name = "clm_ChucVu";
            this.clm_ChucVu.ReadOnly = true;
            this.clm_ChucVu.Width = 150;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(546, 409);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 48);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_dell
            // 
            this.btn_dell.Location = new System.Drawing.Point(888, 409);
            this.btn_dell.Name = "btn_dell";
            this.btn_dell.Size = new System.Drawing.Size(129, 48);
            this.btn_dell.TabIndex = 26;
            this.btn_dell.Text = "Xóa";
            this.btn_dell.UseVisualStyleBackColor = true;
            this.btn_dell.Click += new System.EventHandler(this.btn_dell_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(710, 409);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 48);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1016, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tìm Kiếm Tên";
            // 
            // txt_findName
            // 
            this.txt_findName.Location = new System.Drawing.Point(1126, 515);
            this.txt_findName.Name = "txt_findName";
            this.txt_findName.Size = new System.Drawing.Size(321, 26);
            this.txt_findName.TabIndex = 29;
            this.txt_findName.TextChanged += new System.EventHandler(this.txt_findName_TextChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(458, 105);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(256, 26);
            this.txt_ID.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Mã Nhân Viên";
            // 
            // cb_TinhTrang
            // 
            this.cb_TinhTrang.FormattingEnabled = true;
            this.cb_TinhTrang.Location = new System.Drawing.Point(901, 223);
            this.cb_TinhTrang.Name = "cb_TinhTrang";
            this.cb_TinhTrang.Size = new System.Drawing.Size(273, 28);
            this.cb_TinhTrang.TabIndex = 32;
            // 
            // cb_ChucVu
            // 
            this.cb_ChucVu.FormattingEnabled = true;
            this.cb_ChucVu.Location = new System.Drawing.Point(901, 105);
            this.cb_ChucVu.Name = "cb_ChucVu";
            this.cb_ChucVu.Size = new System.Drawing.Size(273, 28);
            this.cb_ChucVu.TabIndex = 33;
            // 
            // cb_PhongBan
            // 
            this.cb_PhongBan.FormattingEnabled = true;
            this.cb_PhongBan.Location = new System.Drawing.Point(901, 168);
            this.cb_PhongBan.Name = "cb_PhongBan";
            this.cb_PhongBan.Size = new System.Drawing.Size(273, 28);
            this.cb_PhongBan.TabIndex = 34;
            // 
            // FormCreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 832);
            this.Controls.Add(this.cb_PhongBan);
            this.Controls.Add(this.cb_ChucVu);
            this.Controls.Add(this.cb_TinhTrang);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_findName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_dell);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbt_Nu);
            this.Controls.Add(this.rbt_Nam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_BirthDay);
            this.Controls.Add(this.txt_Anddress);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCreateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QuanLyThongTinNhanVien";
            this.Load += new System.EventHandler(this.FormCreateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbt_Nam;
        private System.Windows.Forms.RadioButton rbt_Nu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_dell;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_findName;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_PhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ChucVu;
        private System.Windows.Forms.ComboBox cb_ChucVu;
        private System.Windows.Forms.ComboBox cb_PhongBan;
    }
}