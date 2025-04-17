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
using WindowsDisplayAPI;
using System.Management;
using Windows.Devices;
using Windows.Devices.Display;
using System.Windows.Forms.VisualStyles;
using Windows.Devices.Display.Core;

namespace syrconsole
{
    public partial class main : Form
    {
        int max = 0;
        public static class Globals //to do: change globals name
        {
            // General
            public static String errorMessage { get; set; }
            public static String startggApiKey { get; set; }

            // Pre-Event Settings
            public static String preEventVideoPath { get; set; }
            public static String backgroundImagePath { get; set; }
        }

        public main()
        {

            // Console Init
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("SYR Tournament Console (Version 1.0)");
            Console.WriteLine("Created by Kye Keller (ikay3at)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Opening Start Up Splash Screen...");

            // Splash Screen
            var splashScreen = new startUpSplashScreen();
            splashScreen.ShowDialog();

            // Window Init
            Console.WriteLine();
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;


            // (Start) Event Setup
            Dictionary<int, String> monitorDir = new Dictionary<int, String>();


            ManagementObjectSearcher searcher_PnPEntity =
                        new ManagementObjectSearcher("root\\CIMV2",
                        "SELECT * FROM Win32_PnPEntity");

            List<String> monitorDeviceIDs = new List<String>();
            List<String> monitorCaptons = new List<String>();
            foreach (ManagementObject queryObj in searcher_PnPEntity.Get())
            {

                if ((String)queryObj["PNPClass"] == "Monitor")
                {
                    Console.WriteLine("Monitor Found: {0}, {1}, {2}", queryObj["Caption"], queryObj["PNPClass"], queryObj["DeviceID"]);
                    monitorDeviceIDs.Add((String)queryObj["DeviceID"]);
                    monitorCaptons.Add((String)queryObj["Caption"]);
                }
            }

            List<String> monitorInstances = new List<String>();
            ManagementObjectSearcher searcher_WmiMonitor =
                    new ManagementObjectSearcher("root\\WMI",
                    "SELECT * FROM WmiMonitorID WHERE Active = True");

            foreach (ManagementObject queryObj in searcher_WmiMonitor.Get())
            {
                Console.WriteLine("Monitor Instance Found: {0}", queryObj["InstanceName"]);
                var instance = (String)queryObj["InstanceName"];
                instance = instance.ToUpper();
                instance = instance.Substring(0, instance.Length - 2);
                monitorInstances.Add(instance);
            }

            foreach (var scr in Screen.AllScreens)
            {
                Console.WriteLine($"Screen Found: {scr}");
            }

            Console.WriteLine($"Monitors Found: {monitorDeviceIDs.Count}");
            Console.WriteLine($"Screens Found: {Screen.AllScreens.Length}");
            if (Screen.AllScreens.Length != monitorDeviceIDs.Count) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("ERROR!!! >> Number of monitors found doesn't equal number of screens found. Try rebooting your device."); }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WARNING! >> You might need to restart your computer if monitors are connected/disconnected while computer is on. Please set up monitors correctly prior to using.");
            Console.WriteLine("WARNING! >> (This will *possibly* be fixed in the near future.)");
            Console.WriteLine("WARNING! >> You can still change primary monitor, but you will need to relaunch the app for changes to be in effect.");

