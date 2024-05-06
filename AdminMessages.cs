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

    }
}
