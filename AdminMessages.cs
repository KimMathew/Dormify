using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dormify.AdminLiabilities;

namespace Dormify
{
    public partial class AdminMessages : Form
    {
        public static string csvFileName = "message.csv";
        public static string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);
        public string loggedUsername {get; set;}
        private static List<string> messageList = new List<string>();
        public AdminMessages()
        {
            InitializeComponent();
        }

        public class dormMessage
        {
            public string uniqueID {get; set;}
            public string username {get; set;}
            public string message {get; set;}
            public string status {get; set;}

        }


        private void LoadMessagesFromFile()
        {
            try
            {
                if (File.Exists(csvFilePath))
                {

                    using (var reader = new StreamReader(csvFilePath))
                    using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
                    {
                        // Read the records from CSV file
                        var records = csv.GetRecords<dormMessage>();

                        // Clear existing rows and columns from DataGridView
                        messageDGV.Rows.Clear();
                        messageDGV.Columns.Clear();

                        // Define DataGridView columns
                        messageDGV.Columns.Add("UNIQUE ID", "Unique ID");
                        messageDGV.Columns.Add("Username", "Username");
                        messageDGV.Columns.Add("Message", "Message");
                        messageDGV.Columns.Add("Status", "Status");

                        // Populate DataGridView with message data
                        foreach (var dormMessage in records)
                        {
                            // Add a new row to DataGridView
                            messageDGV.Rows.Add(dormMessage.uniqueID, dormMessage.username, dormMessage.message, dormMessage.status);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("CSV file not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred while loading liabilities from CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void showMessages_Click(object sender, EventArgs e)
        {

        }

        private void AdminMessages_Load(object sender, EventArgs e)
        {
           LoadMessagesFromFile();
        }

        private void btnSearchMessage_Click(object sender, EventArgs e)
        {
            string searchedID = searchMessageTextBox.Text;

            searchedMessage(searchedID);
        }
        private void searchedMessage(string searchedID)
        {
            try
            {
                string selectedStatus = statusComboBox.SelectedItem?.ToString();
                if (File.Exists(csvFilePath))
                {
                    

                    using (var reader = new StreamReader(csvFilePath))
                    using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
                    {
                        // Read the records from CSV file and acts as a if statement
                        var records = csv.GetRecords<dormMessage>().Where(l => string.Equals(l.uniqueID, searchedID, StringComparison.OrdinalIgnoreCase)).ToList();

                        // Clear existing rows and columns from searchedDGV
                        searchedDGV.Rows.Clear();
                        searchedDGV.Columns.Clear();

                        // Header
                        searchedDGV.Columns.Add("UNIQUE ID", "Unique ID");
                        searchedDGV.Columns.Add("Username", "Username");
                        searchedDGV.Columns.Add("Message", "Message");
                        searchedDGV.Columns.Add("Status", "Status");

                        // Populate the searchedDGV with the uniqueID of the message
                        foreach (var dormMessage in records)
                        {
                            // Add a new row to DataGridView
                            searchedDGV.Rows.Add(dormMessage.uniqueID, dormMessage.username, dormMessage.message, dormMessage.status);
                            statusComboBox.Text = dormMessage.status;
                        }
                        searchedDGV.Columns["Status"].Visible = false;
                        
                    }
                }
                else
                {
                    MessageBox.Show("CSV file not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading liabilities from CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected status from the combo box
            string selectedStatus = statusComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedStatus))
            {
                try
                {
                    // get the uniqueid
                    string searchedID = searchMessageTextBox.Text;

                    // read all the records on the message csv file
                    var records = new List<dormMessage>();
                    using (var reader = new StreamReader(csvFilePath))
                    using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
                    {
                        records = csv.GetRecords<dormMessage>().ToList();
                    }

                    // update the status
                    foreach (var dormMessage in records)
                    {
                        if (string.Equals(dormMessage.uniqueID, searchedID, StringComparison.OrdinalIgnoreCase))
                        {
                            dormMessage.status = selectedStatus;
                            break; 
                        }
                    }

                    // update the message csv file
                    using (var writer = new StreamWriter(csvFilePath))
                    using (var csv = new CsvWriter(writer, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
                    {
                        csv.WriteRecords(records);
                    }

                    // refresh to view the changes
                    LoadMessagesFromFile();
                    MessageBox.Show("Status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSubmitStatus_Click(object sender, EventArgs e)
        {
            statusComboBox_SelectedIndexChanged(sender, e);
        }

        private void searchMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            searchMessageTextBox.ForeColor = Color.Black;
        }

        private void searchMessageTextBox_Click(object sender, EventArgs e)
        {
            searchMessageTextBox.Text = "";
        }
    }
}
