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
    public partial class FormMainAdmin : Form
    {
        public FormMainAdmin()
        {
            InitializeComponent();

            pictureBoxStation.Hide();
            pictureBoxUserData.Hide();
            pictureBoxFklim71Data.Hide();
            pictureBoxDatabase.Hide();
            pictureBoxAbout.Hide();
        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            UCStationData ucDtastionData = new UCStationData();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucDtastionData);

            #region Tampilan tombol
            pictureBoxStation.Show();
            pictureBoxUserData.Hide();
            pictureBoxFklim71Data.Hide();
            pictureBoxDatabase.Hide();
            pictureBoxAbout.Hide();

            btnStation.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
            btnUserData.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnFklim71Data.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnDatabase.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAbout.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);

            btnStation.BackColor = System.Drawing.Color.FromArgb(29, 35, 44);
            btnUserData.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnFklim71Data.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnDatabase.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnAbout.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            #endregion
        }

        private void btnUserData_Click(object sender, EventArgs e)
        {
            UCUserData ucUserData = new UCUserData();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucUserData);

            #region Tampilan tombol
            pictureBoxStation.Hide();
            pictureBoxUserData.Show();
            pictureBoxFklim71Data.Hide();
            pictureBoxDatabase.Hide();
            pictureBoxAbout.Hide();

            btnStation.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnUserData.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
            btnFklim71Data.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnDatabase.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAbout.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);

            btnStation.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnUserData.BackColor = System.Drawing.Color.FromArgb(29, 35, 44);
            btnFklim71Data.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnDatabase.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnAbout.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            #endregion
        }

        private void btnFklim71Data_Click(object sender, EventArgs e)
        {
            UCDataFKLIM71 ucDataFKLIM71 = new UCDataFKLIM71();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucDataFKLIM71);

            #region Tampilan tombol
            pictureBoxStation.Hide();
            pictureBoxUserData.Hide();
            pictureBoxFklim71Data.Show();
            pictureBoxDatabase.Hide();
            pictureBoxAbout.Hide();

            btnStation.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnUserData.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnFklim71Data.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
            btnDatabase.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAbout.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);

            btnStation.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnUserData.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnFklim71Data.BackColor = System.Drawing.Color.FromArgb(29, 35, 44);
            btnDatabase.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnAbout.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            #endregion
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            UCDatabase ucDatabase = new UCDatabase();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucDatabase);

            #region Tampilan tombol
            pictureBoxStation.Hide();
            pictureBoxUserData.Hide();
            pictureBoxFklim71Data.Hide();
            pictureBoxDatabase.Show();
            pictureBoxAbout.Hide();

            btnStation.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnUserData.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnFklim71Data.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnDatabase.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
            btnAbout.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);

            btnStation.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnUserData.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnFklim71Data.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnDatabase.BackColor = System.Drawing.Color.FromArgb(29, 35, 44);
            btnAbout.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            #endregion
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            UCAbout ucAbout = new UCAbout();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucAbout);

            #region Tampilan tombol
            pictureBoxStation.Hide();
            pictureBoxUserData.Hide();
            pictureBoxFklim71Data.Hide();
            pictureBoxDatabase.Hide();
            pictureBoxAbout.Show();

            btnStation.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnUserData.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnFklim71Data.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnDatabase.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAbout.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);

            btnStation.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnUserData.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnFklim71Data.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnDatabase.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnAbout.BackColor = System.Drawing.Color.FromArgb(29, 35, 44);
            #endregion
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
