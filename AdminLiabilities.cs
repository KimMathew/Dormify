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

namespace Dormify
{
    public partial class AdminLiabilities : Form
    {
        public AdminLiabilities()
        {
            InitializeComponent();
        }

        private void AdminLiabilities_Load(object sender, EventArgs e)
        {
            LoadLiabilitiesFromCsv();
        }

        public class Liability
        {
            public string Id { get; set; }
            public string AssigneeName { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
            public string DueDate { get; set; }
        }

        private void LoadLiabilitiesFromCsv()
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
                    var records = csv.GetRecords<Liability>();

                    // Clear existing rows and columns from DataGridView
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    // Define DataGridView columns
                    dataGridView1.Columns.Add("Id", "UniqueID");
                    dataGridView1.Columns.Add("AssigneeName", "Assignee Name");
                    dataGridView1.Columns.Add("Name", "Liability Name");
                    dataGridView1.Columns.Add("Description", "Description");
                    dataGridView1.Columns.Add("Price", "Price");
                    dataGridView1.Columns.Add("DueDate", "Due Date");

                    // Populate DataGridView with liability data
                    foreach (var liability in records)
                    {
                        // Add a new row to DataGridView
                        dataGridView1.Rows.Add(liability.Id, liability.AssigneeName, liability.Name, liability.Description, liability.Price, liability.DueDate);

                    }
                }
            }
            else
            {
                MessageBox.Show("CSV file not found.");
            }
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
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();

                    // Define DataGridView columns
                    dataGridView2.Columns.Add("Id", "UniqueID");
                    dataGridView2.Columns.Add("AssigneeName", "Assignee Name");
                    dataGridView2.Columns.Add("Name", "Liability Name");
                    dataGridView2.Columns.Add("Description", "Description");
                    dataGridView2.Columns.Add("Price", "Price");
                    dataGridView2.Columns.Add("DueDate", "Due Date");

                    // Check if any records were found for the specified assignee
                    if (records.Any())
                    {
                        // Populate DataGridView with filtered liability data
                        foreach (var liability in records)
                        {
                            // Add a new row to DataGridView
                            dataGridView2.Rows.Add(liability.Id, liability.AssigneeName, liability.Name, liability.Description, liability.Price, liability.DueDate);
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



        private void RemoveLiabilityByAssigneeName(string id)
        {
            // Path to your CSV file
            string csvFileName = "liabilities.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

            // Check if the file exists
            if (File.Exists(csvFilePath))
            {
                // Read all lines from the CSV file
                List<string> lines = File.ReadAllLines(csvFilePath).ToList();

                // Remove liabilities with the specified assignee name
                int removedCount = lines.RemoveAll(line => line.Split(',')[0] == id); // Assuming assigneeName is in the second column (index 1)

                if (removedCount > 0)
                {
                    // Rewrite the updated data back to the CSV file
                    File.WriteAllLines(csvFilePath, lines);

                    MessageBox.Show($"Removed {removedCount} liabilities having the unique id: {id}");
                }
                else
                {
                    MessageBox.Show($"No liabilities having the unique id: {id}");
                }
            }
            else
            {
                MessageBox.Show("CSV file not found.");
            }
        }

        private void ClearTextBoxes()
        {
            asignee.Text = "";
            name.Text = "";
            description.Text = "";
            price.Text = "";
            dueDate.Text = "";
            removeLiab.Text = "";
        }



        private void WriteToCsv(Liability liability)
        {
            // Path to your CSV file
            string csvFileName = "liabilities.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

            using (StreamWriter writer = new StreamWriter(csvFilePath, true))
            using (CsvWriter csvWriter = new CsvWriter(writer, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
            {
                csvWriter.WriteRecord(liability);
                writer.WriteLine(); // Add newline after writing the record
            }
        }


        

        public  void viewSpecified_Click(object sender, EventArgs e)
        {
            string viewSpecific = specificLiab.Text;
            LoadLiabilitiesByAssigneeFromCsv(viewSpecific);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            string idToRemove = removeLiab.Text;
            RemoveLiabilityByAssigneeName(idToRemove);
            specificLiab.Text = "";
            LoadLiabilitiesFromCsv();
            if (!string.IsNullOrWhiteSpace(specificLiab.Text))
            {
                LoadLiabilitiesByAssigneeFromCsv(specificLiab.Text);
            }
            dataGridView2.Rows.Clear();
            ClearTextBoxes();
        }


        private void submit_Click(object sender, EventArgs e)
        {
            // Gather liability data from form controls
            string id = Guid.NewGuid().ToString();
            string assigneeName = asignee.Text;
            string userName = name.Text;
            string desc = description.Text;
            string liabPrice = price.Text;
            string due = dueDate.Text;

            // Create a Liability object
            Liability liability = new Liability
            {
                Id = id,
                AssigneeName = assigneeName,
                Name = userName,
                Description = desc,
                Price = liabPrice,
                DueDate = due
            };

            // Write liability to CSV file
            WriteToCsv(liability);

            MessageBox.Show("Liability submitted successfully.");

            LoadLiabilitiesFromCsv();

            ClearTextBoxes();


        }

    }
}
