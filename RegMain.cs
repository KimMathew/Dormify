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


        public RegMain()
        {
            InitializeComponent();
            instance = this;
            userLabel = usernamelbl;
            userRoom = roomNum;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var mainForm = new LoginForm();
            mainForm.Show();

            this.Hide();
        }

        private void RegMain_Load(object sender, EventArgs e)
        {
            LoadLiabilitiesByAssigneeFromCsv(loggedUsername);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                        MessageBox.Show("User not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("CSV file not found.");
            }
        }
    }
}
