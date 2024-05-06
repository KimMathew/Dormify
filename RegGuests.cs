using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CsvHelper;

namespace Dormify
{
    public partial class RegGuests : Form
    {
        public string loggedUsername;
        public string loggedRoom;
        public string guestLeave;

        public RegGuests(string username, string room)
        {
            InitializeComponent();
            loggedUsername = username;
            loggedRoom = room;
        }

    


        private void RegGuests_Load(object sender, EventArgs e)
        {
            guestBy.Text = loggedUsername;
            guestRoomNum.Text = loggedRoom;
        }

        private class Guest
        {
            public string Name { get; set; }
            public string RoomNumber { get; set; }
            public string Address { get; set; }
            public string ContactNumber { get; set; }
            public string GuestBy { get; set; }
            public string Reason { get; set; }
            public string TimeIn { get; set; }
            public string TimeOut { get; set; }
        }


        private void WriteToCsv(Guest guest)
        {
            // Path to your CSV files
            string csvFileName = "guest.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

            // Write to liabilities.csv
            using (StreamWriter writer = new StreamWriter(csvFilePath, true))
            using (CsvWriter csvWriter = new CsvWriter(writer, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
            {
                csvWriter.WriteRecord(guest);
                writer.WriteLine(); // Add newline after writing the record
            }
        }



        private void ClearTextBoxes()
        {
            guestName.Text = "";
            guestRoomNum.Text = "";
            guestAddress.Text = "";
            guestContactNum.Text = "";
            guestBy.Text = "";
            guestReason.Text = "";
        }

        private void SetTimeOut(string guestName)
        {
            // Path to your CSV file
            string csvFileName = "guest.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

            try
            {
                // Read all lines from the CSV file
                string[] allLines = File.ReadAllLines(csvFilePath);

                // Create a list to hold modified lines
                List<string> modifiedLines = new List<string>();

                // Flag to check if the guest was found
                bool guestFound = false;

                // Iterate through each line
                foreach (string line in allLines)
                {
                    // Split the line into fields
                    string[] fields = line.Split(',');

                    // Check if the guest name matches
                    if (fields.Length > 0 && fields[0] == guestName)
                    {
                        guestFound = true;

                        // Update the "Time Out" field (assuming it's the 8th field)
                        if (fields.Length >= 8)
                        {
                            fields[7] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {
                            // If the line doesn't have enough fields, skip it and log a message
                            MessageBox.Show($"Invalid format in CSV file for guest '{guestName}'. Unable to update time out.");
                            continue;
                        }
                    }

                    // Join the fields back into a line
                    string modifiedLine = string.Join(",", fields);

                    // Add the modified line to the list
                    modifiedLines.Add(modifiedLine);
                }

                // Write the modified lines back to the CSV file
                File.WriteAllLines(csvFilePath, modifiedLines);

                if (guestFound)
                {
                    // Optionally, perform any additional tasks here after updating the time out
                    MessageBox.Show($"Time out updated for guest '{guestName}' to {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
                }
                else
                {
                    MessageBox.Show($"Guest '{guestName}' not found in the CSV file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating time out for guest '{guestName}': {ex.Message}");
            }
        }




        public void timeIn_Click(object sender, EventArgs e)
        {
            // Gather liability data from form controls
            string name = guestName.Text;
            string roomNumber = loggedRoom;
            string address = guestAddress.Text;
            string contactNumber = guestContactNum.Text;
            string guestBy = loggedUsername;
            string reason = guestReason.Text;
            string timeIn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string timeOut = "";


            // Create a Liability object
            var guest = new Guest
            {
                Name = name,
                RoomNumber = roomNumber,
                Address = address,
                ContactNumber = contactNumber,
                GuestBy = guestBy,
                Reason = reason,
                TimeIn = timeIn,
                TimeOut = timeOut
            };

            // Write liability to CSV file
            WriteToCsv(guest);

            MessageBox.Show("Guest Time In done");

            ClearTextBoxes();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeOt_Click(object sender, EventArgs e)
        {
            guestLeave = guestTO.Text;
            SetTimeOut(guestLeave);
        }
    }
}
