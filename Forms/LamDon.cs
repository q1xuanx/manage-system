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
    public partial class LamDon : Form
    {
        Model1 db = new Model1();
        public LamDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void BindData(List<QUANLYDON> qls)
        {
            dataGridView1.Rows.Clear();
            foreach(QUANLYDON qld in qls)
            {
                int idx = dataGridView1.Rows.Add();
                dataGridView1.Rows[idx].Cells[0].Value = qld.MANV;
                dataGridView1.Rows[idx].Cells[1].Value = qld.NgayLap;
                dataGridView1.Rows[idx].Cells[2].Value = qld.NOIDUNG;
                string show = "Chưa Duyệt";
                if (qld.TRANGTHAI == 1)
                {
                    show = "Duyệt";
                }else if (qld.TRANGTHAI == 2)
                {
                    show = "Không Duyệt";
                }
                dataGridView1.Rows[idx].Cells[3].Value = show;
            }
        }

        private void LamDon_Load(object sender, EventArgs e)
        {
            tb_manv.Text = NhanVienMenu.currNhanVien;
            var qld = db.QUANLYDONs.Where(s => s.MANV ==  tb_manv.Text).ToList();
            BindData(qld);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            QUANLYDON qld = new QUANLYDON()
            {
                MADON = Utils.generateUUID(),
                MANV = NhanVienMenu.currNhanVien,
                NgayLap = dateTimePicker1.Value.Date,
                NOIDUNG = rtb_nd.Text,
            };
            db.QUANLYDONs.Add(qld);
            db.SaveChanges();
            MessageBox.Show("Nộp Đơn Thành Công");
            var qldon = db.QUANLYDONs.Where(s => s.MANV == tb_manv.Text).ToList();
            BindData(qldon);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_manv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePicker1.Text = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).ToString();
            rtb_nd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            tb_manv.Text = null;
            rtb_nd.Text = null;
        }
    }
}
