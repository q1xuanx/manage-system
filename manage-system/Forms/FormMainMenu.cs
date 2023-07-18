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
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
        
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            GioiThieu gt = new GioiThieu()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCreateEmployee create = new FormCreateEmployee()
            {
                Dock = DockStyle.Fill,TopMost = true, TopLevel = false
            };
            create.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(create);
            create.BringToFront();
            create.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PhongBan create = new PhongBan()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false
            };
            create.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(create);
            create.BringToFront();
            create.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GioiThieu gt = new GioiThieu()
            {
                Dock = DockStyle.Fill,
                TopMost = true,
                TopLevel = false,
            };
            gt.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Add(gt);
            gt.BringToFront();
            gt.Show();
        }
    }
}
