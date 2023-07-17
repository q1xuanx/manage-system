using ManageSystem.Forms;
using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainMenu = ManageSystem.Forms.MainMenu;

namespace ManageSystem
{
    public partial class DangNhap : Form
    {
        Model1 db = new Model1();
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
                Console.WriteLine("Ban da thoat !");
                this.Close();
            }
        }
  
        private void tb_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                var check = db.ACCOUNTs.Where(s => s.USERNAME == txt_UserName.Text && s.PASSWORD == txt_Password.Text);
                if (check.Any())
                {
                    MainMenu frm = new MainMenu();
                    this.Hide();
                    frm.Show();
                }else
                {
                    MessageBox.Show("Sai ten tai khoan hoac mat khau");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
