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
    public partial class BaoCaoTTNhanVien : Form
    {
        Model1 db = new Model1();
        public BaoCaoTTNhanVien()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<NHANVIEN> ls = db.NHANVIENs.Where(s => s.MAPHONGBAN == cmbPhongBan.SelectedValue.ToString()).ToList();
                nHANVIENBindingSource.DataSource = ls;
                this.rpvTTSV.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void BaoCaoTTNhanVien_Load(object sender, EventArgs e)
        {
            List<PHONGBAN> pb = db.PHONGBANs.ToList();
            cmbPhongBan.DataSource = pb;
            cmbPhongBan.DisplayMember = "TENPHONGBAN";
            cmbPhongBan.ValueMember = "MAPHONGBAN";
            List<NHANVIEN> ls = db.NHANVIENs.Where(s => s.MAPHONGBAN == cmbPhongBan.SelectedValue.ToString()).ToList();
            nHANVIENBindingSource.DataSource = ls;
            this.rpvTTSV.RefreshReport();
        }
    }
}
