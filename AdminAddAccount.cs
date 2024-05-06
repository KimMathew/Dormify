using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormify
{
    public partial class AdminAddAccount : Form
    {

        public string firstName;
        public string lastName;
        public string age;
        public string userName;
        public string email;
        public string password;
        public string roomNumber;
        public string accountType;

        public AdminAddAccount()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            firstName = textBox1.Text;
            lastName = textBox2.Text;
            age = textBox3.Text;
            userName = textBox4.Text;
            email = textBox5.Text;
            password = textBox6.Text;
            roomNumber = textBox7.Text;
            accountType = "regular";

            DialogResult result = MessageBox.Show($"First Name: {firstName}\nLast Name: {lastName}\nAge: {age}\nUsername: {userName}\nEmail: {email}\nPassword: {password}\nRoom Number: {roomNumber}",
                "User Credentials",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                string userData = $"{firstName},{lastName},{age},{userName},{email},{password},{roomNumber},{accountType}";

                // Write the user credentials to a CSV file
                string csvFileName = "UserProfile.csv";
                string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);
                try
                {
                    using (StreamWriter writer = new StreamWriter(csvFilePath, true)) // Append to existing file
                    {
                        writer.WriteLine();
                        writer.WriteLine(userData); // Write data to a new line
                    }
                    MessageBox.Show("User credentials appended to CSV file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }

        }
    }
}
