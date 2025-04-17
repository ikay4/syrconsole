namespace syrconsole
{
    partial class startUpSplashScreen
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
            this.startApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.launchAppBtn = new System.Windows.Forms.Button();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startApiKey
            // 
            this.startApiKey.Location = new System.Drawing.Point(556, 188);
            this.startApiKey.Name = "startApiKey";
            this.startApiKey.PasswordChar = '*';
            this.startApiKey.Size = new System.Drawing.Size(253, 20);
            this.startApiKey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans JP Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(552, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "start.gg API Key:";
            // 
            // launchAppBtn
            // 
            this.launchAppBtn.Font = new System.Drawing.Font("Noto Sans JP", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchAppBtn.Location = new System.Drawing.Point(734, 260);
            this.launchAppBtn.Name = "launchAppBtn";
            this.launchAppBtn.Size = new System.Drawing.Size(75, 23);
            this.launchAppBtn.TabIndex = 2;
            this.launchAppBtn.Text = "Launch App";
            this.launchAppBtn.UseVisualStyleBackColor = true;
            this.launchAppBtn.Click += new System.EventHandler(this.launchAppBtn_Click);
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.Font = new System.Drawing.Font("Noto Sans JP", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppBtn.Location = new System.Drawing.Point(734, 289);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(75, 23);
            this.exitAppBtn.TabIndex = 3;
            this.exitAppBtn.Text = "Exit";
            this.exitAppBtn.UseVisualStyleBackColor = true;
            this.exitAppBtn.Click += new System.EventHandler(this.exitAppBtn_Click);
            // 
            // startUpSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::syrconsole.Properties.Resources.startsplashscreenwindows;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 492);
            this.Controls.Add(this.exitAppBtn);
            this.Controls.Add(this.launchAppBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startApiKey);
            this.Name = "startUpSplashScreen";
            this.Text = "SYR Tournament Console [Start Up]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startApiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button launchAppBtn;
        private System.Windows.Forms.Button exitAppBtn;
    }
}