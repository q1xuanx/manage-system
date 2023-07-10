using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem
{
    public partial class DangNhap : Form
    {
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

        private void bt_1_Click(object sender, EventArgs e)
        {
            if (tb_1.Text != null && tb_2.Text != null)
            {
                MessageBox.Show("Dang nhap thanh cong !");
                QuanLy quanly = new QuanLy();
                quanly.ShowDialog();
                this.Hide();
            }
        }

        private void tb_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
