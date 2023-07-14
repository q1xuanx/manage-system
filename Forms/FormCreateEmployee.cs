using ManageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private string generateUUID()
        {
            Guid myUUId = Guid.NewGuid();
            string convertedUUID = myUUId.ToString();
            return convertedUUID;
        }

        private string generateUsername(string fullName)
        {
            string[] nameParts = fullName.Split(' ');
            string lastName = nameParts[0]; // Họ là phần tử đầu tiên
            string firstName = nameParts[nameParts.Length - 1]; // Tên là phần tử cuối cùng
            string middleName = string.Join(" ", nameParts.Skip(1).Take(nameParts.Length - 2)); // Tên đệm là các phần tử còn lại

            string reversedName = lastName.ToLower() + firstName.ToLower() + middleName.ToLower(); // Ghép các phần tử và chuyển thành chữ thường
            return reversedName;
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        private void btn_Tao_Click(object sender, EventArgs e)
        {
             try {
                NHANVIEN checkNV = db.NHANVIENs.FirstOrDefault(nv => nv.EMAIL.Equals(txt_Email.Text) && nv.SDT.Equals(txt_SDT.Text));
                if (checkNV == null)
                {
                    var id =generateUUID();
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
                        MAPHONGBAN = "1",
                        MATRINHDO ="1",
                    };
                    db.NHANVIENs.Add(nhanvien);

                    db.SaveChanges();
                    ACCOUNT aCCOUNT = new ACCOUNT()
                    {
                        IDACCOUNT = generateUUID(),
                        USERNAME = generateUsername(txt_Name.Text),
                        PASSWORD = HashPassword("123"),
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
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
