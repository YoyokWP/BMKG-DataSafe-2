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
    public partial class UCStationData : UserControl
    {
        public UCStationData()
        {
            InitializeComponent();
        }

        SqlConnection con8 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=Stasiun;Integrated Security=True");
        SqlConnection con9 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=DataFKLIM71;Integrated Security=True");

        private void UCStationData_Load(object sender, EventArgs e)
        {
            FillDataGridView();

            cmd1 = new SqlCommand("select Count(*) from Daftar_Stasiun", con8);
            con8.Open();
            var Jumlah = cmd1.ExecuteScalar();
            labelJumlah.Text = Jumlah.ToString();
            con8.Close();
        }

        private SqlCommand cmd;
        private SqlCommand cmd1;
        private SqlCommand cmd2;

        private void buttonAddStation_Click(object sender, EventArgs e)
        {
            string namastasiun = textBoxStationName.Text.Replace(" ", "_");

            if(textBoxStationName.Text.Trim() == "" || textBoxWMOID.Text.Trim() == "" || textBoxLatitude.Text.Trim() == "" || textBoxLongitude.Text.Trim() == "")
            {
                MessageBox.Show("Data Input Not Completed");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("insert into Daftar_Stasiun (Nama_Stasiun,WMO_ID,Latitude,Longitude) values ('" + textBoxStationName.Text + "','" + textBoxWMOID.Text +"', '" + textBoxLatitude.Text + "','" + textBoxLongitude.Text + "')", con8);
                    con8.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successed Add New Station");
                    ClearTextBox();
                    con8.Close();

                    string sql = "CREATE TABLE "+ namastasiun +" (Tanggal date, Suhu_0700 varchar(50), Suhu_1300 varchar(50), Suhu_1800 varchar(50), Suhu_RataRata varchar(50), Suhu_Max varchar(50), Suhu_Min varchar(50), Curah_Hujan varchar(50), Penyinaran_Matahari varchar(50), Cuaca_Khusus varchar(50), Tekanan_Udara varchar(50), Kelembaban_0700 varchar(50), Kelembaban_1300 varchar(50), Kelembaban_1800 varchar(50), Kelembaban_RataRata varchar(50), Angin_RataRata varchar(50), Arah_Angin varchar(50), Kecepatan_Angin_Max varchar(50), Arah_Max varchar(50))";
                    con9.Open();
                    cmd2 = new SqlCommand(sql, con9);
                    cmd2.ExecuteNonQuery();
                    con9.Close();
                    

                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }
            }
        }

        public void FillDataGridView()
        {
            SqlConnection con5 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=Stasiun;Integrated Security=True");

            con5.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Daftar_Stasiun", con5);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con5.Close();
        }

        void ClearTextBox()
        {
            textBoxStationName.Text = "";
            textBoxWMOID.Text = "";
            textBoxLatitude.Text = "";
            textBoxLongitude.Text = "";
        }

        private void textBoxStationName_TextChanged(object sender, EventArgs e)
        {
            labelStationName.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
        }

        private void textBoxWMOID_TextChanged(object sender, EventArgs e)
        {
            labelWMOID.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
        }

        private void textBoxLatitude_TextChanged(object sender, EventArgs e)
        {
            labelLatitude.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
        }

        private void textBoxLongitude_TextChanged(object sender, EventArgs e)
        {
            labelLongitude.ForeColor = System.Drawing.Color.FromArgb(1, 247, 182);
        }
    }
}
