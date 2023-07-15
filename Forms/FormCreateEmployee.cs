using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.Forms
{
    public partial class FormCreateEmployee : Form
    {
        DBContext db = new DBContext();
        public FormCreateEmployee()
        {
            InitializeComponent();
        }
        private void comboboxPhong(List<PHONGBAN> phongBan)
        {
            this.cmb_MaPhong.DataSource = phongBan;
            this.cmb_MaPhong.DisplayMember = "TENPHONGBAN";
            this.cmb_MaPhong.ValueMember = "MAPHONGBAN";
        }

        private void comboboxTrinhDoHocVan (List<TRINHDOHOCVAN> trinhDoHocVan)
        {
            this.cmb_TrinhDo.DataSource = trinhDoHocVan;
            this.cmb_TrinhDo.DisplayMember = "TENTRINHDO";
            this.cmb_TrinhDo.ValueMember = "MATRINHDO";
        }

        private void cmb_MaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    string name = cmb_MaPhong.SelectedValue.ToString();
        //    List<PHONGBAN> phongBan = db.PHONGBANs.Where(p => p.MAPHONGBAN.Equals(name)).ToList();
        //    comboboxPhong(phongBan);
        //    cmb_MaPhong.Enabled = true;
        }

        private void FormCreateEmployee_Load(object sender, EventArgs e)
        {
            List<PHONGBAN> listPhongBan = db.PHONGBANs.ToList();
            comboboxPhong(listPhongBan);
            List<TRINHDOHOCVAN> listTrinhDoHocVan = db.TRINHDOHOCVANs.ToList();
            comboboxTrinhDoHocVan(listTrinhDoHocVan);
        }

        private void btn_Tao_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Utils.generateUUID();
                NHANVIEN checkNV = db.NHANVIENs.FirstOrDefault(nv => nv.EMAIL.Equals(txt_Email.Text) && nv.SDT.Equals(txt_SDT.Text));
                if (checkNV == null)
                {

                    NHANVIEN nhanvien = new NHANVIEN()
                    {
                        MANV = id,
                        TENNV = txt_Name.Text,
                        DIACHI = txt_Anddress.Text,
                        GIOITINH = 1,
                        NGAYSINH = DateTime.Now,
                        EMAIL = txt_Email.Text,
                        SDT = txt_SDT.Text,
                        DANTOC = txt_DanToc.Text,
                        MAPHONGBAN = cmb_MaPhong.SelectedValue.ToString(),
                        MATRINHDO = cmb_TrinhDo.SelectedValue.ToString(),
                    };
                    db.NHANVIENs.Add(nhanvien);
                    db.SaveChanges();
                    ACCOUNT aCCOUNT = new ACCOUNT()
                    {
                        IDACCOUNT = Utils.generateUUID(),
                        USERNAME = Utils.GenerateUsername(txt_Name.Text),
                        PASSWORD = Utils.HashPassword("123"),
                        ROLE = 1,
                        TRANGTHAI = 1,
                        MANV = id,

                    };

                    db.ACCOUNTs.Add(aCCOUNT);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Email hoặc SĐT trùng");
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                    }
                }
            }


        }



    }
}
