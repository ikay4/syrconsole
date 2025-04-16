namespace syrconsole
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.mainTabController = new System.Windows.Forms.TabControl();
            this.eventSetupPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.preEventVideoFileBrowseBtn = new System.Windows.Forms.Button();
            this.preEventVideoFileLbl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.displaySettingsCtrlBox = new System.Windows.Forms.GroupBox();
            this.sbMonitorCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sngPkMonitorCB = new System.Windows.Forms.ComboBox();
            this.startProcessBtn = new System.Windows.Forms.Button();
            this.checkInPage = new System.Windows.Forms.TabPage();
            this.songPickPage = new System.Windows.Forms.TabPage();
            this.scoreboardPage = new System.Windows.Forms.TabPage();
            this.creditsPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appTestPage = new System.Windows.Forms.TabPage();
            this.panelSwitchTestButton = new System.Windows.Forms.Button();
            this.appTestButton = new System.Windows.Forms.Button();
            this.syrconsoleTitleImg = new System.Windows.Forms.PictureBox();
            this.openPreEventVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundImageFileLbl = new System.Windows.Forms.TextBox();
            this.backgroundImageFileBrowse = new System.Windows.Forms.Button();
            this.openBackgroundImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabController.SuspendLayout();
            this.eventSetupPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.displaySettingsCtrlBox.SuspendLayout();
            this.creditsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.appTestPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syrconsoleTitleImg)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabController
            // 
            this.mainTabController.Controls.Add(this.eventSetupPage);
            this.mainTabController.Controls.Add(this.checkInPage);
            this.mainTabController.Controls.Add(this.songPickPage);
            this.mainTabController.Controls.Add(this.scoreboardPage);
            this.mainTabController.Controls.Add(this.creditsPage);
            this.mainTabController.Controls.Add(this.appTestPage);
            this.mainTabController.Location = new System.Drawing.Point(18, 74);
            this.mainTabController.Name = "mainTabController";
            this.mainTabController.SelectedIndex = 0;
            this.mainTabController.Size = new System.Drawing.Size(1874, 955);
            this.mainTabController.TabIndex = 5;
            // 
            // eventSetupPage
            // 
            this.eventSetupPage.Controls.Add(this.groupBox1);
            this.eventSetupPage.Controls.Add(this.displaySettingsCtrlBox);
            this.eventSetupPage.Controls.Add(this.startProcessBtn);
            this.eventSetupPage.Location = new System.Drawing.Point(4, 22);
            this.eventSetupPage.Name = "eventSetupPage";
            this.eventSetupPage.Padding = new System.Windows.Forms.Padding(3);
            this.eventSetupPage.Size = new System.Drawing.Size(1866, 929);
            this.eventSetupPage.TabIndex = 0;
            this.eventSetupPage.Text = "Event Setup";
            this.eventSetupPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.backgroundImageFileBrowse);
            this.groupBox1.Controls.Add(this.backgroundImageFileLbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.preEventVideoFileBrowseBtn);
            this.groupBox1.Controls.Add(this.preEventVideoFileLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1854, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-Event Settings";
            // 
            // preEventVideoFileBrowseBtn
            // 
            this.preEventVideoFileBrowseBtn.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preEventVideoFileBrowseBtn.Location = new System.Drawing.Point(359, 19);
            this.preEventVideoFileBrowseBtn.Name = "preEventVideoFileBrowseBtn";
            this.preEventVideoFileBrowseBtn.Size = new System.Drawing.Size(76, 26);
            this.preEventVideoFileBrowseBtn.TabIndex = 4;
            this.preEventVideoFileBrowseBtn.Text = "Browse...";
            this.preEventVideoFileBrowseBtn.UseVisualStyleBackColor = true;
            this.preEventVideoFileBrowseBtn.Click += new System.EventHandler(this.preEventVideoFileBrowseBtn_Click);
            // 
            // preEventVideoFileLbl
            // 
            this.preEventVideoFileLbl.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preEventVideoFileLbl.Location = new System.Drawing.Point(147, 19);
            this.preEventVideoFileLbl.Name = "preEventVideoFileLbl";
            this.preEventVideoFileLbl.ReadOnly = true;
            this.preEventVideoFileLbl.Size = new System.Drawing.Size(206, 26);
            this.preEventVideoFileLbl.TabIndex = 3;
            this.preEventVideoFileLbl.Text = "[Video File]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pre-Event Video File:\r\n";
            // 
            // displaySettingsCtrlBox
            // 
            this.displaySettingsCtrlBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.displaySettingsCtrlBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.displaySettingsCtrlBox.Controls.Add(this.sbMonitorCB);
            this.displaySettingsCtrlBox.Controls.Add(this.label5);
            this.displaySettingsCtrlBox.Controls.Add(this.label3);
            this.displaySettingsCtrlBox.Controls.Add(this.sngPkMonitorCB);
            this.displaySettingsCtrlBox.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySettingsCtrlBox.Location = new System.Drawing.Point(6, 6);
            this.displaySettingsCtrlBox.Name = "displaySettingsCtrlBox";
            this.displaySettingsCtrlBox.Size = new System.Drawing.Size(1854, 93);
            this.displaySettingsCtrlBox.TabIndex = 3;
            this.displaySettingsCtrlBox.TabStop = false;
            this.displaySettingsCtrlBox.Text = "Display Settings";
            // 
            // sbMonitorCB
            // 
            this.sbMonitorCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.sbMonitorCB.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbMonitorCB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sbMonitorCB.FormattingEnabled = true;
            this.sbMonitorCB.Items.AddRange(new object[] {
            "[Select Monitor]"});
            this.sbMonitorCB.Location = new System.Drawing.Point(213, 52);
            this.sbMonitorCB.Name = "sbMonitorCB";
            this.sbMonitorCB.Size = new System.Drawing.Size(156, 27);
            this.sbMonitorCB.TabIndex = 3;
            this.sbMonitorCB.Text = "[Select Monitor]";
            this.sbMonitorCB.SelectedIndexChanged += new System.EventHandler(this.sbMonitorCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Scoreboard Monitor (Optional):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Check-In/Song Pick Monitor:\r\n";
            // 
            // sngPkMonitorCB
            // 
            this.sngPkMonitorCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.sngPkMonitorCB.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sngPkMonitorCB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sngPkMonitorCB.FormattingEnabled = true;
            this.sngPkMonitorCB.Items.AddRange(new object[] {
            "[Select Monitor]"});
            this.sngPkMonitorCB.Location = new System.Drawing.Point(197, 19);
            this.sngPkMonitorCB.Name = "sngPkMonitorCB";
            this.sngPkMonitorCB.Size = new System.Drawing.Size(156, 27);
            this.sngPkMonitorCB.TabIndex = 0;
            this.sngPkMonitorCB.Text = "[Select Monitor]";
            this.sngPkMonitorCB.SelectedIndexChanged += new System.EventHandler(this.sngPkMonitorCB_SelectedIndexChanged);
            // 
            // startProcessBtn
            // 
            this.startProcessBtn.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startProcessBtn.Location = new System.Drawing.Point(1727, 859);
            this.startProcessBtn.Name = "startProcessBtn";
            this.startProcessBtn.Size = new System.Drawing.Size(133, 64);
            this.startProcessBtn.TabIndex = 2;
            this.startProcessBtn.Text = "Start Process";
            this.startProcessBtn.UseVisualStyleBackColor = true;
            this.startProcessBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkInPage
            // 
            this.checkInPage.Location = new System.Drawing.Point(4, 22);
            this.checkInPage.Name = "checkInPage";
            this.checkInPage.Padding = new System.Windows.Forms.Padding(3);
            this.checkInPage.Size = new System.Drawing.Size(1866, 929);
            this.checkInPage.TabIndex = 1;
            this.checkInPage.Text = "Check-In";
            this.checkInPage.UseVisualStyleBackColor = true;
            // 
            // songPickPage
            // 
            this.songPickPage.Location = new System.Drawing.Point(4, 22);
            this.songPickPage.Name = "songPickPage";
            this.songPickPage.Padding = new System.Windows.Forms.Padding(3);
            this.songPickPage.Size = new System.Drawing.Size(1866, 929);
            this.songPickPage.TabIndex = 2;
            this.songPickPage.Text = "Song Pick";
            this.songPickPage.UseVisualStyleBackColor = true;
            // 
            // scoreboardPage
            // 
            this.scoreboardPage.Location = new System.Drawing.Point(4, 22);
            this.scoreboardPage.Name = "scoreboardPage";
            this.scoreboardPage.Padding = new System.Windows.Forms.Padding(3);
            this.scoreboardPage.Size = new System.Drawing.Size(1866, 929);
            this.scoreboardPage.TabIndex = 3;
            this.scoreboardPage.Text = "Scoreboard (Optional)";
            this.scoreboardPage.UseVisualStyleBackColor = true;
            // 
            // creditsPage
            // 
            this.creditsPage.Controls.Add(this.pictureBox1);
            this.creditsPage.Controls.Add(this.label2);
            this.creditsPage.Controls.Add(this.label1);
            this.creditsPage.Location = new System.Drawing.Point(4, 22);
            this.creditsPage.Name = "creditsPage";
            this.creditsPage.Padding = new System.Windows.Forms.Padding(3);
            this.creditsPage.Size = new System.Drawing.Size(1866, 929);
            this.creditsPage.TabIndex = 4;
            this.creditsPage.Text = "Credits";
            this.creditsPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::syrconsole.Properties.Resources.creditsimage;
            this.pictureBox1.Location = new System.Drawing.Point(1160, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 700);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(661, 504);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tt-Kp Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(753, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "SYR Tournament Console (Window Forms)";
            // 
            // appTestPage
            // 
            this.appTestPage.Controls.Add(this.panelSwitchTestButton);
            this.appTestPage.Controls.Add(this.appTestButton);
            this.appTestPage.Location = new System.Drawing.Point(4, 22);
            this.appTestPage.Name = "appTestPage";
            this.appTestPage.Padding = new System.Windows.Forms.Padding(3);
            this.appTestPage.Size = new System.Drawing.Size(1866, 929);
            this.appTestPage.TabIndex = 5;
            this.appTestPage.Text = "App Tests";
            this.appTestPage.UseVisualStyleBackColor = true;
            // 
            // panelSwitchTestButton
            // 
            this.panelSwitchTestButton.Location = new System.Drawing.Point(6, 46);
            this.panelSwitchTestButton.Name = "panelSwitchTestButton";
            this.panelSwitchTestButton.Size = new System.Drawing.Size(253, 34);
            this.panelSwitchTestButton.TabIndex = 1;
            this.panelSwitchTestButton.Text = "Panel Switch Test";
            this.panelSwitchTestButton.UseVisualStyleBackColor = true;
            this.panelSwitchTestButton.Click += new System.EventHandler(this.panelSwitchTestButton_Click);
            // 
            // appTestButton
            // 
            this.appTestButton.Location = new System.Drawing.Point(6, 6);
            this.appTestButton.Name = "appTestButton";
            this.appTestButton.Size = new System.Drawing.Size(253, 34);
            this.appTestButton.TabIndex = 0;
            this.appTestButton.Text = "Borderless Video Screen Test\r\n";
            this.appTestButton.UseVisualStyleBackColor = true;
            this.appTestButton.Click += new System.EventHandler(this.appTestButton_Click);
            // 
            // syrconsoleTitleImg
            // 
            this.syrconsoleTitleImg.Image = global::syrconsole.Properties.Resources.mainbanner3;
            this.syrconsoleTitleImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("syrconsoleTitleImg.InitialImage")));
            this.syrconsoleTitleImg.Location = new System.Drawing.Point(22, 12);
            this.syrconsoleTitleImg.Name = "syrconsoleTitleImg";
            this.syrconsoleTitleImg.Size = new System.Drawing.Size(1866, 50);
            this.syrconsoleTitleImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.syrconsoleTitleImg.TabIndex = 6;
            this.syrconsoleTitleImg.TabStop = false;
            // 
            // openPreEventVideoDialog
            // 
            this.openPreEventVideoDialog.FileName = "openPreEventVideoDialog";
            this.openPreEventVideoDialog.Filter = "Video Files|*.mp4;*.avi;*.mov|.webm Files|*.webm|All files|*.*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Background Image File:";
            // 
            // backgroundImageFileLbl
            // 
            this.backgroundImageFileLbl.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundImageFileLbl.Location = new System.Drawing.Point(164, 51);
            this.backgroundImageFileLbl.Name = "backgroundImageFileLbl";
            this.backgroundImageFileLbl.ReadOnly = true;
            this.backgroundImageFileLbl.Size = new System.Drawing.Size(206, 26);
            this.backgroundImageFileLbl.TabIndex = 6;
            this.backgroundImageFileLbl.Text = "[Image File]";
            // 
            // backgroundImageFileBrowse
            // 
            this.backgroundImageFileBrowse.Font = new System.Drawing.Font("Noto Sans JP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundImageFileBrowse.Location = new System.Drawing.Point(376, 51);
            this.backgroundImageFileBrowse.Name = "backgroundImageFileBrowse";
            this.backgroundImageFileBrowse.Size = new System.Drawing.Size(76, 26);
            this.backgroundImageFileBrowse.TabIndex = 7;
            this.backgroundImageFileBrowse.Text = "Browse...";
            this.backgroundImageFileBrowse.UseVisualStyleBackColor = true;
            this.backgroundImageFileBrowse.Click += new System.EventHandler(this.backgroundImageFileBrowse_Click);
            // 
            // openBackgroundImageDialog
            // 
            this.openBackgroundImageDialog.FileName = "openFileDialog1";
            this.openBackgroundImageDialog.Filter = "Image Files|*.png;*.jpeg|All files|*.*";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.syrconsoleTitleImg);
            this.Controls.Add(this.mainTabController);
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "SYR Tournament Console [Main]";
            this.Load += new System.EventHandler(this.main_Load);
            this.mainTabController.ResumeLayout(false);
            this.eventSetupPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.displaySettingsCtrlBox.ResumeLayout(false);
            this.displaySettingsCtrlBox.PerformLayout();
            this.creditsPage.ResumeLayout(false);
            this.creditsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.appTestPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.syrconsoleTitleImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl mainTabController;
        private System.Windows.Forms.TabPage eventSetupPage;
        private System.Windows.Forms.TabPage checkInPage;
        private System.Windows.Forms.PictureBox syrconsoleTitleImg;
        private System.Windows.Forms.TabPage songPickPage;
        private System.Windows.Forms.TabPage scoreboardPage;
        private System.Windows.Forms.TabPage creditsPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage appTestPage;
        private System.Windows.Forms.Button appTestButton;
        private System.Windows.Forms.Button panelSwitchTestButton;
        private System.Windows.Forms.ComboBox sngPkMonitorCB;
        private System.Windows.Forms.Button startProcessBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox displaySettingsCtrlBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openPreEventVideoDialog;
        private System.Windows.Forms.TextBox preEventVideoFileLbl;
        private System.Windows.Forms.Button preEventVideoFileBrowseBtn;
        private System.Windows.Forms.ComboBox sbMonitorCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backgroundImageFileBrowse;
        private System.Windows.Forms.TextBox backgroundImageFileLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openBackgroundImageDialog;
    }
}