            for (int i = 0; i < monitorInstances.Count; i++)
            {
                for (int j = 0; j < monitorDeviceIDs.Count; j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Attemping to match monitor '{monitorInstances[i]}' to monitor deviceID '{monitorDeviceIDs[j]}'");
                    if (monitorInstances[i].Equals(monitorDeviceIDs[j]))
                    {
                        monitorDir.Add(i, monitorCaptons[j]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Match found!");
                    }
                }
            }

            foreach (KeyValuePair<int, String> monitor in monitorDir)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Attemping to add {monitor.Key}, {monitor.Value}");
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    var scr = Screen.AllScreens[monitor.Key];
                    sngPkMonitorCB.Items.Add(scr.Primary ? $"{monitorDir[monitor.Key]} [Primary]" : monitorDir[monitor.Key]);
                    sbMonitorCB.Items.Add(scr.Primary ? $"{monitorDir[monitor.Key]} [Primary]" : monitorDir[monitor.Key]);
                    Console.WriteLine("Added monitor '{0}' with key {1}", monitor.Value, monitor.Key);
                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e);
                    Console.WriteLine("ERROR!!! >> Couldn't add monitor '{0}' with key {1}. It's possible the screen for the monitor couldn't be detected. Try restarting this program or rebooting your device.", monitor.Value, monitor.Key);
                }
            }
            try
            {
                sngPkMonitorCB.DropDownStyle = ComboBoxStyle.DropDownList;
                sbMonitorCB.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR!!! >> Couldn't find any monitors to add to list. Do you have an external Monitor connected?");
            }

            // (End)

            // (Start) Check-In
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private Boolean preEventCheckList()
        {
            if (sngPkMonitorCB.SelectedIndex == 0)
            {
                Globals.errorMessage = "Check-In/Song Pick Monitor not selected.";
                return false;
            }
            if (Globals.preEventVideoPath == null)
            {
                Globals.errorMessage = "Video File was not selected.";
                return false;
            }
            if (Globals.backgroundImagePath == null)
            {
                Globals.errorMessage = "Background Image File was not selected.";
                return false;
            }
            return true;
        }

        private void appTestButton_Click(object sender, EventArgs e)
        {
            var action = MessageBox.Show("Open Test? It will open on top of every application.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (action == DialogResult.Yes)
            {
                if (preEventCheckList())
                {
                    var sngPkBackgroundImage = new background(sngPkMonitorCB.SelectedIndex - 1);
                    sngPkBackgroundImage.StartPosition = FormStartPosition.Manual;
                    sngPkBackgroundImage.Show();

                    var sngPkForm = new preEventVideo(sngPkMonitorCB.SelectedIndex - 1);
                    sngPkForm.StartPosition = FormStartPosition.Manual;
                    sngPkForm.Show();

                    if (sbMonitorCB.SelectedIndex != 0)
                    {
                        var sbBackgroundImage = new background(sbMonitorCB.SelectedIndex - 1);
                        sbBackgroundImage.StartPosition = FormStartPosition.Manual;
                        sbBackgroundImage.Show();

                        var sbForm = new preEventVideo(sbMonitorCB.SelectedIndex - 1);
                        sbForm.StartPosition = FormStartPosition.Manual;
                        sbForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show(Globals.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panelSwitchTestButton_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
        }

        private void sngPkMonitorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Check-In/Song Pick Monitor Changed to: {0}", sngPkMonitorCB.Text);
            var control = new Control();
            Graphics g = control.CreateGraphics();
            SizeF size = g.MeasureString(sngPkMonitorCB.Text, new Font("Noto Sans JP", 10.0F));
            var newSize = (int)size.Width + 20;
            Console.WriteLine("Monitor Dropdown Width -> Max: {0}, Current: {1}, Changed to: {2}", max, sngPkMonitorCB.Width, (int)size.Width + 20);
            if (newSize > max)
            {
                sngPkMonitorCB.Width = max = newSize;
            } 
            else 
            {
                sngPkMonitorCB.Width = max; 
            }
        }

        private void sbMonitorCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Scoreboard Monitor Changed to: {0}", sbMonitorCB.Text);
            var control = new Control();
            Graphics g = control.CreateGraphics();
            SizeF size = g.MeasureString(sbMonitorCB.Text, new Font("Noto Sans JP", 10.0F));
            var newSize = (int)size.Width + 20;
            Console.WriteLine("Monitor Dropdown Width -> Max: {0}, Current: {1}, Changed to: {2}", max, sbMonitorCB.Width, (int)size.Width + 20);
            if (newSize > max)
            {
                sbMonitorCB.Width = max = newSize;
            }
            else
            {
                sbMonitorCB.Width = max;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appTestButton_Click(sender, e);
        }

        private void preEventVideoFileBrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult fileChoosen = this.openPreEventVideoDialog.ShowDialog();
            if (fileChoosen == DialogResult.OK)
            {
                this.preEventVideoFileLbl.Text = openPreEventVideoDialog.SafeFileName;
                var fileName = openPreEventVideoDialog.FileName;
                Globals.preEventVideoPath = fileName.Replace(@"\", @"\\");
                Console.WriteLine($"File '{Globals.preEventVideoPath}' chosen for background video (Pre-Event)");
            }
        }

        private void backgroundImageFileBrowse_Click(object sender, EventArgs e)
        {
            DialogResult fileChoosen = this.openBackgroundImageDialog.ShowDialog();
            if (fileChoosen == DialogResult.OK)
            {
                this.backgroundImageFileLbl.Text = openBackgroundImageDialog.SafeFileName;
                var fileName = openBackgroundImageDialog.FileName;
                Globals.backgroundImagePath = fileName.Replace(@"\", @"\\");
                Console.WriteLine($"File '{Globals.backgroundImagePath}' chosen for background image");
            }
        }
    }
}
