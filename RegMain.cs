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
    public partial class RegMain : Form
    {
        public RegMain()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var mainForm = new LoginForm();
            mainForm.Show();

            this.Hide();
        }
    }
}
