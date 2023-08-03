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
    public partial class ChamCong : Form
    {
        Model1 db = new Model1();
        public ChamCong()
        {
            InitializeComponent();
        }
        private void bindata(List<CHITIETBANGCHAMCONG> ls)
        {
            dgvDSCC.Rows.Clear();
            foreach(CHITIETBANGCHAMCONG ch in ls) {
                int idx = dgvDSCC.Rows.Add();
                dgvDSCC.Rows[idx].Cells[0].Value = ch.MANV.ToString();
                dgvDSCC.Rows[idx].Cells[1].Value = dtpNgayChamCong.Value.Date;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var find = db.CHITIETBANGCHAMCONGs.Where(s => s.NGAYCHAMCONG == dtpNgayChamCong.Value.Date).ToList();
            bindata(find);
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var find = db.CHITIETBANGCHAMCONGs.Where(s => s.NGAYCHAMCONG == dtpNgayChamCong.Value.Date).ToList();
            bindata(find);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            ReportChamCong rp = new ReportChamCong();
            rp.Show();
        }
    }
}
