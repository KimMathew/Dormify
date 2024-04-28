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
    public partial class RegularForm : Form
    {
        public RegularForm()
        {
            InitializeComponent();

            ChangeNavButton(btnAnnouncement);
            RegAnnouncement frm = new RegAnnouncement() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm("Announcement", frm);
        }

        private void LoadForm(string title, Form form)
        {
            lblTitle.Text = title;
            pnlFormLoader.Controls.Clear();
            pnlFormLoader.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void RegularForm_Load(object sender, EventArgs e)
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
            RegAnnouncement frm = new RegAnnouncement() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm("Announcement", frm);
        }

        private void btnLiab_Click(object sender, EventArgs e)
        {
            ChangeNavButton(btnLiab);
            RegLiabilities frm = new RegLiabilities() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm("Liabilities", frm);

            
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            ChangeNavButton(btnAttendance);
            RegAttendance frm = new RegAttendance() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm("Attendance", frm);
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            ChangeNavButton(btnTime);
            RegTimeIn_Out frm = new RegTimeIn_Out() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            LoadForm("Time In/Time Out", frm);
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var mainForm = new LoginForm();
            mainForm.Show();

            this.Hide();
        }
    }
}
