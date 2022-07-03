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

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            SqlConnection con7 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog='" + comboBox1.Text + "';Integrated Security=True");

            #region Definisi Enkripsi
            int[] w = { 2, 7, 11, 21, 42, 89, 180, 354 };
            int q = 881;
            int r = 588;
            int[] beta = GetPublicKey(w, q, r);

            string plainText1 = textBoxSuhu07.Text;
            string plainText2 = textBoxSuhu13.Text;
            string plainText3 = textBoxSuhu18.Text;
            string plainText4 = textBoxSuhuRata.Text;
            string plainText5 = textBoxSuhuMax.Text;
            string plainText6 = textBoxSuhuMin.Text;
            string plainText7 = textBoxHujan.Text;
            string plainText8 = textBoxMatahari.Text;
            string plainText9 = textBoxCuacaKhusus.Text;
            string plainText10 = textBoxTekanan.Text;
            string plainText11 = textBoxKelembaban07.Text;
            string plainText12 = textBoxKelembaban13.Text;
            string plainText13 = textBoxKelembaban18.Text;
            string plainText14 = textBoxKelembabanRata.Text;
            string plainText15 = textBoxKecepatanAnginRata.Text;
            string plainText16 = textBoxArahAngin.Text;
            string plainText17 = textBoxKecepatanMax.Text;
            string plainText18 = textBoxArahMax.Text;

            int[] encoded1 = Encrypt1(plainText1, beta);
            int[] encoded2 = Encrypt2(plainText2, beta);
            int[] encoded3 = Encrypt3(plainText3, beta);
            int[] encoded4 = Encrypt4(plainText4, beta);
            int[] encoded5 = Encrypt5(plainText5, beta);
            int[] encoded6 = Encrypt6(plainText6, beta);
            int[] encoded7 = Encrypt7(plainText7, beta);
            int[] encoded8 = Encrypt8(plainText8, beta);
            int[] encoded9 = Encrypt9(plainText9, beta);
            int[] encoded10 = Encrypt10(plainText10, beta);
            int[] encoded11 = Encrypt11(plainText11, beta);
            int[] encoded12 = Encrypt12(plainText12, beta);
            int[] encoded13 = Encrypt13(plainText13, beta);
            int[] encoded14 = Encrypt14(plainText14, beta);
            int[] encoded15 = Encrypt15(plainText15, beta);
            int[] encoded16 = Encrypt16(plainText16, beta);
            int[] encoded17 = Encrypt17(plainText17, beta);
            int[] encoded18 = Encrypt18(plainText18, beta);

            string enkripsi1 = string.Join(" ", encoded1);
            string enkripsi2 = string.Join(" ", encoded2);
            string enkripsi3 = string.Join(" ", encoded3);
            string enkripsi4 = string.Join(" ", encoded4);
            string enkripsi5 = string.Join(" ", encoded5);
            string enkripsi6 = string.Join(" ", encoded6);
            string enkripsi7 = string.Join(" ", encoded7);
            string enkripsi8 = string.Join(" ", encoded8);
            string enkripsi9 = string.Join(" ", encoded9);
            string enkripsi10 = string.Join(" ", encoded10);
            string enkripsi11 = string.Join(" ", encoded11);
            string enkripsi12 = string.Join(" ", encoded12);
            string enkripsi13 = string.Join(" ", encoded13);
            string enkripsi14 = string.Join(" ", encoded14);
            string enkripsi15 = string.Join(" ", encoded15);
            string enkripsi16 = string.Join(" ", encoded16);
            string enkripsi17 = string.Join(" ", encoded17);
            string enkripsi18 = string.Join(" ", encoded18);
            #endregion

            if (textBoxSuhu07.Text.Trim() == "" || textBoxSuhu13.Text.Trim() == "" || textBoxSuhu18.Text.Trim() == "" || textBoxSuhuRata.Text.Trim() == "" || textBoxSuhuMax.Text.Trim() == "" || textBoxSuhuMin.Text.Trim() == "" || textBoxHujan.Text.Trim() == "" || textBoxMatahari.Text.Trim() == "" || textBoxCuacaKhusus.Text.Trim() == "" || textBoxTekanan.Text.Trim() == "" || textBoxKelembaban07.Text.Trim() == "" || textBoxKelembaban13.Text.Trim() == "" || textBoxKelembaban18.Text.Trim() == "" || textBoxKelembabanRata.Text.Trim() == "" || textBoxKecepatanAnginRata.Text.Trim() == "" || textBoxArahAngin.Text.Trim() == "" || textBoxKecepatanMax.Text.Trim() == "" || textBoxArahMax.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap !");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("insert into " + comboBox2.Text + "(Tanggal,Suhu_0700,Suhu_1300,Suhu_1800,Suhu_RataRata,Suhu_Max,Suhu_Min,Curah_Hujan,Penyinaran_Matahari,Cuaca_Khusus,Tekanan_Udara,Kelembaban_0700,Kelembaban_1300,Kelembaban_1800,Kelembaban_RataRata,Angin_RataRata,Arah_Angin,Kecepatan_Angin_Max,Arah_Max) values ('" + this.dateTimePicker1.Text + "','" + enkripsi1 + "','" + enkripsi2 + "','" + enkripsi3 + "','" + enkripsi4 + "','" + enkripsi5 + "','" + enkripsi6 + "','" + enkripsi7 + "','" + enkripsi8 + "','" + enkripsi9 + "','" + enkripsi10 + "','" + enkripsi11 + "','" + enkripsi12 + "','" + enkripsi13 + "','" + enkripsi14 + "','" + enkripsi15 + "','" + enkripsi16 + "','" + enkripsi17 + "','" + enkripsi18 + "')", con7);
                    con7.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Enkripsi Berhasil");
                    BersihkanTextBox();
                    con7.Close();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }
            }
        }

        #region Enkripsi
        static int[] Encrypt1(string plainText1, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText1)) return null;
            int[] encoded1 = new int[plainText1.Length];

            for (int i = 0; i < encoded1.Length; i++)
            {
                string bin = ConvertToBinary(plainText1[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded1[i] = sum;
            }
            return encoded1;
        }

        static int[] Encrypt2(string plainText2, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText2)) return null;
            int[] encoded2 = new int[plainText2.Length];

            for (int i = 0; i < encoded2.Length; i++)
            {
                string bin = ConvertToBinary(plainText2[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded2[i] = sum;
            }
            return encoded2;
        }

        static int[] Encrypt3(string plainText3, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText3)) return null;
            int[] encoded3 = new int[plainText3.Length];

            for (int i = 0; i < encoded3.Length; i++)
            {
                string bin = ConvertToBinary(plainText3[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded3[i] = sum;
            }
            return encoded3;
        }

        static int[] Encrypt4(string plainText4, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText4)) return null;
            int[] encoded4 = new int[plainText4.Length];

            for (int i = 0; i < encoded4.Length; i++)
            {
                string bin = ConvertToBinary(plainText4[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded4[i] = sum;
            }
            return encoded4;
        }

        static int[] Encrypt5(string plainText5, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText5)) return null;
            int[] encoded5 = new int[plainText5.Length];

            for (int i = 0; i < encoded5.Length; i++)
            {
                string bin = ConvertToBinary(plainText5[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded5[i] = sum;
            }
            return encoded5;
        }

        static int[] Encrypt6(string plainText6, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText6)) return null;
            int[] encoded6 = new int[plainText6.Length];

            for (int i = 0; i < encoded6.Length; i++)
            {
                string bin = ConvertToBinary(plainText6[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded6[i] = sum;
            }
            return encoded6;
        }

        static int[] Encrypt7(string plainText7, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText7)) return null;
            int[] encoded7 = new int[plainText7.Length];

            for (int i = 0; i < encoded7.Length; i++)
            {
                string bin = ConvertToBinary(plainText7[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded7[i] = sum;
            }
            return encoded7;
        }

        static int[] Encrypt8(string plainText8, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText8)) return null;
            int[] encoded8 = new int[plainText8.Length];

            for (int i = 0; i < encoded8.Length; i++)
            {
                string bin = ConvertToBinary(plainText8[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded8[i] = sum;
            }
            return encoded8;
        }

        static int[] Encrypt9(string plainText9, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText9)) return null;
            int[] encoded9 = new int[plainText9.Length];

            for (int i = 0; i < encoded9.Length; i++)
            {
                string bin = ConvertToBinary(plainText9[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded9[i] = sum;
            }
            return encoded9;
        }

        static int[] Encrypt10(string plainText10, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText10)) return null;
            int[] encoded10 = new int[plainText10.Length];

            for (int i = 0; i < encoded10.Length; i++)
            {
                string bin = ConvertToBinary(plainText10[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded10[i] = sum;
            }
            return encoded10;
        }

        static int[] Encrypt11(string plainText11, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText11)) return null;
            int[] encoded11 = new int[plainText11.Length];

            for (int i = 0; i < encoded11.Length; i++)
            {
                string bin = ConvertToBinary(plainText11[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded11[i] = sum;
            }
            return encoded11;
        }

        static int[] Encrypt12(string plainText12, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText12)) return null;
            int[] encoded12 = new int[plainText12.Length];

            for (int i = 0; i < encoded12.Length; i++)
            {
                string bin = ConvertToBinary(plainText12[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded12[i] = sum;
            }
            return encoded12;
        }

        static int[] Encrypt13(string plainText13, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText13)) return null;
            int[] encoded13 = new int[plainText13.Length];

            for (int i = 0; i < encoded13.Length; i++)
            {
                string bin = ConvertToBinary(plainText13[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded13[i] = sum;
            }
            return encoded13;
        }

        static int[] Encrypt14(string plainText14, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText14)) return null;
            int[] encoded14 = new int[plainText14.Length];

            for (int i = 0; i < encoded14.Length; i++)
            {
                string bin = ConvertToBinary(plainText14[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded14[i] = sum;
            }
            return encoded14;
        }

        static int[] Encrypt15(string plainText15, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText15)) return null;
            int[] encoded15 = new int[plainText15.Length];

            for (int i = 0; i < encoded15.Length; i++)
            {
                string bin = ConvertToBinary(plainText15[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded15[i] = sum;
            }
            return encoded15;
        }

        static int[] Encrypt16(string plainText16, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText16)) return null;
            int[] encoded16 = new int[plainText16.Length];

            for (int i = 0; i < encoded16.Length; i++)
            {
                string bin = ConvertToBinary(plainText16[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded16[i] = sum;
            }
            return encoded16;
        }

        static int[] Encrypt17(string plainText17, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText17)) return null;
            int[] encoded17 = new int[plainText17.Length];

            for (int i = 0; i < encoded17.Length; i++)
            {
                string bin = ConvertToBinary(plainText17[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded17[i] = sum;
            }
            return encoded17;
        }

        static int[] Encrypt18(string plainText18, int[] beta)
        {
            if (string.IsNullOrEmpty(plainText18)) return null;
            int[] encoded18 = new int[plainText18.Length];

            for (int i = 0; i < encoded18.Length; i++)
            {
                string bin = ConvertToBinary(plainText18[i]);
                int sum = 0;
                for (int j = 0; j < 8; j++) sum += (bin[j] - 48) * beta[j];
                encoded18[i] = sum;
            }
            return encoded18;
        }

        static string ConvertToBinary(char c)
        {
            return Convert.ToString((int)c, 2).PadLeft(8, '0');
        }

        static int[] GetPublicKey(int[] w, int q, int r)
        {
            int[] beta = new int[w.Length];
            for (int i = 0; i < w.Length; i++) beta[i] = w[i] * r % q;
            return beta;
        }
        #endregion
    }
}
