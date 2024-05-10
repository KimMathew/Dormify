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
    public class BaseLiability
    {
        public string Id { get; set; }
        public string AssigneeName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string DueDate { get; set; }
    }

    public class Liability : BaseLiability
    {
        // Additional properties or methods specific to Liability for future functions can be added here
    }

    // Interface to define operations on liabilities
    public interface ILiabilityRepository
    {
        void LoadLiabilities();
        void LoadLiabilitiesByAssignee(string assigneeName);
        void RemoveLiability(string id);
        void WriteToCsv(BaseLiability liability);
    }

    // AdminLiabilities class implementing ILiabilityRepository
    public partial class AdminLiabilities : Form, ILiabilityRepository
    {
        public AdminLiabilities()
        {
            InitializeComponent();
        }

        private void AdminLiabilities_Load(object sender, EventArgs e)
        {
            LoadLiabilities();
        }

        public void LoadLiabilities()
        {
            try
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
                    MessageBox.Show("CSV file not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading liabilities from CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadLiabilitiesByAssignee(string assigneeName)
        {
            try
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
                        var records = csv.GetRecords<Liability>().Where(l => string.Equals(l.AssigneeName, assigneeName, StringComparison.OrdinalIgnoreCase)).ToList();

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
                            MessageBox.Show("User not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("CSV file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading liabilities by assignee from CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveLiability(string id)
        {
            try
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

                        MessageBox.Show($"Removed {removedCount} liabilities having the unique id: {id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No liabilities having the unique id: {id}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("CSV file not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing liabilities by ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void WriteToCsv(BaseLiability liability)
        {
            try
            {
                // Path to your CSV files
                string csvFileName = "liabilities.csv";
                string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

                string csvFileName2 = "historyLiab.csv";
                string csvFilePath2 = Path.Combine(Directory.GetCurrentDirectory(), csvFileName2);

                // Write to liabilities.csv
                using (StreamWriter writer = new StreamWriter(csvFilePath, true))
                using (CsvWriter csvWriter = new CsvWriter(writer, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
                {
                    csvWriter.WriteRecord(liability);
                    writer.WriteLine(); // Add newline after writing the record
                }

                // Write to historyLiab.csv
                using (StreamWriter writer = new StreamWriter(csvFilePath2, true))
                using (CsvWriter csvWriter = new CsvWriter(writer, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
                {
                    csvWriter.WriteRecord(liability);
                    writer.WriteLine(); // Add newline after writing the record
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to CSV files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Other methods and event handlers...

        private void viewSpecified_Click(object sender, EventArgs e)
        {
            string viewSpecific = specificLiab.Text;
            LoadLiabilitiesByAssignee(viewSpecific);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            string idToRemove = removeLiab.Text;
            RemoveLiability(idToRemove);
            specificLiab.Text = "";
            LoadLiabilities();
            if (!string.IsNullOrWhiteSpace(specificLiab.Text))
            {
                LoadLiabilitiesByAssignee(specificLiab.Text);
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

            MessageBox.Show("Liability submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadLiabilities();

            ClearTextBoxes();
        }

        private void specificLiab_Click(object sender, EventArgs e)
        {
            specificLiab.Text = "";
        }

        private void specificLiab_TextChanged(object sender, EventArgs e)
        {
            specificLiab.ForeColor = Color.Black;
        }

        private void removeLiab_Click(object sender, EventArgs e)
        {
            removeLiab.Text = "";
        }

        private void removeLiab_TextChanged(object sender, EventArgs e)
        {
            removeLiab.ForeColor = Color.Black;
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
    }
}
