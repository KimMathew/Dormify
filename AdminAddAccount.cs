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
    // Interface for managing CSV file operations
    public interface ICsvFileManager
    {
        void AppendToCsv(string fileName, string data);
    }

    // Derived class for adding admin accounts
    public partial class AdminAddAccount : Form, ICsvFileManager
    {
        public string firstName;
        public string lastName;
        public string age;
        public string userName;
        public string email;
        public string password;
        public string roomNumber;
        public string accountType;
        public string defaultValue;

        public AdminAddAccount()
        {
            InitializeComponent();
        }

        // Implementation of AppendToCsv method from the ICsvFileManager interface
        public void AppendToCsv(string fileName, string data)
        {
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            try
            {
                using (StreamWriter writer = new StreamWriter(csvFilePath, true)) // Append to existing file
                {
                    writer.WriteLine();
                    writer.WriteLine(data); // Write data to a new line
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Collect user input
            firstName = textBox1.Text;
            lastName = textBox2.Text;
            age = textBox3.Text;
            userName = textBox6.Text;
            email = textBox5.Text;
            password = textBox4.Text;
            roomNumber = textBox7.Text;
            accountType = "regular";
            defaultValue = "null";

            DialogResult result = MessageBox.Show($"First Name: {firstName}\nLast Name: {lastName}\nAge: {age}\nUsername: {userName}\nEmail: {email}\nPassword: {password}\nRoom Number: {roomNumber}",
                "User Credentials",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                string userData = $"{firstName},{lastName},{age},{userName},{email},{password},{roomNumber},{accountType}";
                string attendanceData = $"{userName},{defaultValue},{defaultValue},{roomNumber}";

                // Write user credentials to CSV files using the interface method
                AppendToCsv("UserProfile.csv", userData);
                AppendToCsv("attendance.csv", attendanceData);
                MessageBox.Show("Data appended to CSV file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }
    }
}
