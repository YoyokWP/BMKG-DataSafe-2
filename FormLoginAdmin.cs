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
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            labelUsername.Hide();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelPassword.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string UserId, Password;
            UserId = textBoxUsername.Text;
            Password = textBoxPassword.Text;
            if (UserId == "admin" && Password == "admin")
            {
                FormMainAdmin formMainAdmin = new FormMainAdmin();
                formMainAdmin.Show();
                this.Hide();

                buttonLogin.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
            }
            else
            {
                MessageBox.Show("Masukkan ID dengan benar");
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {

        }
    }
}
