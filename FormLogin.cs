using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMKG_DataSafe_2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            btnAdmin.Enabled = true;
            FormMainAdmin formMainAdmin = new FormMainAdmin();
            formMainAdmin.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            btnUser.Enabled = true;
            FormMainUser formMainUser = new FormMainUser();
            formMainUser.Show();
            this.Hide();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}