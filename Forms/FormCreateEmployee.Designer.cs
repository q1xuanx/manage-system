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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateEmployee));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clm_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_PhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Capnhat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Anddress = new System.Windows.Forms.TextBox();
            this.cbb_BirthDay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbt_Nam = new System.Windows.Forms.RadioButton();
            this.rbt_Nu = new System.Windows.Forms.RadioButton();
            this.txt_findName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.cb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.cb_ChucVu = new System.Windows.Forms.ComboBox();
            this.cb_PhongBan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_bangluong = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptcAvatar = new System.Windows.Forms.PictureBox();
            this.btn_addhinh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.button2 = new System.Windows.Forms.Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAvatar)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 506);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 215);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clm_MaNV
            // 
            this.clm_MaNV.HeaderText = "Mã NV";
            this.clm_MaNV.MinimumWidth = 8;
            this.clm_MaNV.Name = "clm_MaNV";
            this.clm_MaNV.ReadOnly = true;
            // 
            // clm_TenNV
            // 
            this.clm_TenNV.HeaderText = "Tên NV";
            this.clm_TenNV.MinimumWidth = 8;
            this.clm_TenNV.Name = "clm_TenNV";
            this.clm_TenNV.ReadOnly = true;
            // 
            // clm_GioiTinh
            // 
            this.clm_GioiTinh.HeaderText = "Giới Tính";
            this.clm_GioiTinh.MinimumWidth = 8;
            this.clm_GioiTinh.Name = "clm_GioiTinh";
            this.clm_GioiTinh.ReadOnly = true;
            // 
            // clm_DiaChi
            // 
            this.clm_DiaChi.HeaderText = "Địa Chỉ ";
            this.clm_DiaChi.MinimumWidth = 8;
            this.clm_DiaChi.Name = "clm_DiaChi";
            this.clm_DiaChi.ReadOnly = true;
            // 
            // clm_TinhTrang
            // 
            this.clm_TinhTrang.HeaderText = "Tình Trạng";
            this.clm_TinhTrang.MinimumWidth = 8;
            this.clm_TinhTrang.Name = "clm_TinhTrang";
            this.clm_TinhTrang.ReadOnly = true;
            // 
            // clm_NgaySinh
            // 
            this.clm_NgaySinh.HeaderText = "Ngày Sinh";
            this.clm_NgaySinh.MinimumWidth = 8;
            this.clm_NgaySinh.Name = "clm_NgaySinh";
            this.clm_NgaySinh.ReadOnly = true;
            // 
            // clm_PhongBan
            // 
            this.clm_PhongBan.HeaderText = "Mã Phòng Ban ";
            this.clm_PhongBan.MinimumWidth = 8;
            this.clm_PhongBan.Name = "clm_PhongBan";
            this.clm_PhongBan.ReadOnly = true;
            // 
            // clm_ChucVu
            // 
            this.clm_ChucVu.HeaderText = "Chức Vụ";
            this.clm_ChucVu.MinimumWidth = 8;
            this.clm_ChucVu.Name = "clm_ChucVu";
            this.clm_ChucVu.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this.btn_Them;
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.Animated = true;
            this.btn_Them.BackgroundImage = global::ManageSystem.Properties.Resources.icons8_add_50;
            this.btn_Them.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = global::ManageSystem.Properties.Resources.icons8_add_50;
            this.btn_Them.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Them.Location = new System.Drawing.Point(442, 297);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(80, 74);
            this.btn_Them.TabIndex = 42;
            this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 50;
            this.guna2Elipse2.TargetControl = this.btn_Capnhat;
            // 
            // btn_Capnhat
            // 
            this.btn_Capnhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Capnhat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Capnhat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_Capnhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Capnhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Capnhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Capnhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Capnhat.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_Capnhat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Capnhat.ForeColor = System.Drawing.Color.White;
            this.btn_Capnhat.Image = global::ManageSystem.Properties.Resources.icons8_edit_24__1_;
            this.btn_Capnhat.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Capnhat.Location = new System.Drawing.Point(593, 297);
            this.btn_Capnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Capnhat.Name = "btn_Capnhat";
            this.btn_Capnhat.Size = new System.Drawing.Size(80, 74);
            this.btn_Capnhat.TabIndex = 42;
            this.btn_Capnhat.UseTransparentBackground = true;
            this.btn_Capnhat.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 50;
            this.guna2Elipse3.TargetControl = this.btn_Xoa;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.DarkRed;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::ManageSystem.Properties.Resources.icons8_delete_50;
            this.btn_Xoa.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Xoa.Location = new System.Drawing.Point(745, 297);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(80, 74);
            this.btn_Xoa.TabIndex = 42;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(133)))), ((int)(((byte)(216)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1345, 90);
            this.label6.TabIndex = 19;
            this.label6.Text = "     Thông Tin Nhân Viên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(200, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(204, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(204, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(204, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(325, 110);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(275, 24);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Anddress
            // 
            this.txt_Anddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Anddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Anddress.Location = new System.Drawing.Point(325, 159);
            this.txt_Anddress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Anddress.Name = "txt_Anddress";
            this.txt_Anddress.Size = new System.Drawing.Size(275, 24);
            this.txt_Anddress.TabIndex = 7;
            // 
            // cbb_BirthDay
            // 
            this.cbb_BirthDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_BirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cbb_BirthDay.Location = new System.Drawing.Point(325, 206);
            this.cbb_BirthDay.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_BirthDay.Name = "cbb_BirthDay";
            this.cbb_BirthDay.Size = new System.Drawing.Size(275, 24);
            this.cbb_BirthDay.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(633, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chức Vụ ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(633, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã Phòng Ban";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(633, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tình Trạng";
            // 
            // rbt_Nam
            // 
            this.rbt_Nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbt_Nam.AutoSize = true;
            this.rbt_Nam.BackColor = System.Drawing.Color.Transparent;
            this.rbt_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Nam.ForeColor = System.Drawing.Color.Black;
            this.rbt_Nam.Location = new System.Drawing.Point(343, 257);
            this.rbt_Nam.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_Nam.Name = "rbt_Nam";
            this.rbt_Nam.Size = new System.Drawing.Size(61, 22);
            this.rbt_Nam.TabIndex = 17;
            this.rbt_Nam.TabStop = true;
            this.rbt_Nam.Text = "Nam";
            this.rbt_Nam.UseVisualStyleBackColor = false;
            // 
            // rbt_Nu
            // 
            this.rbt_Nu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbt_Nu.AutoSize = true;
            this.rbt_Nu.BackColor = System.Drawing.Color.Transparent;
            this.rbt_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Nu.ForeColor = System.Drawing.Color.Black;
            this.rbt_Nu.Location = new System.Drawing.Point(479, 257);
            this.rbt_Nu.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_Nu.Name = "rbt_Nu";
            this.rbt_Nu.Size = new System.Drawing.Size(48, 22);
            this.rbt_Nu.TabIndex = 18;
            this.rbt_Nu.TabStop = true;
            this.rbt_Nu.Text = "Nữ";
            this.rbt_Nu.UseVisualStyleBackColor = false;
            // 
            // txt_findName
            // 
            this.txt_findName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_findName.Location = new System.Drawing.Point(804, 395);
            this.txt_findName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_findName.Name = "txt_findName";
            this.txt_findName.Size = new System.Drawing.Size(309, 22);
            this.txt_findName.TabIndex = 29;
            this.txt_findName.TextChanged += new System.EventHandler(this.txt_findName_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(200, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 30;
            this.label12.Text = "Mã Nhân Viên";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(325, 64);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(275, 24);
            this.txt_ID.TabIndex = 31;
            // 
            // cb_TinhTrang
            // 
            this.cb_TinhTrang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TinhTrang.FormattingEnabled = true;
            this.cb_TinhTrang.Location = new System.Drawing.Point(771, 152);
            this.cb_TinhTrang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cb_TinhTrang.Name = "cb_TinhTrang";
            this.cb_TinhTrang.Size = new System.Drawing.Size(273, 26);
            this.cb_TinhTrang.TabIndex = 32;
            // 
            // cb_ChucVu
            // 
            this.cb_ChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ChucVu.FormattingEnabled = true;
            this.cb_ChucVu.Location = new System.Drawing.Point(771, 62);
            this.cb_ChucVu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cb_ChucVu.Name = "cb_ChucVu";
            this.cb_ChucVu.Size = new System.Drawing.Size(273, 26);
            this.cb_ChucVu.TabIndex = 33;
            // 
            // cb_PhongBan
            // 
            this.cb_PhongBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_PhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PhongBan.FormattingEnabled = true;
            this.cb_PhongBan.Location = new System.Drawing.Point(771, 108);
            this.cb_PhongBan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cb_PhongBan.Name = "cb_PhongBan";
            this.cb_PhongBan.Size = new System.Drawing.Size(273, 26);
            this.cb_PhongBan.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(633, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Mã Bảng Lương";
            // 
            // cb_bangluong
            // 
            this.cb_bangluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_bangluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bangluong.FormattingEnabled = true;
            this.cb_bangluong.Location = new System.Drawing.Point(771, 206);
            this.cb_bangluong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cb_bangluong.Name = "cb_bangluong";
            this.cb_bangluong.Size = new System.Drawing.Size(273, 26);
            this.cb_bangluong.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 395);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // ptcAvatar
            // 
            this.ptcAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptcAvatar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ptcAvatar.Location = new System.Drawing.Point(13, 64);
            this.ptcAvatar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ptcAvatar.Name = "ptcAvatar";
            this.ptcAvatar.Size = new System.Drawing.Size(165, 212);
            this.ptcAvatar.TabIndex = 41;
            this.ptcAvatar.TabStop = false;
            // 
            // btn_addhinh
            // 
            this.btn_addhinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addhinh.BackColor = System.Drawing.Color.Transparent;
            this.btn_addhinh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_addhinh.HoverState.ImageSize = new System.Drawing.Size(33, 33);
            this.btn_addhinh.Image = global::ManageSystem.Properties.Resources.icons8_add_image_30;
            this.btn_addhinh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_addhinh.ImageRotate = 0F;
            this.btn_addhinh.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_addhinh.Location = new System.Drawing.Point(65, 282);
            this.btn_addhinh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addhinh.Name = "btn_addhinh";
            this.btn_addhinh.PressedState.ImageSize = new System.Drawing.Size(33, 33);
            this.btn_addhinh.Size = new System.Drawing.Size(53, 39);
            this.btn_addhinh.TabIndex = 43;
            this.btn_addhinh.Click += new System.EventHandler(this.btn_addhinh_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(149, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 45;
            this.button2.Text = "Xuất Báo Cáo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2GradientPanel1.AutoSize = true;
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.pictureBox2);
            this.guna2GradientPanel1.Controls.Add(this.button2);
            this.guna2GradientPanel1.Controls.Add(this.btn_addhinh);
            this.guna2GradientPanel1.Controls.Add(this.ptcAvatar);
            this.guna2GradientPanel1.Controls.Add(this.btn_Xoa);
            this.guna2GradientPanel1.Controls.Add(this.btn_Them);
            this.guna2GradientPanel1.Controls.Add(this.btn_Capnhat);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.cb_bangluong);
            this.guna2GradientPanel1.Controls.Add(this.label9);
            this.guna2GradientPanel1.Controls.Add(this.cb_PhongBan);
            this.guna2GradientPanel1.Controls.Add(this.cb_ChucVu);
            this.guna2GradientPanel1.Controls.Add(this.cb_TinhTrang);
            this.guna2GradientPanel1.Controls.Add(this.txt_ID);
            this.guna2GradientPanel1.Controls.Add(this.label12);
            this.guna2GradientPanel1.Controls.Add(this.txt_findName);
            this.guna2GradientPanel1.Controls.Add(this.rbt_Nu);
            this.guna2GradientPanel1.Controls.Add(this.rbt_Nam);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.cbb_BirthDay);
            this.guna2GradientPanel1.Controls.Add(this.txt_Anddress);
            this.guna2GradientPanel1.Controls.Add(this.txt_Name);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(95, 57);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1183, 610);
            this.guna2GradientPanel1.TabIndex = 42;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 62);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormCreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::ManageSystem.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1345, 721);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreateEmployee";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.FormCreateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAvatar)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_PhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ChucVu;
        private object system;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2Button btn_Capnhat;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Anddress;
        private System.Windows.Forms.DateTimePicker cbb_BirthDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbt_Nam;
        private System.Windows.Forms.RadioButton rbt_Nu;
        private System.Windows.Forms.TextBox txt_findName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ComboBox cb_TinhTrang;
        private System.Windows.Forms.ComboBox cb_ChucVu;
        private System.Windows.Forms.ComboBox cb_PhongBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_bangluong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptcAvatar;
        private Guna.UI2.WinForms.Guna2ImageButton btn_addhinh;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}