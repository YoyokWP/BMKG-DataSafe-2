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
    public partial class UCDataFKLIM71 : UserControl
    {
        public UCDataFKLIM71()
        {
            InitializeComponent();
        }

        private void UCDataFKLIM71_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=DataFKLIM71;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT name FROM sys.tables", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Load(sdr);
            comboBoxStasiun.ValueMember = "name";
            comboBoxStasiun.DataSource = dt;
            con.Close();
        }

        private void comboBoxStasiun_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGridView();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=DataFKLIM71;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("select Count(*) from " + comboBoxStasiun.Text, con);
            con.Open();
            var Jumlah = cmd1.ExecuteScalar();
            labelJumlah.Text = Jumlah.ToString();
            con.Close();
        }

        public void FillDataGridView()
        {
            SqlConnection con5 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=DataFKLIM71;Integrated Security=True");

            con5.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from " + comboBoxStasiun.Text, con5);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con5.Close();
        }
    }
}
