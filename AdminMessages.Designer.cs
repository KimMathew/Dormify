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
            this.searchedDGV = new System.Windows.Forms.DataGridView();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchMessageTextBox = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnSearchMessage = new System.Windows.Forms.Button();
            this.btnSubmitStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.messageDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchedDGV)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageDGV
            // 
            this.messageDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.messageDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.messageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageDGV.Location = new System.Drawing.Point(12, 62);
            this.messageDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageDGV.Name = "messageDGV";
            this.messageDGV.RowHeadersWidth = 51;
            this.messageDGV.RowTemplate.Height = 24;
            this.messageDGV.Size = new System.Drawing.Size(339, 205);
            this.messageDGV.TabIndex = 1;
            // 
            // searchedDGV
            // 
            this.searchedDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.searchedDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchedDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.searchedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchedDGV.Location = new System.Drawing.Point(10, 102);
            this.searchedDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchedDGV.Name = "searchedDGV";
            this.searchedDGV.RowHeadersWidth = 51;
            this.searchedDGV.RowTemplate.Height = 24;
            this.searchedDGV.Size = new System.Drawing.Size(341, 113);
            this.searchedDGV.TabIndex = 2;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Finished"});
            this.statusComboBox.Location = new System.Drawing.Point(86, 235);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(119, 30);
            this.statusComboBox.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.messageDGV);
            this.panel5.Location = new System.Drawing.Point(12, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(363, 280);
            this.panel5.TabIndex = 41;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(363, 2);
            this.panel6.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(89, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.label14.Size = new System.Drawing.Size(172, 47);
            this.label14.TabIndex = 0;
            this.label14.Text = "All Messages";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.btnSubmitStatus);
            this.panel1.Controls.Add(this.searchMessageTextBox);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.statusComboBox);
            this.panel1.Controls.Add(this.btnSearchMessage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchedDGV);
            this.panel1.Location = new System.Drawing.Point(390, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 280);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 2);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.label1.Size = new System.Drawing.Size(232, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolve Messages";
            // 
            // searchMessageTextBox
            // 
            this.searchMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchMessageTextBox.Font = new System.Drawing.Font("Poppins", 9F);
            this.searchMessageTextBox.ForeColor = System.Drawing.Color.Gray;
            this.searchMessageTextBox.Location = new System.Drawing.Point(86, 65);
            this.searchMessageTextBox.Name = "searchMessageTextBox";
            this.searchMessageTextBox.Size = new System.Drawing.Size(186, 18);
            this.searchMessageTextBox.TabIndex = 40;
            this.searchMessageTextBox.Text = "Enter Unique ID";
            this.searchMessageTextBox.Click += new System.EventHandler(this.searchMessageTextBox_Click);
            this.searchMessageTextBox.TextChanged += new System.EventHandler(this.searchMessageTextBox_TextChanged);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(83, 62);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(189, 24);
            this.panel14.TabIndex = 41;
            // 
            // btnSearchMessage
            // 
            this.btnSearchMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.btnSearchMessage.FlatAppearance.BorderSize = 0;
            this.btnSearchMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMessage.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMessage.ForeColor = System.Drawing.Color.White;
            this.btnSearchMessage.Location = new System.Drawing.Point(12, 60);
            this.btnSearchMessage.Name = "btnSearchMessage";
            this.btnSearchMessage.Size = new System.Drawing.Size(66, 28);
            this.btnSearchMessage.TabIndex = 39;
            this.btnSearchMessage.Text = "Search";
            this.btnSearchMessage.UseVisualStyleBackColor = false;
            this.btnSearchMessage.Click += new System.EventHandler(this.btnSearchMessage_Click);
            // 
            // btnSubmitStatus
            // 
            this.btnSubmitStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.btnSubmitStatus.FlatAppearance.BorderSize = 0;
            this.btnSubmitStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitStatus.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitStatus.ForeColor = System.Drawing.Color.White;
            this.btnSubmitStatus.Location = new System.Drawing.Point(12, 236);
            this.btnSubmitStatus.Name = "btnSubmitStatus";
            this.btnSubmitStatus.Size = new System.Drawing.Size(66, 28);
            this.btnSubmitStatus.TabIndex = 42;
            this.btnSubmitStatus.Text = "Submit";
            this.btnSubmitStatus.UseVisualStyleBackColor = false;
            this.btnSubmitStatus.Click += new System.EventHandler(this.btnSubmitStatus_Click);
            // 
            // AdminMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMessages";
            this.Text = "AdminMessages";
            this.Load += new System.EventHandler(this.AdminMessages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchedDGV)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView messageDGV;
        private System.Windows.Forms.DataGridView searchedDGV;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchMessageTextBox;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnSearchMessage;
        private System.Windows.Forms.Button btnSubmitStatus;
    }
}