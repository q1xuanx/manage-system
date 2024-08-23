using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.Forms
{
    public partial class FormCreateEmployee : Form
    {

        Model1 model = new Model1();
        public FormCreateEmployee()
        {
            InitializeComponent();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            var check = model.NHANVIENs.Where(s => s.MANV == txt_ID.Text || s.DIACHI == txt_Anddress.Text || s.TENNV == txt_Name.Text);
            if (check != null)
            {
                MessageBox.Show("Co thong tin bi trung vui long nhap lai");
                return;
            }
            var nv = model.NHANVIENs.FirstOrDefault(s => (string)(s.MANV) == txt_ID.Text);
            string cv = "NV";
            if (cb_ChucVu.Text == "Quản Lý") cv = "QL";
            string pb = "CN";
            if (cb_PhongBan.Text == "Kinh Doanh") pb = "KD";
            else if (cb_PhongBan.Text == "Kế Toán") pb = "KT";
            if (nv == null)
            {
                bool gioiTinh = rbt_Nam.Checked == true ? true : false;
                nv = new NHANVIEN()
                {
                    MANV = txt_ID.Text,
                    TENNV = txt_Name.Text,
                    DIACHI = txt_Anddress.Text,
                    GIOITINH = gioiTinh,
                    NGAYSINH = DateTime.Parse(cbb_BirthDay.Text),
                    MACHUCVU = cv,
                    MAPHONGBAN = cb_PhongBan.Text,
                    TINHTRANG = cb_TinhTrang.Text
                };
                model.NHANVIENs.Add(nv);
                MessageBox.Show("Them Nhan Vien Moi Thanh Cong !");
            }else
            {
                nv.MANV = txt_ID.Text;
                nv.TENNV = txt_Name.Text;
                nv.DIACHI = txt_Anddress.Text;
                if (rbt_Nam.Checked == true)
                {
                    nv.GIOITINH = true;
                }else
                {
                    nv.GIOITINH = false;
                }
                nv.NGAYSINH = DateTime.Parse(cbb_BirthDay.Text);
                nv.MACHUCVU= cv;
                nv.MAPHONGBAN = pb;
                nv.TINHTRANG = cb_TinhTrang.Text;
                MessageBox.Show("Cap Nhat Thong Tin Nhan Vien Thanh Cong !");
            }
            model.SaveChanges();
            List<NHANVIEN> nhanvien = model.NHANVIENs.ToList();
            BindGrid(nhanvien);
        }
        private void FormCreateEmployee_Load(object sender, EventArgs e)
        {
            string[] tinhTrang = { "Dang Lam", "Thu Viec", "Da Nghi" };
            foreach(string s in tinhTrang)
            {
                cb_TinhTrang.Items.Add(s);
            }
            cb_TinhTrang.Text = tinhTrang[0];
            List<NHANVIEN> nhanvien = model.NHANVIENs.ToList();
            List<PHONGBAN> phongban = model.PHONGBANs.ToList();
            List<CHUCVU> chucvu = model.CHUCVUs.ToList();
            cbPhongBan(phongban);
            cbChucVu(chucvu);
            BindGrid(nhanvien);
        }
        private void cbPhongBan(List<PHONGBAN> pb)
        {
            this.cb_PhongBan.DataSource = pb;
            this.cb_PhongBan.DisplayMember = "TENPHONGBAN";
            this.cb_PhongBan.ValueMember = "MAPHONGBAN";
        }
        private void cbChucVu(List<CHUCVU> cv)
        {
            this.cb_ChucVu.DataSource = cv;
            this.cb_ChucVu.DisplayMember = "TENCHUCVU";
            this.cb_ChucVu.ValueMember = "MACHUCVU";
        }
        private void BindGrid(List<NHANVIEN> list)
        {
            dataGridView1.Rows.Clear();
            bool gioiTinh = rbt_Nam.Checked == true ? true : false;
            foreach (var item in list)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MANV;
                dataGridView1.Rows[index].Cells[1].Value = item.TENNV;
                dataGridView1.Rows[index].Cells[2].Value = (item.GIOITINH == true ? "Nam" : "Nu");
                dataGridView1.Rows[index].Cells[3].Value = item.DIACHI;
                dataGridView1.Rows[index].Cells[4].Value = item.TINHTRANG;
                dataGridView1.Rows[index].Cells[5].Value = item.NGAYSINH;
                dataGridView1.Rows[index].Cells[6].Value = item.PHONGBAN.TENPHONGBAN;
                dataGridView1.Rows[index].Cells[7].Value = item.CHUCVU.TENCHUCVU;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txt_ID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txt_Name.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                if ((string)(dataGridView1.Rows[index].Cells[2].Value) == "Nam")
                {
                    rbt_Nam.Checked = true;
                }
                else
                {
                    rbt_Nu.Checked = true;
                }
                txt_Anddress.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                cb_TinhTrang.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                cbb_BirthDay.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                cb_PhongBan.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
                cb_ChucVu.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_dell_Click(object sender, EventArgs e)
        {
            try
            {
                string check = cb_TinhTrang.Text;
                if (check == "Dang Lam")
                {
                    MessageBox.Show("Khong the xoa nhan vien dang lam");
                }
                else
                {
                    var ask = MessageBox.Show("Ban co muon xoa nhan vien nay ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        var find = model.NHANVIENs.FirstOrDefault(s => (string)(s.MANV) == txt_ID.Text);
                        if (find != null)
                        {
                            model.NHANVIENs.Remove(find);
                        }
                    }
                    model.SaveChanges();
                    List<NHANVIEN> nhanvien = model.NHANVIENs.ToList();
                    BindGrid(nhanvien);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message); 
            }
        }

        private void txt_findName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchName = txt_findName.Text.ToLower();
                dataGridView1.ClearSelection();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["clm_TenNV"].Value != null && row.Cells["clm_TenNV"].Value.ToString().ToLower().Contains(searchName))
                    {
                        row.Visible = true;
                    }
                    else row.Visible = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
