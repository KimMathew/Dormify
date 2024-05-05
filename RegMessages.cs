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

        //Font color will change if typing 
        private void messageTextBox_Click(object sender, EventArgs e)
        {
            messageTextBox.Text = "";
        }

        //Display a text and clear a text box if clicked
        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            messageTextBox.ForeColor = Color.Black;
        }
    }
}
