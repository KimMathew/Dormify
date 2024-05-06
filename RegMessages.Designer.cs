namespace Dormify
{
    partial class RegMessages
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
            this.lblMessages = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.btnMessageSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessages.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.ForeColor = System.Drawing.Color.White;
            this.lblMessages.Location = new System.Drawing.Point(0, 0);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblMessages.Size = new System.Drawing.Size(170, 58);
            this.lblMessages.TabIndex = 5;
            this.lblMessages.Text = "Messages";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Dormify.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(337, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 33);
            this.btnExit.TabIndex = 25;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.White;
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextBox.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.ForeColor = System.Drawing.Color.Gray;
            this.messageTextBox.Location = new System.Drawing.Point(13, 61);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(352, 205);
            this.messageTextBox.TabIndex = 26;
            this.messageTextBox.Text = "Enter your message here...";
            //this.messageTextBox.Click += new System.EventHandler(this.messageTextBox_Click);
            //this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // btnMessageSubmit
            // 
            this.btnMessageSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.btnMessageSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessageSubmit.FlatAppearance.BorderSize = 0;
            this.btnMessageSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageSubmit.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageSubmit.ForeColor = System.Drawing.Color.White;
            this.btnMessageSubmit.Location = new System.Drawing.Point(127, 279);
            this.btnMessageSubmit.Name = "btnMessageSubmit";
            this.btnMessageSubmit.Size = new System.Drawing.Size(122, 40);
            this.btnMessageSubmit.TabIndex = 29;
            this.btnMessageSubmit.Text = "Submit";
            this.btnMessageSubmit.UseVisualStyleBackColor = false;
            this.btnMessageSubmit.Click += new System.EventHandler(this.btnMessageSubmit_Click);
            // 
            // RegMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(379, 332);
            this.Controls.Add(this.btnMessageSubmit);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegMessages";
            this.Load += new System.EventHandler(this.RegMessages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button btnMessageSubmit;
    }
}