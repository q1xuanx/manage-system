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
    public partial class DanhSachChucVu : Form
    {
        Model1 db = new Model1();
        public DanhSachChucVu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_macv.Text) || string.IsNullOrEmpty(tb_tencv.Text))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                var find = db.CHUCVUs.FirstOrDefault(s => s.MACHUCVU == tb_macv.Text);
                CHUCVU cv = new CHUCVU()
                {
                    MACHUCVU = tb_macv.Text,
                    TENCHUCVU = tb_tencv.Text,
                };
                db.CHUCVUs.AddOrUpdate(cv);
                db.SaveChanges();
                if (find == null)
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else MessageBox.Show("Cập nhật thành công !");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DanhSachChucVu_Load(object sender, EventArgs e)
        {
            List<CHUCVU> ls = db.CHUCVUs.ToList();
            BindData(ls);
        }
        private void BindData(List<CHUCVU> ch)
        {
            dataGridView1.Rows.Clear(); 
            foreach(CHUCVU cv in ch)
            {
                int id = dataGridView1.Rows.Add();
                dataGridView1.Rows[id].Cells[0].Value = cv.MACHUCVU;
                dataGridView1.Rows[id].Cells[1].Value = cv.TENCHUCVU;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string findID = textBox3.Text.ToLower();
            dataGridView1.ClearSelection();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower().Contains(findID))
                {
                    row.Visible = true;
                }else
                {
                    row.Visible = false;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_macv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_tencv.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
