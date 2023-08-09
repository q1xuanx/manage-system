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
            QUANLYDON find = db.QUANLYDONs.FirstOrDefault(s => tb_Ma.Text == s.MANV);   //FirstOrDefault: trả về phần tử đầu tiên của một tập hợp hoặc một giá trị mặc định nếu tập hợp không có phần tử nào.
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
            db.QUANLYDONs.AddOrUpdate(qld); //AddOrUpdate: Thêm hoặc cập nhật một thực thể vào cơ sở dữ liệu.
            db.SaveChanges();
            var findd = db.QUANLYDONs.Where(s => s.TRANGTHAI == null).ToList(); //ToList: Tạo một danh sách mới từ một đối tượng IEnumerable.
            BindData(findd); //BindData: Gắn dữ liệu vào DataGridView.
            MessageBox.Show("Duyệt Đơn Thành Công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex; //rowIndex: chỉ mục của hàng hiện tại.
            tb_Ma.Text = dgvDSDT.Rows[idx].Cells[1].Value.ToString();
            dtpNgayLap.Text = DateTime.Parse(dgvDSDT.Rows[idx].Cells[2].Value.ToString()).ToString();
            rtb_nd.Text = dgvDSDT.Rows[idx].Cells[3].Value.ToString();
            cb_TinhTrang.Text = dgvDSDT.Rows[idx].Cells[4].Value.ToString();
        }
        private void BindData(List<QUANLYDON> list)
        {
            dgvDSDT.Rows.Clear(); //Rows.Clear: Xóa tất cả các hàng khỏi DataGridView.
            foreach (QUANLYDON item in list)
            {
                int idx = dgvDSDT.Rows.Add();
                dgvDSDT.Rows[idx].Cells[0].Value = item.MADON;
                dgvDSDT.Rows[idx].Cells[1].Value = item.MANV;
                dgvDSDT.Rows[idx].Cells[2].Value = item.NgayLap;
                dgvDSDT.Rows[idx].Cells[3].Value = item.NOIDUNG;
                int ?status = item.TRANGTHAI; //?: Toán tử điều kiện có thể là null.
                if (status == null)
                {
                    dgvDSDT.Rows[idx].Cells[4].Value = "Chưa Duyệt";
                }else if (status == 1)
                {
                    dgvDSDT.Rows[idx].Cells[4].Value = "Duyệt";
                }else
                {
                    dgvDSDT.Rows[idx].Cells[4].Value = "Không Duyệt";
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

        private void button2_Click(object sender, EventArgs e)
        {
            tb_Ma.Text = null;
            rtb_nd.Text = null;
            cb_TinhTrang.SelectedIndex = 0;
            dtpNgayLap.Text = DateTime.Now.ToString();
        }
    }
}
