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
    public partial class HienThiThongTin : Form
    {
        Model1 db = new Model1();
        public HienThiThongTin()
        {
            InitializeComponent();
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HienThiThongTin_Load(object sender, EventArgs e)
        {
            tb_username.Text = DangNhap.currAccount.ToString();
        }

        private void btn_Thaydoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_pass == null || tb_passnew.Text == null || tb_confirmnewpass.Text == null)
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                var check = db.ACCOUNTs.FirstOrDefault(s => s.PASSWORD == tb_pass.Text);
                if (check != null)
                {
                    if (tb_passnew.Text != tb_confirmnewpass.Text)
                    {
                        throw new Exception("Mật khẩu mới và nhập lại mật khẩu mới không giống nhau !");
                    }
                    else
                    {
                        check.PASSWORD = tb_pass.Text;
                        db.SaveChanges();
                        MessageBox.Show("Thay đổi mật khẩu thành công ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
