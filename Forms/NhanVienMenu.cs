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
    public partial class NhanVienMenu : Form
    {
        Model1 db = new Model1();
        DangNhap curForm;
        public static string currNhanVien = "";
        public NhanVienMenu(DangNhap dangNhap)
        {
            InitializeComponent();
            curForm = dangNhap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void NhanVienMenu_Load(object sender, EventArgs e)
        {
            ACCOUNT find = db.ACCOUNTs.FirstOrDefault(x => x.USERNAME == DangNhap.currAccount);
            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(x => x.MANV == find.MANV);
            lable_name.Text = nv.TENNV;
            currNhanVien = nv.MANV;
            TrangChinhNhanVien gt = new TrangChinhNhanVien()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panel_show.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            curForm.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            ChamCongNhanVienMode gt = new ChamCongNhanVienMode()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panel_show.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            LamDon gt = new LamDon()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panel_show.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            TrangChinhNhanVien gt = new TrangChinhNhanVien()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panel_show.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
        }
    }
}
