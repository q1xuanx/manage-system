
using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace ManageSystem.Forms
{
    public partial class FormCreateEmployee : Form
    {
        public string filepath = "";
        Model1 model = new Model1();

        public FormCreateEmployee()
        {
            InitializeComponent();

        }
        private void FormCreateEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                string[] tinhTrang = { "Đang Làm", "Thử Việc", "Đã Nghỉ" };
                foreach (string s in tinhTrang)
                {
                    cb_TinhTrang.Items.Add(s);
                }
                cb_TinhTrang.Text = tinhTrang[0];
                List<NHANVIEN> nhanvien = model.NHANVIENs.ToList();
                List<PHONGBAN> phongban = model.PHONGBANs.ToList();
                List<CHUCVU> chucvu = model.CHUCVUs.ToList();
                List<BANGLUONG> bl = model.BANGLUONGs.ToList();
                cbPhongBan(phongban);
                cbChucVu(chucvu);
                cbBangLuong(bl);
                BindGrid(nhanvien);
                ptcAvatar.Image = null;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            metroToolTip1.SetToolTip(btn_Them, "Thêm");
            metroToolTip1.SetToolTip(btn_Capnhat, "Cập Nhật");
            metroToolTip1.SetToolTip(btn_Xoa, "Xóa");
            metroToolTip1.SetToolTip(btn_addhinh, "Thêm Hình");

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

        private void cbBangLuong(List<BANGLUONG> bANGLUONGs)
        {
            this.cb_bangluong.DataSource = bANGLUONGs;
            this.cb_bangluong.DisplayMember = "MABANGLUONG";
            this.cb_bangluong.ValueMember = "MABANGLUONG";
        }
        private void BindGrid(List<NHANVIEN> list)
        {
            dgvTTNV.Rows.Clear();
            bool gioiTinh = rbt_Nam.Checked == true ? true : false;
            foreach (var item in list)
            {
                int index = dgvTTNV.Rows.Add();
                dgvTTNV.Rows[index].Cells[0].Value = item.MANV;
                dgvTTNV.Rows[index].Cells[1].Value = item.TENNV;
                dgvTTNV.Rows[index].Cells[2].Value = (item.GIOITINH == 1 ? "Nam" : "Nu");
                dgvTTNV.Rows[index].Cells[3].Value = item.DIACHI;
                dgvTTNV.Rows[index].Cells[4].Value = item.TINHTRANG;
                dgvTTNV.Rows[index].Cells[5].Value = item.NGAYSINH;
                dgvTTNV.Rows[index].Cells[6].Value = item.PHONGBAN.TENPHONGBAN;
                dgvTTNV.Rows[index].Cells[7].Value = item.CHUCVU.TENCHUCVU;
                if (string.IsNullOrEmpty(item.Avatar))
                {
                    ptcAvatar.Image = null;
                }else
                {
                    string fileName = item.Avatar;
                    string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string fullpath = Path.Combine(path, "Resources", fileName);
                    ptcAvatar.Image = Image.FromFile(fullpath);
                    ptcAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptcAvatar.Refresh();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txt_ID.Text = dgvTTNV.Rows[index].Cells[0].Value.ToString();
                txt_Name.Text = dgvTTNV.Rows[index].Cells[1].Value.ToString();
                if ((string)(dgvTTNV.Rows[index].Cells[2].Value) == "Nam")
                {
                    rbt_Nam.Checked = true;
                }
                else
                {
                    rbt_Nu.Checked = true;
                }
                txt_Anddress.Text = dgvTTNV.Rows[index].Cells[3].Value.ToString();
                cb_TinhTrang.Text = dgvTTNV.Rows[index].Cells[4].Value.ToString();
                cbb_BirthDay.Text = dgvTTNV.Rows[index].Cells[5].Value.ToString();
                cb_PhongBan.Text = dgvTTNV.Rows[index].Cells[6].Value.ToString();
                cb_ChucVu.Text = dgvTTNV.Rows[index].Cells[7].Value.ToString();
                NHANVIEN check = model.NHANVIENs.FirstOrDefault(s => s.Avatar != null && s.MANV == txt_ID.Text);
                if (check == null) 
                {
                    ptcAvatar.Image = null;
                }else
                {
                    var find = model.NHANVIENs.FirstOrDefault(s => s.Avatar != null && s.MANV == txt_ID.Text);
                    string fileName = find.Avatar;
                    string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string fullpath = Path.Combine(path,"Resources",fileName);
                    ptcAvatar.Image = Image.FromFile(fullpath);
                    ptcAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptcAvatar.Show();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void txt_findName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchName = txt_findName.Text.ToLower();
                dgvTTNV.ClearSelection();
                foreach (DataGridViewRow row in dgvTTNV.Rows)
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



        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ID.Text) || string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_Anddress.Text) || (rbt_Nam.Checked == false && rbt_Nu.Checked == false))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                foreach (char t in txt_Name.Text)
                {
                    if (t == '0' || t == '1' || t == '2' || t == '3' || t == '4' || t == '5' || t == '6' || t == '7' || t == '8' || t == '9')
                    {
                        throw new Exception("Không nhập số vào tên !");
                    }
                }
                var nv = model.NHANVIENs.FirstOrDefault(s => (string)(s.MANV) == txt_ID.Text);
                if (nv == null)
                {
                    bool gioiTinh = rbt_Nam.Checked == true ? true : false;
                    if (!string.IsNullOrEmpty(filepath))
                    {
                       
                        ImageFormat format = Image.FromFile(filepath).RawFormat;
                        string savePath = txt_ID.Text;
                        string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                        string fullpath = Path.Combine(path,"Resources",savePath);
                        ptcAvatar.Image.Save(fullpath,format);
                        filepath = savePath;
                    }
                    else filepath = null;
                    nv = new NHANVIEN()
                    {
                        MANV = txt_ID.Text,
                        TENNV = txt_Name.Text,
                        DIACHI = txt_Anddress.Text,
                        GIOITINH = gioiTinh == true ? 1 : 0,
                        NGAYSINH = DateTime.Parse(cbb_BirthDay.Text),
                        MACHUCVU = cb_ChucVu.SelectedValue.ToString(),
                        MAPHONGBAN = cb_PhongBan.SelectedValue.ToString(),
                        MABANGLUONG = cb_bangluong.SelectedValue.ToString(),
                        TINHTRANG = cb_TinhTrang.Text,
                        Avatar = filepath
                    };
                    model.NHANVIENs.Add(nv);
                    MessageBox.Show("Thêm mới nhân viên thành công!");
                }
                else
                {
                    if (filepath != "")
                    {
                        ImageFormat format = Image.FromFile(filepath).RawFormat;
                        string savePath = txt_ID.Text;
                        string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                        string fullpath = Path.Combine(path, "Resources", savePath);
                        ptcAvatar.Image.Save(fullpath, format);
                        filepath = savePath;
                    }
                    else filepath = null;
                    nv.MANV = txt_ID.Text;
                    nv.TENNV = txt_Name.Text;
                    nv.DIACHI = txt_Anddress.Text;
                    nv.GIOITINH = (rbt_Nam.Checked == true ? 1 : 0);
                    nv.NGAYSINH = DateTime.Parse(cbb_BirthDay.Text);
                    nv.MACHUCVU = cb_ChucVu.SelectedValue.ToString();
                    nv.MAPHONGBAN = cb_PhongBan.SelectedValue.ToString();
                    nv.MABANGLUONG = cb_bangluong.SelectedValue.ToString();
                    nv.TINHTRANG = cb_TinhTrang.Text;
                    if (!string.IsNullOrEmpty(filepath))
                    {
                        nv.Avatar = filepath;
                    }else
                    {
                        nv.Avatar = nv.Avatar;
                    }
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                }
                model.SaveChanges();
                List<NHANVIEN> nhanvien = model.NHANVIENs.ToList();
                BindGrid(nhanvien);
                txt_ID.Text = null;
                txt_Name.Text = null;
                txt_Anddress.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string check = cb_TinhTrang.Text;
                if (check == "Đang Làm")
                {
                    throw new Exception("Không thẻ xóa nhân viên đang làm việc");
                }
                else
                {
                    var find = model.NHANVIENs.FirstOrDefault(s => (string)(s.MANV) == txt_ID.Text || string.IsNullOrEmpty(txt_ID.Text));
                    if (find != null)
                    {
                        var ask = MessageBox.Show("Bạn có muốn xóa nhân viên này ?", "DELETE ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            model.NHANVIENs.Remove(find);
                            MessageBox.Show("Xóa nhân viên thành công !");
                        }
                    }else
                    {
                        MessageBox.Show("Không có nhân viên cần xóa !");
                    }
                    model.SaveChanges();
                    List<NHANVIEN> nhanvien = model.NHANVIENs.ToList();
                    BindGrid(nhanvien);
                    txt_ID.Text = null;
                    txt_Anddress.Text = null;
                    txt_Name.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_addhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = ("Chọn Avatar(*jpg;*png;*jpeg)|*jpg;*png;*jpeg");
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptcAvatar.Image = Image.FromFile(open.FileName);
                ptcAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                ptcAvatar.Show();
                filepath = open.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaoCaoTTNhanVien bc = new BaoCaoTTNhanVien();
            bc.Show();
        }
    }
}
