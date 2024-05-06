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
            this.btnSearchMessage = new System.Windows.Forms.Button();
            this.searchMessageTextBox = new System.Windows.Forms.TextBox();
            this.btnSubmitStatus = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.messageDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchedDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // messageDGV
            // 
            this.messageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageDGV.Location = new System.Drawing.Point(12, 28);
            this.messageDGV.Name = "messageDGV";
            this.messageDGV.RowHeadersWidth = 51;
            this.messageDGV.RowTemplate.Height = 24;
            this.messageDGV.Size = new System.Drawing.Size(529, 217);
            this.messageDGV.TabIndex = 1;
            // 
            // searchedDGV
            // 
            this.searchedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchedDGV.Location = new System.Drawing.Point(12, 334);
            this.searchedDGV.Name = "searchedDGV";
            this.searchedDGV.RowHeadersWidth = 51;
            this.searchedDGV.RowTemplate.Height = 24;
            this.searchedDGV.Size = new System.Drawing.Size(529, 150);
            this.searchedDGV.TabIndex = 2;
            // 
            // btnSearchMessage
            // 
            this.btnSearchMessage.Location = new System.Drawing.Point(12, 281);
            this.btnSearchMessage.Name = "btnSearchMessage";
            this.btnSearchMessage.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMessage.TabIndex = 3;
            this.btnSearchMessage.Text = "Search";
            this.btnSearchMessage.UseVisualStyleBackColor = true;
            this.btnSearchMessage.Click += new System.EventHandler(this.btnSearchMessage_Click);
            // 
            // searchMessageTextBox
            // 
            this.searchMessageTextBox.Location = new System.Drawing.Point(93, 282);
            this.searchMessageTextBox.Name = "searchMessageTextBox";
            this.searchMessageTextBox.Size = new System.Drawing.Size(233, 22);
            this.searchMessageTextBox.TabIndex = 4;
            // 
            // btnSubmitStatus
            // 
            this.btnSubmitStatus.Location = new System.Drawing.Point(570, 364);
            this.btnSubmitStatus.Name = "btnSubmitStatus";
            this.btnSubmitStatus.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitStatus.TabIndex = 5;
            this.btnSubmitStatus.Text = "Submit";
            this.btnSubmitStatus.UseVisualStyleBackColor = true;
            this.btnSubmitStatus.Click += new System.EventHandler(this.btnSubmitStatus_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Finished"});
            this.statusComboBox.Location = new System.Drawing.Point(547, 334);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 24);
            this.statusComboBox.TabIndex = 6;
            // 
            // AdminMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1020, 587);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.btnSubmitStatus);
            this.Controls.Add(this.searchMessageTextBox);
            this.Controls.Add(this.btnSearchMessage);
            this.Controls.Add(this.searchedDGV);
            this.Controls.Add(this.messageDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMessages";
            this.Text = "AdminMessages";
            this.Load += new System.EventHandler(this.AdminMessages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchedDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView messageDGV;
        private System.Windows.Forms.DataGridView searchedDGV;
        private System.Windows.Forms.Button btnSearchMessage;
        private System.Windows.Forms.TextBox searchMessageTextBox;
        private System.Windows.Forms.Button btnSubmitStatus;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}