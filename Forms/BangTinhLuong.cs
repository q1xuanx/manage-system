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
    public partial class BangTinhLuong : Form
    {
        Model1 db = new Model1();
        int phat = 100000;
        public BangTinhLuong()
        {
            InitializeComponent();
        }

      

        private void BindData (List<NHANVIEN> ct)
        {
            dgvBangLuongNV.Rows.Clear();
   
            foreach(NHANVIEN ch in ct)
            {
                int idx = dgvBangLuongNV.Rows.Add();
                dgvBangLuongNV.Rows[idx].Cells[0].Value = ch.MANV;
                dgvBangLuongNV.Rows[idx].Cells[1].Value = ch.MABANGLUONG;
                DateTime start = new DateTime(dtpTG.Value.Year, dtpTG.Value.Month, 1);
                DateTime end = start.AddMonths(1).AddDays(-1);
                TimeSpan ?wstart = new TimeSpan(7, 35, 0);
                TimeSpan? goTime = new TimeSpan(17, 30, 0);
                var findTotalTime = db.CHITIETBANGCHAMCONGs.Where(s => s.MANV == ch.MANV && s.NGAYCHAMCONG >= start && s.NGAYCHAMCONG <= end).ToList();
                float totalTime = 0, cntWstart = 0, cntGoTime = 0;
                foreach ( var t in findTotalTime)
                {
                    TimeSpan? temp = t.GIORA - t.GIOVAO;
                    if (temp.HasValue)
                    {
                        totalTime += (float)temp.Value.TotalHours;
                    }
                    if ((t.GIOVAO - wstart) > TimeSpan.Zero)
                    {
                        cntWstart++;
                    }
                    if ((t.GIORA - goTime) < TimeSpan.Zero)
                    {
                        cntGoTime++;
                    }
                }
                dgvBangLuongNV.Rows[idx].Cells[2].Value = cntWstart.ToString();
                dgvBangLuongNV.Rows[idx].Cells[3].Value = cntGoTime.ToString();
                dgvBangLuongNV.Rows[idx].Cells[4].Value = totalTime.ToString();
                double? total = 1.0;
                var pay = db.BANGLUONGs.Where(s => s.MABANGLUONG == ch.MABANGLUONG).ToList();
                foreach(var s in pay)
                {
                    total = s.HESOPHUCAP * s.HESOLUONG * s.LUONGCOBAN;
                }
                total = Math.Round((double)((total - (((cntWstart * phat) + (cntGoTime * phat)))) * (totalTime / 8)), 2);
                dgvBangLuongNV.Rows[idx].Cells[5].Value = total.ToString();
            }
        }

        private void BangTinhLuong_Load(object sender, EventArgs e)
        {
            cmbPhongBan.DataSource = db.PHONGBANs.ToList();
            cmbPhongBan.DisplayMember = "TENPHONGBAN";
            cmbPhongBan.ValueMember = "MAPHONGBAN";
            var find = db.NHANVIENs.Where(s => s.MAPHONGBAN == cmbPhongBan.SelectedValue.ToString()).ToList();
            BindData(find);
        }
        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
            var find = db.NHANVIENs.Where(s => s.MAPHONGBAN == cmbPhongBan.SelectedValue.ToString()).ToList();
            BindData(find);
        }

        private void btn_Dieuchinh_Click(object sender, EventArgs e)
        {
            HienThiBangLuong ht = new HienThiBangLuong();
            ht.Show();

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            dgvBangLuongNV.Rows.Clear();
            cmbPhongBan.SelectedIndex = 0;
        }
    }
}
