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
        public LoginForm()
        {
            InitializeComponent();
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
            // Path to your CSV file
            string csvFileName = "UserProfile.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

            if (!File.Exists(csvFilePath))
            {
                MessageBox.Show("User credentials file does not exist.");
            }

            // Prompt for username and password
            string username = txtUsername.Text;
            string password = txtPassword.Text;

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
                    if (fields.Length >= 2 && fields[3] == username && fields[5] == password)
                    {
                        if (fields[7] == "admin")
                        {
                            var newform = new AdminMain();
                            newform.Show();
                        }
                        else
                        {
                            var newform = new RegMain();
                            newform.Show();
                        }
                    }
                }
            }

            // If no match is found
            Console.WriteLine("Incorrect username or password.");

            this.Hide();
        }
    }
}
