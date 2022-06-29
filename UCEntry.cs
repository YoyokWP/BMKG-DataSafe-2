using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace BMKG_DataSafe_2
{
    public partial class UCEntry : UserControl
    {
        [DllImport("GDI32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public UCEntry()
        {
            InitializeComponent();
        }

        void BersihkanTextBox()
        {
            textBoxSuhu07.Text = "";
            textBoxSuhu13.Text = "";
            textBoxSuhu18.Text = "";
            textBoxSuhuRata.Text = "";
            textBoxSuhuMax.Text = "";
            textBoxSuhuMin.Text = "";
            textBoxHujan.Text = "";
            textBoxMatahari.Text = "";
            textBoxCuacaKhusus.Text = "";
            textBoxTekanan.Text = "";
            textBoxKelembaban07.Text = "";
            textBoxKelembaban13.Text = "";
            textBoxKelembaban18.Text = "";
            textBoxKelembabanRata.Text = "";
            textBoxKecepatanAnginRata.Text = "";
            textBoxArahAngin.Text = "";
            textBoxKecepatanMax.Text = "";
            textBoxArahMax.Text = "";
        }

        private void UCEntry_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));

            BersihkanTextBox();

            SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Integrated Security=True");
            con3.Open();
            var command = new System.Data.SqlClient.SqlCommand();
            command.Connection = con3;
            command.CommandType = CommandType.Text;
            command.CommandText = "select name from master.sys.databases";

            var adapter = new System.Data.SqlClient.SqlDataAdapter(command);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            DataTable dtDatabases = dataset.Tables[0];

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                con3.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog='"+comboBox1.Text+"';Integrated Security=True");

            con4.Open();
            DataTable schema = con4.GetSchema("Tables");
            foreach (DataRow row in schema.Rows)
            {
                comboBox2.Items.Add(row[2].ToString());
            }
            con4.Close();
        }

        private SqlCommand cmd;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection con7 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog='" + comboBox1.Text + "';Integrated Security=True");

            if (textBoxSuhu07.Text.Trim() == "" || textBoxSuhu13.Text.Trim() == "" || textBoxSuhu18.Text.Trim() == "" || textBoxSuhuRata.Text.Trim() == "" || textBoxSuhuMax.Text.Trim() == "" || textBoxSuhuMin.Text.Trim() == "" || textBoxHujan.Text.Trim() == "" || textBoxMatahari.Text.Trim() == "" || textBoxCuacaKhusus.Text.Trim() == "" || textBoxTekanan.Text.Trim() == "" || textBoxKelembaban07.Text.Trim() == "" || textBoxKelembaban13.Text.Trim() == "" || textBoxKelembaban18.Text.Trim() == "" || textBoxKelembabanRata.Text.Trim() == "" || textBoxKecepatanAnginRata.Text.Trim() == "" || textBoxArahAngin.Text.Trim() == "" || textBoxKecepatanMax.Text.Trim() == "" || textBoxArahMax.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap !");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("insert into " + comboBox2.Text + "(Tanggal,Suhu_0700,Suhu_1300,Suhu_1800,Suhu_RataRata,Suhu_Max,Suhu_Min,Curah_Hujan,Penyinaran_Matahari,Cuaca_Khusus,Tekanan_Udara,Kelembaban_0700,Kelembaban_1300,Kelembaban_1800,Kelembaban_RataRata,Angin_RataRata,Arah_Angin,Kecepatan_Angin_Max,Arah_Max) values ('" + this.dateTimePicker1.Text + "','" + textBoxSuhu07.Text + "','" + textBoxSuhu13.Text + "','" + textBoxSuhu18.Text + "','" + textBoxSuhuRata.Text + "','" + textBoxSuhuMax.Text + "','" + textBoxSuhuMin.Text + "','" + textBoxHujan.Text + "','" + textBoxMatahari.Text + "','" + textBoxCuacaKhusus.Text + "','" + textBoxTekanan.Text + "','" + textBoxKelembaban07.Text + "','" + textBoxKelembaban13.Text + "','" + textBoxKelembaban18.Text + "','" + textBoxKelembabanRata.Text + "','" + textBoxKecepatanAnginRata.Text + "','" + textBoxArahAngin.Text + "','" + textBoxKecepatanMax.Text + "','" + textBoxArahMax.Text + "')", con7);
                    con7.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Input Data Berhasil");
                    BersihkanTextBox();
                    con7.Close();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }
            }
        }
    }
}
