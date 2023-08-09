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

    

        private void BindData(List<QUANLYDON> qls)
        {
            dgvDSDaNop.Rows.Clear();
            foreach(QUANLYDON qld in qls)
            {
                int idx = dgvDSDaNop.Rows.Add();
                dgvDSDaNop.Rows[idx].Cells[0].Value = qld.MANV;
                dgvDSDaNop.Rows[idx].Cells[1].Value = qld.NgayLap;
                dgvDSDaNop.Rows[idx].Cells[2].Value = qld.NOIDUNG;
                string show = "Chưa Duyệt";
                if (qld.TRANGTHAI == 1)
                {
                    show = "Duyệt";
                }else if (qld.TRANGTHAI == 2)
                {
                    show = "Không Duyệt";
                }
                dgvDSDaNop.Rows[idx].Cells[3].Value = show;
            }
        }

        private void LamDon_Load(object sender, EventArgs e)
        {
            tb_manv.Text = NhanVienMenu.currNhanVien; //currNhanVien: nhân viên hiện tại
            var qld = db.QUANLYDONs.Where(s => s.MANV ==  tb_manv.Text).ToList(); //var: tự động nhận kiểu dữ liệu
            BindData(qld);
        }
        bool check(string richTextBox)
        {
            Queue<string> q = new Queue<string>(); //Queue: hàng đợi
            string temp = "";
            int idx = 0;
            for (int i = 0; i < richTextBox.Length; i++)
            {
                char s1 = richTextBox[i]; //richTextBox: đoạn văn bản
                if (s1 == ' ')
                {
                    for (int j = i + 1; j < richTextBox.Length; j++)
                    {
                        char s2 = richTextBox[j];
                        if (s1 == s2)
                        {
                            idx++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (idx != 0)
                {
                    //MessageBox.Show("IDX: " + idx.ToString());
                    richTextBox = richTextBox.Remove(i, idx);
                    idx = 0;
                }
            }
            //MessageBox.Show(richTextBox);
            for (int i = 0; i < richTextBox.Length; i++)
            {
                char s = richTextBox[i];
                if (q.Count == 0)
                {
                    if (s != ' ')// ' ': khoảng trắng
                    {
                        temp += s;
                    }
                    else
                    {
                        q.Enqueue(temp); //Enqueue: thêm vào hàng đợi
                        temp = "";
                    }
                }
                else
                {
                    if (s != ' ')
                    {
                        temp += s;
                    }
                    else
                    {
                        if (q.Peek() != temp) //Peek: lấy phần tử đầu tiên
                        {
                            q.Dequeue(); //Dequeue: xóa phần tử đầu tiên
                            q.Enqueue(temp);
                            temp = "";
                        }
                        else
                        {
                            if (q.Count == 2)
                            {
                                return false;
                            }
                            else
                            {
                                q.Enqueue(temp);
                                temp = "";
                            }
                        }
                    }
                }

            }
            if (q.Peek() == temp && q.Count >= 2)
            {
                return false;
            }
            return true;
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(check(rtb_nd.Text))) //!: phủ định
                {
                    MessageBox.Show("Bạn đang cố ý spam !");
                    rtb_nd.Text = null;
                    return;
                }
                QUANLYDON qld = new QUANLYDON()
                {
                    MADON = Utils.generateUUID(), //generateUUID: tạo mã đơn
                    MANV = NhanVienMenu.currNhanVien,
                    NgayLap =dtpNgayNop.Value.Date,
                    NOIDUNG = rtb_nd.Text,
                };
                db.QUANLYDONs.Add(qld);
                db.SaveChanges();
                MessageBox.Show("Nộp Đơn Thành Công");
                var qldon = db.QUANLYDONs.Where(s => s.MANV == tb_manv.Text).ToList();
                BindData(qldon);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_manv.Text = dgvDSDaNop.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpNgayNop.Text = DateTime.Parse(dgvDSDaNop.Rows[e.RowIndex].Cells[1].Value.ToString()).ToString();
            rtb_nd.Text = dgvDSDaNop.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            tb_manv.Text = null;
            rtb_nd.Text = null;
        }
    }
}
