﻿using CsvHelper;
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
using static Dormify.RegMain;

namespace Dormify
{
    public partial class AdminAttendance : Form
    {


        public AdminAttendance()
        {
            InitializeComponent();
            this.Load += AdminAttendance_Load;
        }

        public class Guest
        {
            public string Name { get; set; }
            public string RoomNumber { get; set; }
            public string Address { get; set; }
            public string ContactNumber { get; set; }
            public string GuestBy { get; set; }
            public string Reason { get; set; }
            public string TimeIn { get; set; }
            public string TimeOut { get; set; }
        }


        private void AdminAttendance_Load(object sender, EventArgs e)
        {
            loadAllAttendance();
            loadGuestAttendance();
        }


        private void loadAllAttendance()
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
                        var records = csv.GetRecords<Attendance>();

                        // Clear existing columns before adding new ones
                        allAttendance.Columns.Clear();

                        allAttendance.Columns.Add("RoomNumber", "Room Number");
                        allAttendance.Columns.Add("Name", "Username");
                        allAttendance.Columns.Add("Status", "Status");
                        allAttendance.Columns.Add("Time_and_Date", "Time");

                        allAttendance.Rows.Clear();
                        foreach (var attendanceRecord in records)
                        {
                            allAttendance.Rows.Add(attendanceRecord.RoomNumber, attendanceRecord.Username, attendanceRecord.Status, attendanceRecord.Time_and_Date);
                        }

                        allAttendance.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading attendance data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Attendance CSV file not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadGuestAttendance()
        {
            string csvFileName = "guest.csv";
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
                        var records = csv.GetRecords<Guest>();

                        // Clear existing columns before adding new ones
                        guestUser.Columns.Clear();

                        guestUser.Columns.Add("RoomNumber", "Room Number");
                        guestUser.Columns.Add("Name", "Name");
                        guestUser.Columns.Add("GuestBy", "Guest By");
                        guestUser.Columns.Add("Reason", "Reason");
                        guestUser.Columns.Add("TimeIn", "Time In");
                        guestUser.Columns.Add("TimeOut", "Time Out");

                        guestUser.Rows.Clear();
                        foreach (var attendanceRecord in records)
                        {
                            guestUser.Rows.Add(attendanceRecord.RoomNumber, attendanceRecord.Name, attendanceRecord.GuestBy, attendanceRecord.Reason, attendanceRecord.TimeIn, attendanceRecord.TimeOut);
                        }

                        guestUser.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading attendance data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Attendance CSV file not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Search_Click(object sender, EventArgs e)
        {
            loadSpecificUser(textBox1.Text);
        }

        private void loadSpecificUser(string username)
        {
            string csvFileName = "attendance.csv";
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), csvFileName);
            if (File.Exists(csvFilePath))
            {
                using (var reader = new StreamReader(csvFilePath))
                using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)))
                {
                    try
                    {
                        var specificName = csv.GetRecords<Attendance>().Where(a => a.Username == username).ToList();

                        specificAttendance.Columns.Clear();

                        specificAttendance.Columns.Add("RoomNumber", "Room Number");
                        specificAttendance.Columns.Add("Name", "Username");
                        specificAttendance.Columns.Add("Status", "Status");
                        specificAttendance.Columns.Add("Time_and_Date", "Time");

                        foreach (var attendanceRecord in specificName)
                        {
                            specificAttendance.Rows.Add(attendanceRecord.RoomNumber, attendanceRecord.Username, attendanceRecord.Status, attendanceRecord.Time_and_Date);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading attendance data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Attendance CSV file not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
    }
}
