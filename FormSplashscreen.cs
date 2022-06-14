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
    public partial class FormSplashscreen : Form
    {
        public FormSplashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
        }
    }
}
