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
    public partial class ReportChamCong : Form
    {
        Model1 db = new Model1();
        public ReportChamCong()
        {
            InitializeComponent();
        }

        private void ReportChamCong_Load(object sender, EventArgs e)
        {
            var ls = db.CHITIETBANGCHAMCONGs.Where(s => s.NGAYCHAMCONG == dtpNgayBC.Value.Date).ToList();
            cHITIETBANGCHAMCONGBindingSource.DataSource = ls;
            this.rptCTCC.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ls = db.CHITIETBANGCHAMCONGs.Where(s => s.NGAYCHAMCONG == dtpNgayBC.Value.Date).ToList();
            cHITIETBANGCHAMCONGBindingSource.DataSource = ls;
            this.rptCTCC.RefreshReport();
        }
    }
}
