namespace Dormify
{
    partial class AdminLiabilities
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
            this.label2 = new System.Windows.Forms.Label();
            this.asignee = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.viewSpecified = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dueDate = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.specificLiab = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.removeLiab = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Assignee";
            // 
            // asignee
            // 
            this.asignee.Cursor = System.Windows.Forms.Cursors.Default;
            this.asignee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asignee.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignee.FormattingEnabled = true;
            this.asignee.Items.AddRange(new object[] {
            "general",
            "adrian",
            "kim",
            "gian"});
            this.asignee.Location = new System.Drawing.Point(18, 76);
            this.asignee.Name = "asignee";
            this.asignee.Size = new System.Drawing.Size(208, 30);
            this.asignee.TabIndex = 20;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Poppins", 9F);
            this.name.Location = new System.Drawing.Point(22, 135);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(204, 18);
            this.name.TabIndex = 21;
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(103, 308);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(99, 44);
            this.submit.TabIndex = 29;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(7, 60);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(66, 28);
            this.btn2.TabIndex = 32;
            this.btn2.Text = "Remove";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.remove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(422, 174);
            this.dataGridView1.TabIndex = 33;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 98);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(422, 107);
            this.dataGridView2.TabIndex = 36;
            // 
            // viewSpecified
            // 
            this.viewSpecified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.viewSpecified.FlatAppearance.BorderSize = 0;
            this.viewSpecified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSpecified.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSpecified.ForeColor = System.Drawing.Color.White;
            this.viewSpecified.Location = new System.Drawing.Point(8, 59);
            this.viewSpecified.Name = "viewSpecified";
            this.viewSpecified.Size = new System.Drawing.Size(47, 28);
            this.viewSpecified.TabIndex = 37;
            this.viewSpecified.Text = "View";
            this.viewSpecified.UseVisualStyleBackColor = false;
            this.viewSpecified.Click += new System.EventHandler(this.viewSpecified_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.panel11.Controls.Add(this.dueDate);
            this.panel11.Controls.Add(this.panel10);
            this.panel11.Controls.Add(this.price);
            this.panel11.Controls.Add(this.panel9);
            this.panel11.Controls.Add(this.description);
            this.panel11.Controls.Add(this.panel8);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Controls.Add(this.name);
            this.panel11.Controls.Add(this.submit);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.asignee);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.panel7);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Location = new System.Drawing.Point(11, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(290, 352);
            this.panel11.TabIndex = 38;
            // 
            // dueDate
            // 
            this.dueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dueDate.Font = new System.Drawing.Font("Poppins", 9F);
            this.dueDate.Location = new System.Drawing.Point(21, 279);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(204, 18);
            this.dueDate.TabIndex = 35;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(18, 276);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(207, 24);
            this.panel10.TabIndex = 36;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Font = new System.Drawing.Font("Poppins", 9F);
            this.price.Location = new System.Drawing.Point(22, 233);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(204, 18);
            this.price.TabIndex = 33;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(19, 230);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(207, 24);
            this.panel9.TabIndex = 34;
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Font = new System.Drawing.Font("Poppins", 9F);
            this.description.Location = new System.Drawing.Point(22, 184);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(204, 18);
            this.description.TabIndex = 31;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(19, 181);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(207, 24);
            this.panel8.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(14, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Due Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Liability Price";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 47);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(290, 2);
            this.panel12.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Liability Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.label8.Size = new System.Drawing.Size(163, 47);
            this.label8.TabIndex = 0;
            this.label8.Text = "Add Liability";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(19, 132);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(207, 24);
            this.panel7.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Liability Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(316, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 236);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 2);
            this.panel2.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.label13.Size = new System.Drawing.Size(163, 47);
            this.label13.TabIndex = 0;
            this.label13.Text = "All Liabilities";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.specificLiab);
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.viewSpecified);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(316, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 212);
            this.panel3.TabIndex = 40;
            // 
            // specificLiab
            // 
            this.specificLiab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specificLiab.Font = new System.Drawing.Font("Poppins", 9F);
            this.specificLiab.ForeColor = System.Drawing.Color.Gray;
            this.specificLiab.Location = new System.Drawing.Point(64, 64);
            this.specificLiab.Name = "specificLiab";
            this.specificLiab.Size = new System.Drawing.Size(204, 18);
            this.specificLiab.TabIndex = 37;
            this.specificLiab.Text = "Enter Username";
            this.specificLiab.Click += new System.EventHandler(this.specificLiab_Click);
            this.specificLiab.TextChanged += new System.EventHandler(this.specificLiab_TextChanged);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(61, 61);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(207, 24);
            this.panel13.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 2);
            this.panel4.TabIndex = 25;
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
            this.label1.Size = new System.Drawing.Size(266, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Specific Liability";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.panel5.Controls.Add(this.removeLiab);
            this.panel5.Controls.Add(this.panel14);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btn2);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(11, 367);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 98);
            this.panel5.TabIndex = 39;
            // 
            // removeLiab
            // 
            this.removeLiab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.removeLiab.Font = new System.Drawing.Font("Poppins", 9F);
            this.removeLiab.ForeColor = System.Drawing.Color.Gray;
            this.removeLiab.Location = new System.Drawing.Point(81, 65);
            this.removeLiab.Name = "removeLiab";
            this.removeLiab.Size = new System.Drawing.Size(186, 18);
            this.removeLiab.TabIndex = 37;
            this.removeLiab.Text = "Enter Unique ID";
            this.removeLiab.Click += new System.EventHandler(this.removeLiab_Click);
            this.removeLiab.TextChanged += new System.EventHandler(this.removeLiab_TextChanged);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(78, 62);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(189, 24);
            this.panel14.TabIndex = 38;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 2);
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
            this.label14.Size = new System.Drawing.Size(210, 47);
            this.label14.TabIndex = 0;
            this.label14.Text = "Remove Liability";
            // 
            // AdminLiabilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLiabilities";
            this.Text = "AdminLiabilities";
            this.Load += new System.EventHandler(this.AdminLiabilities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox asignee;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button viewSpecified;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox dueDate;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox specificLiab;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox removeLiab;
        private System.Windows.Forms.Panel panel14;
    }
}