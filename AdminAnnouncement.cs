﻿using System;
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
    public partial class AdminAnnouncement : Form
    {
        private static string csvFileName = "announcements.csv";
        private static string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);
        private static List<string> announcementList = new List<string>();
        public AdminAnnouncement()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string announcement = createTextBox.Text.Trim(); 
            if (!string.IsNullOrWhiteSpace(announcement)) 
            {
                if (!announcementList.Contains(announcement)) 
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to add this announcement?", "Confirm Announcement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        announcementList.Add(announcement);
                        SaveAnnouncementsToFile();
                        MessageBox.Show("Announcement Successful!","Announcement Confirmed", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {

                    }

                }
                else
                {
                    MessageBox.Show("The announcement already exists.","Announcement Already Exists",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Announcements can not be empty!","Announcement Empty",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            createTextBox.Clear(); 
            LoadAnnouncementsFromFile();
        }
        private void LoadAnnouncementsFromFile()
        {


            if (File.Exists(csvFilePath))
            {
                string[] lines = File.ReadAllLines(csvFilePath);
                if (lines.Length > 0 && !string.IsNullOrWhiteSpace(lines[0]))
                {
                    StringBuilder textFormat = new StringBuilder();

                    for (int i = 0; i < lines.Length; i++)
                    {
                        textFormat.AppendFormat("{0}. {1}\n\n", i + 1, lines[i]);
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
        private void SaveAnnouncementsToFile()
        {
            File.WriteAllLines(csvFileName, announcementList);
        }

        private void AdminAnnouncement_Load(object sender, EventArgs e)
        {
            LoadAnnouncementsFromFile();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitDelete_Click(object sender, EventArgs e)
        { 
            int index;
            //error handling for the index 
            if (int.TryParse(deleteTextBox.Text, out index))
            {
                index = index - 1;
                if (index >= 0 && index < announcementList.Count)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to remove this announcement?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(result == DialogResult.Yes)
                    {
                        announcementList.RemoveAt(index);
                        SaveAnnouncementsToFile();
                        
                        MessageBox.Show("Announcement Removed!", "Removal Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //nothing happens
                    }

                }
                else
                {
                    MessageBox.Show("Invalid announcement number.","Invalid Number",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                }
            }
            else
            {
                MessageBox.Show("Invalid announcement number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            deleteTextBox.Clear();
            LoadAnnouncementsFromFile();
        }

        private void deleteTextBox_Click(object sender, EventArgs e)
        {
            deleteTextBox.Text = "";
        }

        private void deleteTextBox_TextChanged(object sender, EventArgs e)
        {
            deleteTextBox.ForeColor = Color.Black;
        }

        private void createTextBox_Click(object sender, EventArgs e)
        {
            createTextBox.Text = "";
        }

        private void createTextBox_TextChanged(object sender, EventArgs e)
        {
            createTextBox.ForeColor = Color.Black;
        }
    }
}
