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

namespace BMKG_DataSafe_2
{
    public partial class UCUserData : UserControl
    {
        public UCUserData()
        {
            InitializeComponent();
        }

        private void UCUserData_Load(object sender, EventArgs e)
        {
            FillDataGridView();

            SqlConnection con9 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=Stasiun;Integrated Security=True");
            SqlCommand command = new SqlCommand("select Nama_Stasiun from Daftar_Stasiun", con9);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            comboBoxStation.DataSource = table;
            comboBoxStation.DisplayMember = "Nama_Stasiun";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=User;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("select Count(*) from Daftar_User", con);
            con.Open();
            var Jumlah = cmd1.ExecuteScalar();
            labelJumlah.Text = Jumlah.ToString();
            con.Close();
        }

        public void FillDataGridView()
        {
            SqlConnection con5 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=User;Integrated Security=True");

            con5.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Daftar_User", con5);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con5.Close();
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

        private SqlCommand cmd;

        private void buttonAddDatabase_Click(object sender, EventArgs e)
        {
            string Password, Verify;
            Password = textBoxPassword.Text;
            Verify = textBoxVerifyPassword.Text;

            if (textBoxFullName.Text.Trim() == "" || textBoxEmail.Text.Trim() == "" || textBoxPassword.Text.Trim() == "" || comboBoxGender.Text.Trim() == "")
            {
                MessageBox.Show("Data Input Not Completed");
            }
            else
            {
                if (Verify == Password)
                {
                    try
                    {
                        SqlConnection con8 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=User;Integrated Security=True");

                        cmd = new SqlCommand("insert into Daftar_User (Nama,Email,Gender,Asal_Stasiun,Password) values ('" + textBoxFullName.Text + "','" + textBoxEmail.Text + "','" + comboBoxGender.Text + "','" + comboBoxStation.Text + "','" + textBoxPassword.Text + "')", con8);
                        con8.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Successed Add New User");
                        ClearTextBox();
                        con8.Close();
                    }
                    catch (Exception G)
                    {
                        MessageBox.Show(G.ToString());
                    }
                }
            }
            FillDataGridView();
        }

        void ClearTextBox()
        {
            textBoxFullName.Text = "";
            textBoxEmail.Text = "";
            comboBoxGender.Controls.Clear();
            comboBoxStation.Controls.Clear();
            textBoxPassword.Text = "";
            textBoxVerifyPassword.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
