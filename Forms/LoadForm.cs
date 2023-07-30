using ManageSystem.Models;
using Microsoft.Reporting.Map.WebForms.BingMaps;
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
    public partial class LoadForm : Form
    {
    
        public LoadForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            label4.Location = new System.Drawing.Point(label4.Location.X + 3, label4.Location.Y);
            if (panel2.Width >= 845)
            {
                this.Close();
            }
        }
    }
}
