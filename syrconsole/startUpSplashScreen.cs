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
using static syrconsole.api;

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

        private async Task<Boolean> splashScreenCheckList()
        {
            if (!await api.verifyKey())
            {
                Globals.errorMessage = "Invalid API Key";
                return false;
            }
            return true;
        }
        private async void launchAppBtn_Click(object sender, EventArgs e)
        {
            apiGlobals.apiKey = startApiKey.Text;
            if (await splashScreenCheckList())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("API Key verified.");
                Console.ForegroundColor = ConsoleColor.White;
                this.Close();
            }
            else
            {
                MessageBox.Show(Globals.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("An error occured while trying to verify the API key. Restarting app...");
                Application.Restart();
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
