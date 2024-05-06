using System;
using System.IO;
using System.Windows.Forms;
using CsvHelper;

namespace Dormify
{
    public partial class RegGuests : Form
    {
        public string loggedUsername;
        public string loggedRoom;

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
    }
}
