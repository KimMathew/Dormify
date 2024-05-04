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

            if (File.Exists("announcements.csv"))
            {
               announcementList = File.ReadAllLines("announcements.csv").ToList();
            }
        }

        private void btnRegMessages_Click(object sender, EventArgs e)
        {
            ShowFormWithBackground(new RegMessages());
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            ShowFormWithBackground(new RegGuests());
        }
    }
}
