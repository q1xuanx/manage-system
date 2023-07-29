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
    public partial class TrangChinhNhanVien : Form
    {
        public TrangChinhNhanVien()
        {
            InitializeComponent();
        }

        private void TrangChinhNhanVien_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("T");
        }
    }
}
