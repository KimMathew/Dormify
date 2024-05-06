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
    public partial class AdminMessages : Form
    {
        public string loggedUsername {get; set;}
        private static List<string> messageList = new List<string>();
        public AdminMessages()
        {
            InitializeComponent();
        }


        private void LoadMessagesFromFile()
        {
            string csvFileName = "message.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);

            if (File.Exists(csvFilePath))
            {
                string[] lines = File.ReadAllLines(csvFilePath);
                if (lines.Length > 0 && !string.IsNullOrWhiteSpace(lines[0]))
                {
                    StringBuilder textFormat = new StringBuilder();

                    for (int i = 0; i < lines.Length; i++)
                    {
                        textFormat.AppendFormat("{0}\n\n", lines[i]);
                        showMessages.Text = textFormat.ToString();
                    }
                }
                else
                {
                    showMessages.Text = "No messages at the moment.";
                }

            }
            else
            {
                showMessages.Text = "No messages at the moment.";
            }
            if (File.Exists(csvFileName))
            {
                messageList = File.ReadAllLines(csvFileName).ToList();
            }
        }

        private void showMessages_Click(object sender, EventArgs e)
        {

        }

        private void AdminMessages_Load(object sender, EventArgs e)
        {
            LoadMessagesFromFile();
        }

    }
}
