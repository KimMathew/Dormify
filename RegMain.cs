using CsvHelper;
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
using static Dormify.AdminLiabilities;

namespace Dormify
{
    public partial class RegMain : Form
    { 
        public string loggedUsername { get; set; }
        public string loggedRoom { get; set; }
        public static RegMain instance;
        public Label userLabel;
        public Label userRoom;
        public static List<string> announcementList = new List<string>();


        public RegMain()
        {
            InitializeComponent();
            instance = this;
            userLabel = usernamelbl;
            userRoom = roomNum;
        }

        public class Attendance
        {
            public string Username { get; set; }
            public string Status { get; set; }
            public string RoomNumber { get; set; }
            public string Time_and_Date { get; set; }
        }


        private void ShowFormWithBackground<T>(T form) where T : Form, new()
        {
            this.ActiveControl = null;
            using (Form frmBackground = new Form())
            {
                frmBackground.StartPosition = FormStartPosition.Manual;
                frmBackground.FormBorderStyle = FormBorderStyle.None;
                frmBackground.Opacity = 0.5d;
                frmBackground.BackColor = Color.Black;
                frmBackground.Size = this.Size;
                frmBackground.Location = this.Location;
                frmBackground.ShowInTaskbar = false;
                frmBackground.Show();
                form.Owner = frmBackground;
                form.ShowDialog();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var mainForm = new LoginForm();
            mainForm.Show();

            this.Close();
        }

        private void RegMain_Load(object sender, EventArgs e)
        {
            LoadLiabilitiesByAssigneeFromCsv(loggedUsername);
            LoadAnnouncementsFromFile();
            loadAttendanceChecker(loggedRoom);
        }

        private void LoadLiabilitiesByAssigneeFromCsv(string assigneeName)
        {
            // Path to your CSV file
            string csvFileName = "liabilities.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);


            // Check if the file exists
            if (File.Exists(csvFilePath))
            {
                using (var reader = new StreamReader(csvFilePath))
                using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
                {
                    // Read the records from CSV file
                    var records = csv.GetRecords<Liability>().Where(l => l.AssigneeName == assigneeName).ToList();

                    // Clear existing rows and columns from DataGridView
                    regularLiab.Rows.Clear();
                    regularLiab.Columns.Clear();

                    // Define DataGridView columns
                    regularLiab.Columns.Add("Name", "Liability Name");
                    regularLiab.Columns.Add("Description", "Description");
                    regularLiab.Columns.Add("Price", "Price");
                    regularLiab.Columns.Add("DueDate", "Due Date");

                    // Check if any records were found for the specified assignee
                    if (records.Any())
                    {
                        // Populate DataGridView with filtered liability data
                        foreach (var liability in records)
                        {
                            // Add a new row to DataGridView
                            regularLiab.Rows.Add(liability.Name, liability.Description, liability.Price, liability.DueDate);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No liabilities found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("CSV file not found.");
            }
        }
        private void LoadAnnouncementsFromFile()
        {
            
            string csvFileName = "announcements.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);


            if (File.Exists(csvFilePath))
            {

                string[] lines = File.ReadAllLines(csvFilePath);
                if (lines.Length > 0 && !string.IsNullOrWhiteSpace(lines[0]))
                {
                    StringBuilder textFormat = new StringBuilder();
                   
                    for(int i = 0; i < lines.Length; i++)
                    {
                        textFormat.AppendFormat("{0}. {1}\n\n",i+1, lines[i]);
                        showTextBox.Text = textFormat.ToString();
                    }
                    
                }
                else
                {
                    showTextBox.Text = "No announcement at the moment.";
                }
            }
            else
            {
                showTextBox.Text = "No announcement at the moment.";
            }

            if (File.Exists(csvFileName))
            {
               announcementList = File.ReadAllLines(csvFileName).ToList();
            }
        }

        private void btnRegMessages_Click(object sender, EventArgs e)
        {
            var newForm = new RegMessages();
            newForm.loggedUsername = loggedUsername;
            ShowFormWithBackground(newForm);
  

        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            ShowFormWithBackground(new RegGuests());
        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButtonState(Button button, bool enabled)
        {
            button.Enabled = enabled;
            button.BackColor = enabled ? Color.FromArgb(101, 134, 247) : Color.FromArgb(166, 182, 250);
        }

        private void TimeIn_Click(object sender, EventArgs e)
        {
            string csvFileName = "attendance.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

            // Create a list to hold modified lines
            List<string> modifiedLines = new List<string>();

            try
            {
                // Read all lines from the CSV file
                string[] allLines = File.ReadAllLines(csvFilePath);

                // Iterate through each line
                foreach (string line in allLines)
                {
                    // Split the line into fields
                    string[] fields = line.Split(',');

                    // Check if the username matches
                    if (fields.Length > 1 && fields[0] == usernamelbl.Text)
                    {
                        // Update the "Time In" field
                        fields[1] = "Time In";
                        fields[2] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    }

                    // Join the fields back into a line
                    string modifiedLine = string.Join(",", fields);

                    // Add the modified line to the list
                    modifiedLines.Add(modifiedLine);
                }

                // Write the modified lines back to the CSV file
                File.WriteAllLines(csvFilePath, modifiedLines);

                loadAttendanceChecker(roomNum.Text);

                UpdateButtonState(TimeIn, false);
                UpdateButtonState(TimeOut, true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void TimeOut_Click(object sender, EventArgs e)
        {
            string csvFileName = "attendance.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

            // Create a list to hold modified lines
            List<string> modifiedLines = new List<string>();

            try
            {
                // Read all lines from the CSV file
                string[] allLines = File.ReadAllLines(csvFilePath);

                // Iterate through each line
                foreach (string line in allLines)
                {
                    // Split the line into fields
                    string[] fields = line.Split(',');

                    // Check if the username matches
                    if (fields.Length > 1 && fields[0] == usernamelbl.Text)
                    {
                        // Update the "Time Out" field
                        fields[1] = "Time Out";
                        fields[2] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    }

                    // Join the fields back into a line
                    string modifiedLine = string.Join(",", fields);

                    // Add the modified line to the list
                    modifiedLines.Add(modifiedLine);
                }

                // Write the modified lines back to the CSV file
                File.WriteAllLines(csvFilePath, modifiedLines);

                loadAttendanceChecker(roomNum.Text);

                UpdateButtonState(TimeOut, false);
                UpdateButtonState(TimeIn, true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void loadAttendanceChecker(string room)
        {
            string csvFileName = "attendance.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

            // Print or display csvFilePath to check the file path
            Console.WriteLine($"CSV File Path: {csvFilePath}");

            if (File.Exists(csvFilePath))
            {
                using (var reader = new StreamReader(csvFilePath))
                using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
                {
                    try
                    {
                        var records = csv.GetRecords<Attendance>().Where(a => a.RoomNumber.ToString() == room).ToList();
                        // Print or display the count or contents of records for debugging
                        Console.WriteLine($"Number of Records: {records.Count}");

                        if (regAttendance.Columns.Count == 0)
                        {
                            regAttendance.Columns.Add("Name", "Username");
                            regAttendance.Columns.Add("Status", "Status");
                            regAttendance.Columns.Add("Time_and_Date", "Date");
                        }


                        if (records.Any())
                        {
                            regAttendance.Rows.Clear();
                            foreach (var attendanceRecord in records)
                            {
                                regAttendance.Rows.Add(attendanceRecord.Username, attendanceRecord.Status, attendanceRecord.Time_and_Date);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No attendance records found for this room.");
                        }
                        // Refresh the DataGridView display
                        regAttendance.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading attendance data: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Attendance CSV file not found.");
            }

        }
    }
}
