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
    public partial class FormTrinhDoHocVan : Form
    {
        DBContext db = new DBContext();
        public FormTrinhDoHocVan()
        {
            
            InitializeComponent();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TenTrinhDo.Text == "" && txt_ChuyenNganh.Text == "")
                {
                    MessageBox.Show("Không được để trống .Vui lòng nhập lại!");
                }
                else
                {
                    TRINHDOHOCVAN tdhv = new TRINHDOHOCVAN()
                    {
                        MATRINHDO = Utils.generateUUID(),
                        TENTRINHDO = txt_TenTrinhDo.Text,
                        CHUYENNGANH = txt_ChuyenNganh.Text,

                    };
                    db.TRINHDOHOCVANs.Add(tdhv);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thông tin Hoàn Tất");

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
