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
    public partial class startUpSplashScreen : Form
    {
        public startUpSplashScreen()
        {


            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private Boolean splashScreenCheckList()
        {
            if (startApiKey.TextLength != 32)
            {
                Globals.errorMessage = "start.gg API Key is not valid.";
                return false;
            }    
            return true;
        }
        private void launchAppBtn_Click(object sender, EventArgs e)
        {
            if (splashScreenCheckList())
            {
                Globals.startggApiKey = startApiKey.Text;
                Console.WriteLine(Globals.startggApiKey);
                this.Close();
            }
            else
            {
                MessageBox.Show(Globals.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            var action = MessageBox.Show("Close out of the app?", "Close App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (action == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
