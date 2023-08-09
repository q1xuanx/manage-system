using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.Forms
{
    public partial class ChamCongNhanVienMode : Form
    {
        Model1 db = new Model1();
        public ChamCongNhanVienMode()
        {
            InitializeComponent();
        }


        private void BindData(List<CHITIETBANGCHAMCONG> ls)
        {
            dgvChamCong.Rows.Clear();
            foreach (CHITIETBANGCHAMCONG ct in ls)
            {
                int idx = dgvChamCong.Rows.Add();
                dgvChamCong.Rows[idx].Cells[0].Value = ct.MANV;
                dgvChamCong.Rows[idx].Cells[1].Value = ct.NGAYCHAMCONG.Date;
                dgvChamCong.Rows[idx].Cells[2].Value = ct.GIOVAO;
                dgvChamCong.Rows[idx].Cells[3].Value = ct.GIORA;
            }
        }

        private void ChamCongNhanVienMode_Load(object sender, EventArgs e)
        {
            List<CHITIETBANGCHAMCONG> ls = db.CHITIETBANGCHAMCONGs.Where(s => s.MANV == NhanVienMenu.currNhanVien).ToList();
            BindData(ls);
            DTP_ChamCong.Text = DateTime.Now.ToShortDateString();
            dateTimePicker1.CustomFormat = "HH:mm:ss";
        }




        private void btn_Chamcong_Click_1(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Text = DateTime.Now.ToLongTimeString();
                var check = db.CHITIETBANGCHAMCONGs.FirstOrDefault(s => s.MANV == NhanVienMenu.currNhanVien);
                if (check == null)
                {
                    CHITIETBANGCHAMCONG ct = new CHITIETBANGCHAMCONG()
                    {
                        MANV = NhanVienMenu.currNhanVien,
                        NGAYCHAMCONG = DateTime.ParseExact(DTP_ChamCong.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        GIOVAO = dateTimePicker1.Value.TimeOfDay
                    };
                    db.CHITIETBANGCHAMCONGs.Add(ct);
                    db.SaveChanges();
                    List<CHITIETBANGCHAMCONG> ls = db.CHITIETBANGCHAMCONGs.Where(s => s.MANV == NhanVienMenu.currNhanVien).ToList();
                    BindData(ls);
                }
                else
                {
                    var find = db.CHITIETBANGCHAMCONGs.FirstOrDefault(s => s.MANV == check.MANV && s.NGAYCHAMCONG == DTP_ChamCong.Value.Date);
                    if (find == null)
                    {
                        CHITIETBANGCHAMCONG ct = new CHITIETBANGCHAMCONG()
                        {
                            MANV = NhanVienMenu.currNhanVien,
                            NGAYCHAMCONG = DateTime.ParseExact(DTP_ChamCong.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            GIOVAO = dateTimePicker1.Value.TimeOfDay
                        };
                        db.CHITIETBANGCHAMCONGs.Add(ct);
                        db.SaveChanges();
                        List<CHITIETBANGCHAMCONG> ls = db.CHITIETBANGCHAMCONGs.Where(s => s.MANV == NhanVienMenu.currNhanVien).ToList();
                        BindData(ls);
                    }
                    else
                    {
                        if (find.GIORA == null)
                        {
                            find.MANV = NhanVienMenu.currNhanVien;
                            find.NGAYCHAMCONG = find.NGAYCHAMCONG;
                            find.GIOVAO = find.GIOVAO;
                            find.GIORA = dateTimePicker1.Value.TimeOfDay;
                            db.SaveChanges();
                            List<CHITIETBANGCHAMCONG> ls = db.CHITIETBANGCHAMCONGs.Where(s => s.MANV == NhanVienMenu.currNhanVien).ToList();
                            BindData(ls);
                            MessageBox.Show("Chấm công hôm nay hoàn tất");
                        }
                        else
                        {
                            MessageBox.Show("Ngày giờ chấm công hôm nay đã được ghi lại");
                            return;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
