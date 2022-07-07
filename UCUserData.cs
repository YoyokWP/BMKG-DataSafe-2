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
    public partial class UCUserData : UserControl
    {
        public UCUserData()
        {
            InitializeComponent();
        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
            labelFullName.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            labelEmail.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelGender.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelStation.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxVerifyPassword_TextChanged(object sender, EventArgs e)
        {
            string Password, Verify;
            Password = textBoxPassword.Text;
            Verify = textBoxVerifyPassword.Text;
            if (Verify == Password)
            {
                labelPassword.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
                labelVerifyPassword.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
            }
            else
            {
                labelPassword.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
                labelVerifyPassword.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            }
        }

        private void buttonAddDatabase_Click(object sender, EventArgs e)
        {

            string gender = comboBoxGender.Text;
        }
    }
}
