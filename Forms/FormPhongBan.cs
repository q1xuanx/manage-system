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
    public partial class FormPhongBan : Form
    {
        DBContext db = new DBContext();
        public FormPhongBan()
        {
            InitializeComponent();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            try {
                if (txt_TenPhongBan.Text != "" && txt_SLNhanVien.Text != "")
                {
                    PHONGBAN phongBan = new PHONGBAN()
                    {
                        MAPHONGBAN = Utils.generateUUID(),
                        TENPHONGBAN = txt_TenPhongBan.Text,
                        SOLUONGNHANVIEN = int.Parse(txt_SLNhanVien.Text),
                        TRANGTHAI = cmb_TrangThai.SelectedIndex,

                    };
                    db.PHONGBANs.Add(phongBan);
                    db.SaveChanges();
                    MessageBox.Show("Thêm phòng ban thành công! ", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
