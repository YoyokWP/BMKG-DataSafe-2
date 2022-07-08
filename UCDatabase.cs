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
    public partial class UCDatabase : UserControl
    {
        public UCDatabase()
        {
            InitializeComponent();
        }

        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=DataFKLIM71;Integrated Security=True");
        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=Stasiun;Integrated Security=True");
        SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=User;Integrated Security=True");

        private void UCDatabase_Load(object sender, EventArgs e)
        {
            FillDataGridViewStasiun();
            FillDataGridViewUser();

            
            con1.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM sys.tables", con1);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Load(sdr);
            comboBoxStasiun.ValueMember = "name";
            comboBoxStasiun.DataSource = dt;
            con1.Close();

            SqlCommand cmd1 = new SqlCommand("select Count(*) from Daftar_Stasiun", con2);
            con2.Open();
            var Jumlah2 = cmd1.ExecuteScalar();
            labelJumlahStasiun.Text = Jumlah2.ToString();
            con2.Close();

            SqlCommand cmd2 = new SqlCommand("select Count(*) from Daftar_User", con3);
            con3.Open();
            var Jumlah3 = cmd2.ExecuteScalar();
            labelJumlahUser.Text = Jumlah3.ToString();
            con3.Close();
        }

        private void comboBoxStasiun_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGridViewDataFKLIM71();

            SqlCommand cmd = new SqlCommand("select Count(*) from " + comboBoxStasiun.Text, con1);
            con1.Open();
            var Jumlah1 = cmd.ExecuteScalar();
            labelJumlahDataFKLIM71.Text = Jumlah1.ToString();
            con1.Close();
        }

        public void FillDataGridViewDataFKLIM71()
        {
            //con1.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from " + comboBoxStasiun.Text, con1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewDataFKLIM71.DataSource = dt;
            con1.Close();
        }

        public void FillDataGridViewStasiun()
        {
            con2.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Daftar_Stasiun", con2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewStasiun.DataSource = dt;
            con2.Close();
        }

        public void FillDataGridViewUser()
        {
            con3.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Daftar_User", con3);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewUser.DataSource = dt;
            con3.Close();
        }
    }
}
