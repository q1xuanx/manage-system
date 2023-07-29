using ManageSystem.Forms;
using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainMenu = ManageSystem.Forms.MainMenu;

namespace ManageSystem
{
    public partial class DangNhap : Form
    {
        Model1 db = new Model1();
        public static string currAccount = "";
        public DangNhap()
        {
            InitializeComponent();
       

        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát ?", "EXIT", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("Thoát thành công !");
                this.Close();
            }
        }
  
       

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                //Utils hashPass = new Utils();
                string temp = Utils.HashPassword(txt_Password.Text);
                var check = db.ACCOUNTs.Where(s => s.USERNAME == txt_UserName.Text && s.PASSWORD == temp).ToList();
                if (check.Count > 0)
                {
                    int? takeRole = -1;
                    foreach(var item in check)
                    {
                        takeRole = item.ROLE;
                    }
                    if (takeRole == 1)
                    {
                        currAccount = txt_UserName.Text;
                        MainMenu main = new MainMenu(this);
                        LoadForm lf = new LoadForm();
                        this.Hide();
                        lf.Show();
                        while (!lf.IsDisposed)
                        {
                            Application.DoEvents();
                        }
                        main.Show();
                        
                    }
                    else
                    {
                        currAccount = txt_UserName.Text;
                        NhanVienMenu nv = new NhanVienMenu(this);
                        LoadForm lf = new LoadForm();
                        this.Hide();
                        lf.Show();
                        while (!lf.IsDisposed)
                        {
                            Application.DoEvents();
                        }
                        nv.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai ten tai khoan hoac mat khau");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked == true)
            {
                txt_Password.UseSystemPasswordChar = false;
            }else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }

      
    }
}
