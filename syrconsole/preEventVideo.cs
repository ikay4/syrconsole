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
    public partial class preEventVideo : Form
    {
        public preEventVideo(int monitorIndex)
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[monitorIndex].WorkingArea.Location;
            axWindowsMediaPlayer1.URL = Globals.preEventVideoPath;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
    }
}
