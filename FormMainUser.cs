﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BMKG_DataSafe_2
{
    public partial class FormMainUser : Form
    {
        public FormMainUser()
        {
            InitializeComponent();

            pictureBoxDashboard.Hide();
            pictureBoxAccount.Hide();
            pictureBoxAbout.Hide();

            labelWelcome.BringToFront();
            pictureBoxWelcome.BringToFront();
        }

        private void FormMainUser_Load(object sender, EventArgs e)
        {
            textBoxJam.Text = DateTime.Now.ToLongTimeString();
            textBoxTanggal.Text = DateTime.Now.ToLongDateString();
        }

        private void ucStasiun1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.Enabled = true;

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=datastasiun;Integrated Security=True");
                string sql = "select * from tabelstasiun";
                SqlCommand s = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader r = s.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();

                while (r.Read())
                {
                    int id = int.Parse(r[0] + "");
                    string stasiun = "" + r[1];
                    int wmoid = int.Parse(r[2] + "");
                    string latitude = "" + r[3];
                    string longitude = "" + r[4];

                    UCStasiun obj = new UCStasiun(id, stasiun, wmoid, latitude, longitude);

                    //if (flowLayoutPanel1.Controls.Count < 0)
                    //{
                    //    flowLayoutPanel1.Controls.Clear();
                    //}
                    //else
                    flowLayoutPanel1.Controls.Add(obj);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            labelWelcome.SendToBack();
            pictureBoxWelcome.SendToBack();

            #region Tampilan tombol
            pictureBoxDashboard.Show();
            pictureBoxAccount.Hide();
            pictureBoxAbout.Hide();

            btnDashboard.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
            btnAccount.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAbout.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(29, 35, 44);
            btnAccount.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnAbout.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            #endregion
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            UCAccount ucaccount = new UCAccount();

            btnAccount.Enabled = true;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(ucaccount);

            labelWelcome.SendToBack();
            pictureBoxWelcome.SendToBack();

            #region Tampilan tombol
            pictureBoxDashboard.Hide();
            pictureBoxAbout.Hide();
            pictureBoxAccount.Show();

            btnDashboard.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAccount.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
            btnAbout.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnAccount.BackColor = System.Drawing.Color.FromArgb(29, 35, 44);
            btnAbout.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            #endregion
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            UCAbout ucabout = new UCAbout();

            btnAbout.Enabled = true;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(ucabout);

            labelWelcome.SendToBack();
            pictureBoxWelcome.SendToBack();

            #region Tampilan tombol
            pictureBoxDashboard.Hide();
            pictureBoxAccount.Hide();
            pictureBoxAbout.Show();

            btnDashboard.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAccount.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAbout.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);

            btnDashboard.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnAccount.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            btnAbout.BackColor = System.Drawing.Color.FromArgb(29, 35, 44);
            #endregion
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}