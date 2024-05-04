using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormify
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();

            ChangeNavButton(btnAnnouncement);
            AdminAnnouncement frm = new AdminAnnouncement() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm("Announcements", frm);
        }

        private void LoadForm(string title, Form form)
        {
            lblTitle.Text = title;
            pnlFormLoader.Controls.Clear();
            pnlFormLoader.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void ChangeNavButton(Button button)
        {
            pnlNav.Height = button.Height;
            pnlNav.Top = button.Top;
            pnlNav.Left = button.Left;
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            ChangeNavButton(btnAnnouncement);
            AdminAnnouncement frm = new AdminAnnouncement() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm("Announcements", frm);
        }

        private void btnLiab_Click(object sender, EventArgs e)
        {
            ChangeNavButton(btnLiab);
            AdminLiabilities frm = new AdminLiabilities() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm("Liabilities", frm);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            ChangeNavButton(btnAttendance);
            AdminAttendance frm = new AdminAttendance() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm("Attendance", frm);
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            ChangeNavButton(btnMessages);
            AdminMessages frm = new AdminMessages() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm("Messages", frm);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var mainForm = new LoginForm();
            mainForm.Show();

            this.Hide();
        } 
    }
}
