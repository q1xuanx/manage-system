using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.Forms
{
    public partial class AddNewAccount : Form
    {
        Model1 db = new Model1();
        public AddNewAccount()
        {
            InitializeComponent();
        }


        private void AddNewAccount_Load(object sender, EventArgs e)
        {
            string[] s = {"Admin", "Khác"};
            foreach (string ss in s)
            {
                cmb_role.Items.Add(ss);
            }
            string[] s1 = { "Hoạt động", "Đã Ngưng" };
            foreach (string ss in s1)
            {
                cmb_trangthai.Items.Add(ss);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            if (tb_IDUSER.Text == null || tb_manv.Text == null || tb_password.Text == null || tb_username.Text == null)
            {
                throw new Exception("Ban phai dien day du thong tin !");
            }
            var find = db.ACCOUNTs.FirstOrDefault(s => s.MANV == tb_manv.Text);
            if (find == null)
            {
                ACCOUNT ac = new ACCOUNT()
                {
                    IDACCOUNT = tb_IDUSER.Text,
                    USERNAME = tb_username.Text,
                    MANV = tb_manv.Text,
                    PASSWORD = Utils.HashPassword(tb_password.Text),
                    ROLE = (cmb_role.Text == "Admin" ? 1 : 2),
                    TRANGTHAI = (cmb_trangthai.Text == "Hoạt động" ? 1 : 0),
                };
                db.ACCOUNTs.Add(ac);
                db.SaveChanges();
                MessageBox.Show("Thêm Tài Khoản Mới Thành Công");
            }
            else
            {
                MessageBox.Show("Nhân viên trên đã có tài khoản");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            tb_IDUSER.Text = null;
            tb_username.Text = null;
            tb_manv.Text = null;    
            tb_password.Text = null;
            cmb_role.Text =  null;
            cmb_trangthai.Text = null;
        }
    }
}
