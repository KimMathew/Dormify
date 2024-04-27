namespace Dormify
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.logo = new System.Windows.Forms.PictureBox();
            this.logolbl = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.logosublbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(5, 30);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(419, 355);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // logolbl
            // 
            this.logolbl.AutoSize = true;
            this.logolbl.BackColor = System.Drawing.Color.Transparent;
            this.logolbl.Font = new System.Drawing.Font("BodoniXT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.logolbl.Location = new System.Drawing.Point(125, 388);
            this.logolbl.Name = "logolbl";
            this.logolbl.Size = new System.Drawing.Size(169, 48);
            this.logolbl.TabIndex = 2;
            this.logolbl.Text = "Dormify";
            this.logolbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.loginPanel.Location = new System.Drawing.Point(430, -1);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(341, 491);
            this.loginPanel.TabIndex = 3;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logosublbl
            // 
            this.logosublbl.AutoSize = true;
            this.logosublbl.BackColor = System.Drawing.Color.Transparent;
            this.logosublbl.Font = new System.Drawing.Font("BodoniXT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logosublbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.logosublbl.Location = new System.Drawing.Point(76, 436);
            this.logosublbl.Name = "logosublbl";
            this.logosublbl.Size = new System.Drawing.Size(269, 19);
            this.logosublbl.TabIndex = 4;
            this.logosublbl.Text = "A Dormitory Management System ";
            this.logosublbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 488);
            this.Controls.Add(this.logosublbl);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.logolbl);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormify";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label logolbl;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label logosublbl;
    }
}

