using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dormify.AdminLiabilities;

namespace Dormify
{
    public partial class RegMessages : Form
    {
        public string loggedUsername { get; set; }
        private static string csvFileName = "message.csv";
        private static string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

        private static List<String> messageList = new List<String>();
        public RegMessages()
        {
            InitializeComponent();

        }
        public class MessageInformation
        {
            public string messageID { get; set; }  
            public string username { get; set; }
            public string message { get; set; }
            public string status { get; set; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMessageSubmit_Click(object sender, EventArgs e)
        {
            string messageID = Guid.NewGuid().ToString();
            string username = loggedUsername;
            string message = messageTextBox.Text.Trim();
            string status = "Pending";
            
            MessageInformation messageInformation = new MessageInformation
            { 
               messageID = messageID,
               username = username,
               message = message,
               status = status,
            };
            MessageBox.Show("Message Sent!");
            WriteToCsv(messageInformation);
            messageTextBox.Clear();
            LoadMessagesFromFile();
        }
        private void LoadMessagesFromFile()
        {
            if (File.Exists(csvFileName))
            {
                messageList = File.ReadAllLines(csvFileName).ToList();
            }
            else
            {
                //nothing happens
            }
        }
        private void SaveMessagesToFile()
        {
            File.WriteAllLines(csvFileName, messageList);
        }

        private void RegMessages_Load(object sender, EventArgs e)
        {
            
            LoadMessagesFromFile();
        }
        private void WriteToCsv(MessageInformation messageInformation)
        {
            string csvFileName = "message.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

            using (StreamWriter writer = new StreamWriter(csvFilePath, true))
            using (CsvWriter csvWriter = new CsvWriter(writer, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
            {
                csvWriter.WriteRecord(messageInformation);
                writer.WriteLine(); // Add newline after writing the record
            }
        }

    }
}
