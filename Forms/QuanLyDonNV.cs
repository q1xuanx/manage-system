using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.Forms
{
    public partial class QuanLyDon : Form
    {
        Model1 db = new Model1();
        public QuanLyDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QUANLYDON find = db.QUANLYDONs.FirstOrDefault(s => tb_Ma.Text == s.MANV);
            int status = 0;
            if (cb_TinhTrang.Text == "Duyệt") status = 1;
            else if (cb_TinhTrang.Text == "Không Duyệt") status = 2;
            QUANLYDON qld = new QUANLYDON()
            {
                MADON = find.MADON,
                MANV = tb_Ma.Text,
                NgayLap = find.NgayLap,
                NOIDUNG = rtb_nd.Text,
                TRANGTHAI = status
            };
            db.QUANLYDONs.AddOrUpdate(qld);
            db.SaveChanges();
            var findd = db.QUANLYDONs.Where(s => s.TRANGTHAI == null).ToList();
            BindData(findd);
            MessageBox.Show("Duyệt Đơn Thành Công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tb_Ma.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            dtp.Text = DateTime.Parse(dataGridView1.Rows[idx].Cells[2].Value.ToString()).ToString();
            rtb_nd.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            cb_TinhTrang.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
        }
        private void BindData(List<QUANLYDON> list)
        {
            dataGridView1.Rows.Clear();
            foreach (QUANLYDON item in list)
            {
                int idx = dataGridView1.Rows.Add();
                dataGridView1.Rows[idx].Cells[0].Value = item.MADON;
                dataGridView1.Rows[idx].Cells[1].Value = item.MANV;
                dataGridView1.Rows[idx].Cells[2].Value = item.NgayLap;
                dataGridView1.Rows[idx].Cells[3].Value = item.NOIDUNG;
                int ?status = item.TRANGTHAI;
                if (status == null)
                {
                    dataGridView1.Rows[idx].Cells[4].Value = "Chưa Duyệt";
                }else if (status == 1)
                {
                    dataGridView1.Rows[idx].Cells[4].Value = "Duyệt";
                }else
                {
                    dataGridView1.Rows[idx].Cells[4].Value = "Không Duyệt";
                }
            }
        }

        private void QuanLyDon_Load(object sender, EventArgs e)
        {
            string[] tinhTrang = {"Chưa Duyệt", "Duyệt", "Không Duyệt"};
            foreach(string s in tinhTrang)
            {
                cb_TinhTrang.Items.Add(s);
            }
            var find = db.QUANLYDONs.Where(s => s.TRANGTHAI == null).ToList();
            BindData(find);
        }
    }
}
