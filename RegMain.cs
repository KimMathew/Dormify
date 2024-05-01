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
        public static RegMain instance;
        public Label userLabel;
        public Label userRoom;

        public RegMain()
        {
            InitializeComponent();
            instance = this;
            userLabel = usernamelbl;
            userRoom = roomNum;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var mainForm = new LoginForm();
            mainForm.Show();

            this.Hide();
        }

        private void RegMain_Load(object sender, EventArgs e)
        {

        }
    }
}
