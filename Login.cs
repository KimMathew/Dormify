using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CsvHelper;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Dormify
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        public string fullName;
        public string password;
        public string roomNumber;

        public LoginForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconpass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            iconpass.Image = Properties.Resources.eye__1_;
        }

        private void iconpass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            iconpass.Image = Properties.Resources.eye;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username or Password is empty.");
                return;
            }

                // Path to your CSV file
                string csvFileName = "UserProfile.csv";
                string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

                if (!File.Exists(csvFilePath))
                {
                    MessageBox.Show("User credentials file does not exist.");
                    return;
                }

                // Prompt for username and password
            

                // Read the CSV file
                using (TextFieldParser parser = new TextFieldParser(csvFilePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // Iterate through each row in the CSV file
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();

                        // Check if the username and password match
                        if (fields.Length >= 2 && fields[3] == txtUsername.Text && fields[5] == txtPassword.Text)
                        {

                            fullName = $"{fields[0]} {fields[1]}";
                            password = fields[5];
                            roomNumber = fields[6];

                            if (fields[7] == "admin")
                            {
                                var newform = new AdminMain();
                                newform.Show();
                            }
                            else
                            {
                                
                                var newform = new RegMain();
                                newform.Show();
                                if (RegMain.instance != null)
                                {
                                    RegMain.instance.userLabel.Text = txtUsername.Text;
                                    RegMain.instance.userRoom.Text = roomNumber;
                                }
                            }
                            //MessageBox.Show($"{fullName} \n {roomNumber}");
                            this.Hide();
                            return;
                        }
                    }
                }
                MessageBox.Show("Incorrect username or password.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
