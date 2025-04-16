using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace syrconsole
{
    public partial class checkIn : Form
    {
        public checkIn()
        {
            InitializeComponent();
            Debug.WriteLine("check in created");

            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
