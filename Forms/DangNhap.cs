using ManageSystem.Forms;
using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem
{
    public partial class DangNhap : Form
    {
        DBContext db = new DBContext();
        public DangNhap()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ban co muon thoat ?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
              
                this.Close();
            }
        }

        private void tb_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

            if (txt_UserName.Text != "" && txt_Password.Text != "")
            {
                
                string pass = Utils.HashPassword(txt_Password.Text);
                ACCOUNT account = db.ACCOUNTs.FirstOrDefault(p => p.USERNAME.CompareTo(txt_UserName.Text) == 0 && p.PASSWORD.CompareTo(pass) == 0);
                //  a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3
                if (account != null)
                {
                    FormHome formHome = new FormHome();
                    MessageBox.Show("Đăng Nhập Thành Công");
                    this.Hide();
                    formHome.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
            }
        }
    }
}
