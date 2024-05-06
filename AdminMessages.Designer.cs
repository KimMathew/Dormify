namespace Dormify
{
    partial class AdminMessages
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
            this.messageDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.messageDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // messageDGV
            // 
            this.messageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageDGV.Location = new System.Drawing.Point(12, 28);
            this.messageDGV.Name = "messageDGV";
            this.messageDGV.RowHeadersWidth = 51;
            this.messageDGV.RowTemplate.Height = 24;
            this.messageDGV.Size = new System.Drawing.Size(996, 402);
            this.messageDGV.TabIndex = 1;
            // 
            // AdminMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1020, 587);
            this.Controls.Add(this.messageDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMessages";
            this.Text = "AdminMessages";
            this.Load += new System.EventHandler(this.AdminMessages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView messageDGV;
    }
}