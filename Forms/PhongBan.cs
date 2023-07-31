using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.Forms
{
    public partial class PhongBan : Form
    {
        Model1 db = new Model1();
        public PhongBan()
        {
            InitializeComponent();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            string[] s = { "Hoạt Động", "Đã Ngưng" };
            foreach(string ss in s) cb_TinhTrang.Items.Add(ss);
            List<PHONGBAN> pb = db.PHONGBANs.ToList();
            BindGrid(pb);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void BindGrid(List<PHONGBAN> ls)
        {
            dataGridView1.Rows.Clear();
            foreach(PHONGBAN p in ls)
            {
                int idx = dataGridView1.Rows.Add();
                dataGridView1.Rows[idx].Cells[0].Value = p.MAPHONGBAN;
                dataGridView1.Rows[idx].Cells[1].Value = p.TENPHONGBAN;
                dataGridView1.Rows[idx].Cells[2].Value = (p.TRANGTHAI == 1 ? "Hoạt Động" : "Đã Ngưng");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            cb_MaPhong.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            cb_TenPhong.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            cb_TinhTrang.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
           
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var ask = MessageBox.Show("Bạn có muốn xóa?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                var find = db.PHONGBANs.FirstOrDefault(s => s.MAPHONGBAN == cb_MaPhong.Text);
                if (find != null)
                {
                    if (find.TRANGTHAI != 1)
                    {
                        db.PHONGBANs.Remove(find);
                        db.SaveChanges();
                        List<PHONGBAN> pb = db.PHONGBANs.ToList();
                        BindGrid(pb);
                    }
                    else
                    {
                        MessageBox.Show("Phong ban dang hoat dong khong the xoa !");
                    }
                }
                else
                {
                    MessageBox.Show("Not Found !");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DanhSachChucVu ds = new DanhSachChucVu();
            ds.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                PHONGBAN pb = db.PHONGBANs.FirstOrDefault(s => s.MAPHONGBAN == cb_MaPhong.Text);
                if (pb == null)
                {
                    pb = new PHONGBAN()
                    {
                        MAPHONGBAN = cb_MaPhong.Text,
                        TENPHONGBAN = cb_TenPhong.Text,
                        TRANGTHAI = (cb_TinhTrang.Text == "Hoạt Động" ? 1 : 0),
                    };
                    db.PHONGBANs.Add(pb);
                    MessageBox.Show("Thêm Mới Phòng Ban Thành Công");
                }
                else
                {
                    pb.MAPHONGBAN = cb_MaPhong.Text;
                    pb.TENPHONGBAN = cb_TenPhong.Text;
                    pb.TRANGTHAI = (cb_TinhTrang.Text == "Hoạt Động" ? 1 : 0);
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                db.SaveChanges();
                List<PHONGBAN> ls = db.PHONGBANs.ToList();
                BindGrid(ls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
