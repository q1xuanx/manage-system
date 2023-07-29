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
    public partial class MainMenu : Form
    {
        DangNhap curForm;

        Form preFrom;
        public MainMenu(DangNhap login)
        {
            InitializeComponent();
            this.curForm = login;
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_TrangChinh, "Trang Chính");
            toolTip1.SetToolTip(btn_QLNS, "Quản Lý Nhân Sự");
            toolTip1.SetToolTip(btn_QLPB, "Quản Lý Phòng Ban");
            toolTip1.SetToolTip(btn_TinhLuong, "Tính Lương");
            toolTip1.SetToolTip(btn_ChamCOng, "Chấm Công");
            toolTip1.SetToolTip(btn_QuanLyTuyenDung, "Xuất Báo Cáo");
            toolTip1.SetToolTip(btn_QlDon, "Quản Lý Đơn");

            GioiThieu gt = new GioiThieu()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bạn có muốn thoát ?", "Xác Nhận", MessageBoxButtons.YesNo);
            {
                Application.Exit();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap login = new DangNhap();
            this.Close();
            curForm.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThiThongTin hienthi = new HienThiThongTin();
            hienthi.Show();
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100094518325648");
        }

        private void btn_TrangChinh_Click(object sender, EventArgs e)
        {
            GioiThieu gt = new GioiThieu()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
        }
        private void btn_QLNS_Click(object sender, EventArgs e)
        {
            FormCreateEmployee create = new FormCreateEmployee()
            {
                AutoSize = true,
                TopMost = true,
                TopLevel = false
            };
            create.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(create);
            create.BringToFront();
            create.Show();
           
        }

        private void btn_QLPB_Click(object sender, EventArgs e)
        {
            PhongBan create = new PhongBan()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false
            };
            create.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(create);
            create.BringToFront();
            create.Show();
        
        }

        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
            BangTinhLuong gt = new BangTinhLuong()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
        }

        private void btn_ChamCOng_Click(object sender, EventArgs e)
        {
            ChamCong gt = new ChamCong()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
     
        }

        private void btn_XuatBaoCao_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tuyendung.topcv.vn/?utm_source=epl-btn&utm_medium=nav-button&utm_campaign=click-tracking");
        }

        private void thêmTàiKhoảnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAccount gt = new AddNewAccount();
            gt.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            QuanLyDon gt = new QuanLyDon()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
        }
        private void báoCáoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoTTNhanVien frm = new BaoCaoTTNhanVien();
            frm.Show();
        }

        private void báoCáoChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportChamCong rp = new ReportChamCong();
            rp.Show();
        }
    }
}
