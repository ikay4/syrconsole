using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static syrconsole.main;

namespace syrconsole
{
    public partial class background : Form
    {
        public background(int monitorIndex)
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[monitorIndex].WorkingArea.Location;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.BackgroundImage = Image.FromFile(Globals.backgroundImagePath);
        }
    }
}
