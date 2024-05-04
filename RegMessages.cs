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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMessageSubmit_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(message))
            {
                if (!messageList.Contains(message))
                {
                    var newForm = new AdminMessages();
                    newForm.loggedUsername = loggedUsername;
                    messageList.Add(message);
                    SaveMessagesToFile();
                    MessageBox.Show("Message sent!");
                    messageList.Clear();
                }
                else
                {
                    MessageBox.Show("You have already sent this message.");
                }
            }
            else
            {
                MessageBox.Show("Messages can not be empty!");
            }

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
    }
}
