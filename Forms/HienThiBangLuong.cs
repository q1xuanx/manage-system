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

    public partial class HienThiBangLuong : Form
    {
        Model1 db = new Model1();
        public HienThiBangLuong()
        {
            InitializeComponent();
        }

        private void btn_Dieuchinh_Click(object sender, EventArgs e)
        {
            try
            {
                var find = db.BANGLUONGs.FirstOrDefault(s => s.MABANGLUONG == tb_BL.Text);
                if (find != null)
                {
                    find.MABANGLUONG = tb_BL.Text;
                    find.HESOPHUCAP = float.Parse(tb_PC.Text);
                    find.HESOLUONG = float.Parse(tb_HSL.Text);
                    find.LUONGCOBAN = float.Parse(tb_LCB.Text);
                    List<BANGLUONG> bl = db.BANGLUONGs.ToList();
                    DataBinding(bl);
                }
                else
                {
                    MessageBox.Show("Not found !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataBinding(List<BANGLUONG> bl)
        {
            dataGridView1.Rows.Clear();
            foreach (BANGLUONG b in bl)
            {
                int idx = dataGridView1.Rows.Add();
                dataGridView1.Rows[idx].Cells[0].Value = b.MABANGLUONG;
                dataGridView1.Rows[idx].Cells[1].Value = b.HESOPHUCAP;
                dataGridView1.Rows[idx].Cells[2].Value = b.HESOLUONG;
                dataGridView1.Rows[idx].Cells[3].Value = b.LUONGCOBAN;
            }
        }

        private void HienThiBangLuong_Load(object sender, EventArgs e)
        {
            List<BANGLUONG> bl = db.BANGLUONGs.ToList();
            DataBinding(bl);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idx = e.RowIndex;
                tb_BL.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
                tb_PC.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
                tb_HSL.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
                tb_LCB.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            }else
            {
                MessageBox.Show("Vui long chon dong co du lieu !");
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            tb_BL.Text = null;
            tb_PC.Text = null;
            tb_HSL.Text = null;
            tb_LCB.Text = null;
        }
    }
}