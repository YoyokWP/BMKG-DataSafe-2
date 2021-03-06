using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace BMKG_DataSafe_2
{
    public partial class FormLoginUser : Form
    {
        string randomNumber;

        public FormLoginUser()
        {
            InitializeComponent();
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=User;Integrated Security=True");
            string query = "Select * from Daftar_User where Email = '" + textEmail.Text.Trim() + "' and Password = '" + textPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Random rnd = new Random();
                randomNumber = (rnd.Next(100000, 999999)).ToString();

                string to, from, pass, mail;
                to = (textEmail.Text).ToString();
                from = "bmkgdatasafe@gmail.com";
                mail = "Hey " + to + " your verification code for BMKG DataSafe is " + randomNumber + ". Don't share this code to anyone";
                pass = "oguruyuirhrwvbtm";

                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = "Kode Verifikasi BMKG DataSafe";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Verification Code Send Succesfully, Check Your Email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonVerify.Text = "Verified";
                    buttonVerify.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Masukkan username dan password dengan benar");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textVerification.Text == randomNumber)
            {
                SetValueForEmail = textEmail.Text;
                FormMainUser formMainUser = new FormMainUser();
                formMainUser.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your Verification Code is Wrong");
            }
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void textVerification_TextChanged(object sender, EventArgs e)
        {
            label6.Hide();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Call Administrator bmkgdatasafe@gmail.com");
        }

        public static string SetValueForEmail = "";
    }
}
