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
using System.Globalization;

namespace BMKG_DataSafe_2
{
    public partial class UCOpen : UserControl
    {
        [DllImport("GDI32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse1
        );

        public UCOpen()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void UCOpen_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));

            //int[] w = { 2, 7, 11, 21, 42, 89, 180, 354 };
            //int q = 881;
            //int r = 588;

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

            dt.Columns.AddRange(new DataColumn[19] { new DataColumn("Tanggal", typeof(string)),
                new DataColumn("Suhu 07.00", typeof(int)),
                new DataColumn("Suhu 13.00", typeof(int)),
                new DataColumn("Suhu 14.00", typeof(int)),
                new DataColumn("Suhu 15.00", typeof(int)),
                new DataColumn("Suhu 16.00", typeof(int)),
                new DataColumn("Suhu 17.00", typeof(int)),
                new DataColumn("Suhu 18.00", typeof(int)),
                new DataColumn("Suhu 19.00", typeof(int)),
                new DataColumn("Suhu 10.00", typeof(int)),
                new DataColumn("Suhu 13.10", typeof(int)),
                new DataColumn("Suhu 13.20", typeof(int)),
                new DataColumn("Suhu 13.30", typeof(int)),
                new DataColumn("Suhu 13.40", typeof(int)),
                new DataColumn("Suhu 13.50", typeof(int)),
                new DataColumn("Suhu 13.60", typeof(int)),
                new DataColumn("Suhu 13.70", typeof(int)),
                new DataColumn("Suhu 13.80", typeof(int)),
                new DataColumn("Suhu 13.90", typeof(int)),
            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog='" + comboBox1.Text + "';Integrated Security=True");

            con4.Open();
            DataTable schema = con4.GetSchema("Tables");
            foreach (DataRow row in schema.Rows)
            {
                comboBox2.Items.Add(row[2].ToString());
            }
            con4.Close();
        }

        public void FillDataGridView()
        {
            SqlConnection con5 = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog='" + comboBox1.Text + "';Integrated Security=True");

            con5.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + comboBox2.Text, con5);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con5.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clearTextBox();

            int[] w = { 2, 7, 11, 21, 42, 89, 180, 354 };
            int q = 881;
            int r = 588;

            int baris = int.Parse(e.RowIndex.ToString());
            string tanggal = dataGridView1[0, baris].Value.ToString();
            string encoded1 = dataGridView1[1, baris].Value.ToString();
            string encoded2 = dataGridView1[2, baris].Value.ToString();
            string encoded3 = dataGridView1[3, baris].Value.ToString();
            string encoded4 = dataGridView1[4, baris].Value.ToString();
            string encoded5 = dataGridView1[5, baris].Value.ToString();
            string encoded6 = dataGridView1[6, baris].Value.ToString();
            string encoded7 = dataGridView1[7, baris].Value.ToString();
            string encoded8 = dataGridView1[8, baris].Value.ToString();
            string encoded9 = dataGridView1[9, baris].Value.ToString();
            string encoded10 = dataGridView1[10, baris].Value.ToString();
            string encoded11 = dataGridView1[11, baris].Value.ToString();
            string encoded12 = dataGridView1[12, baris].Value.ToString();
            string encoded13 = dataGridView1[13, baris].Value.ToString();
            string encoded14 = dataGridView1[14, baris].Value.ToString();
            string encoded15 = dataGridView1[15, baris].Value.ToString();
            string encoded16 = dataGridView1[16, baris].Value.ToString();
            string encoded17 = dataGridView1[17, baris].Value.ToString();
            string encoded18 = dataGridView1[18, baris].Value.ToString();

            //string s1 = "1;2;3;4;5;6;7;8;9;10;11;12";
            //int[] ia = s1.Split(';').Select(n => Convert.ToInt32(n)).ToArray();

            int[] encodeConvert1 = encoded1.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert2 = encoded2.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert3 = encoded3.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert4 = encoded4.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert5 = encoded5.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert6 = encoded6.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert7 = encoded7.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert8 = encoded8.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert9 = encoded9.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert10 = encoded10.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert11 = encoded11.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert12 = encoded12.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert13 = encoded13.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert14 = encoded14.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert15 = encoded15.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert16 = encoded16.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert17 = encoded17.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] encodeConvert18 = encoded18.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            //int tanggal1 = Int32.Parse(tanggal);
            //string output = Regex.Replace(input, @"[^\u0009\u000A\u000D\u0020-\u007E]", "*");
            string decoded1 = Decrypt1(encodeConvert1, w, q, r);
            string decoded2 = Decrypt2(encodeConvert2, w, q, r);
            string decoded3 = Decrypt3(encodeConvert3, w, q, r);
            string decoded4 = Decrypt4(encodeConvert4, w, q, r);
            string decoded5 = Decrypt5(encodeConvert5, w, q, r);
            string decoded6 = Decrypt6(encodeConvert6, w, q, r);
            string decoded7 = Decrypt7(encodeConvert7, w, q, r);
            string decoded8 = Decrypt8(encodeConvert8, w, q, r);
            string decoded9 = Decrypt9(encodeConvert9, w, q, r);
            string decoded10 = Decrypt10(encodeConvert10, w, q, r);
            string decoded11 = Decrypt11(encodeConvert11, w, q, r);
            string decoded12 = Decrypt12(encodeConvert12, w, q, r);
            string decoded13 = Decrypt13(encodeConvert13, w, q, r);
            string decoded14 = Decrypt14(encodeConvert14, w, q, r);
            string decoded15 = Decrypt15(encodeConvert15, w, q, r);
            string decoded16 = Decrypt16(encodeConvert16, w, q, r);
            string decoded17 = Decrypt17(encodeConvert17, w, q, r);
            string decoded18 = Decrypt18(encodeConvert18, w, q, r);

            //int decod = Int32.Parse(decoded1);

            //float value = float.Parse(mystring, CultureInfo.InvariantCulture.NumberFormat);

            //float decod1 = float.Parse(decoded1, CultureInfo.InvariantCulture.NumberFormat);

            //dt.Rows.Add(tanggal, decoded1); // decoded2, decoded3, decoded4, decoded5, decoded6, decoded7, decoded8, decoded9, decoded10, decoded11, decoded12, decoded13, decoded14, decoded15, decoded16, decoded17, decoded18);
            //this.dataGridView2.DataSource = dt;

            labelTanggal.Text = tanggal;
            textBox1.Text = decoded1;
            textBox2.Text = decoded2;
            textBox3.Text = decoded3;
            textBox4.Text = decoded4;
            textBox5.Text = decoded5;
            textBox6.Text = decoded6;
            textBox7.Text = decoded7;
            textBox8.Text = decoded8;
            textBox9.Text = decoded9;
            textBox10.Text = decoded10;
            textBox11.Text = decoded11;
            textBox12.Text = decoded12;
            textBox13.Text = decoded13;
            textBox14.Text = decoded14;
            textBox15.Text = decoded15;
            textBox16.Text = decoded16;
            textBox17.Text = decoded17;
            textBox18.Text = decoded18;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            //int[] w = { 2, 7, 11, 21, 42, 89, 180, 354 };
            //int q = 881;
            //int r = 588;

            //string decoded = Decrypt1(encoded1, w, q, r);

        }

        #region Dekripsi

        static string Decrypt1(int[] encoded1, int[] w, int q, int r)
        {
            if (encoded1 == null || encoded1.Length == 0) return null;
            char[] chars = new char[encoded1.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded1.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded1[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt2(int[] encoded2, int[] w, int q, int r)
        {
            if (encoded2 == null || encoded2.Length == 0) return null;
            char[] chars = new char[encoded2.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded2.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded2[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt3(int[] encoded3, int[] w, int q, int r)
        {
            if (encoded3 == null || encoded3.Length == 0) return null;
            char[] chars = new char[encoded3.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded3.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded3[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt4(int[] encoded4, int[] w, int q, int r)
        {
            if (encoded4 == null || encoded4.Length == 0) return null;
            char[] chars = new char[encoded4.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded4.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded4[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt5(int[] encoded5, int[] w, int q, int r)
        {
            if (encoded5 == null || encoded5.Length == 0) return null;
            char[] chars = new char[encoded5.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded5.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded5[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt6(int[] encoded6, int[] w, int q, int r)
        {
            if (encoded6 == null || encoded6.Length == 0) return null;
            char[] chars = new char[encoded6.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded6.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded6[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt7(int[] encoded7, int[] w, int q, int r)
        {
            if (encoded7 == null || encoded7.Length == 0) return null;
            char[] chars = new char[encoded7.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded7.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded7[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt8(int[] encoded8, int[] w, int q, int r)
        {
            if (encoded8 == null || encoded8.Length == 0) return null;
            char[] chars = new char[encoded8.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded8.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded8[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt9(int[] encoded9, int[] w, int q, int r)
        {
            if (encoded9 == null || encoded9.Length == 0) return null;
            char[] chars = new char[encoded9.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded9.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded9[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt10(int[] encoded10, int[] w, int q, int r)
        {
            if (encoded10 == null || encoded10.Length == 0) return null;
            char[] chars = new char[encoded10.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded10.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded10[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt11(int[] encoded11, int[] w, int q, int r)
        {
            if (encoded11 == null || encoded11.Length == 0) return null;
            char[] chars = new char[encoded11.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded11.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded11[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt12(int[] encoded12, int[] w, int q, int r)
        {
            if (encoded12 == null || encoded12.Length == 0) return null;
            char[] chars = new char[encoded12.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded12.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded12[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt13(int[] encoded13, int[] w, int q, int r)
        {
            if (encoded13 == null || encoded13.Length == 0) return null;
            char[] chars = new char[encoded13.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded13.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded13[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt14(int[] encoded14, int[] w, int q, int r)
        {
            if (encoded14 == null || encoded14.Length == 0) return null;
            char[] chars = new char[encoded14.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded14.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded14[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt15(int[] encoded15, int[] w, int q, int r)
        {
            if (encoded15 == null || encoded15.Length == 0) return null;
            char[] chars = new char[encoded15.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded15.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded15[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt16(int[] encoded16, int[] w, int q, int r)
        {
            if (encoded16 == null || encoded16.Length == 0) return null;
            char[] chars = new char[encoded16.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded16.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded16[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt17(int[] encoded17, int[] w, int q, int r)
        {
            if (encoded17 == null || encoded17.Length == 0) return null;
            char[] chars = new char[encoded17.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded17.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded17[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }

        static string Decrypt18(int[] encoded18, int[] w, int q, int r)
        {
            if (encoded18 == null || encoded18.Length == 0) return null;
            char[] chars = new char[encoded18.Length];
            int mir = ModInverse(r, q);
            if (mir == 0)
            {
                MessageBox.Show("Modular inverse does not exist. Decryption aborted");
                //Console.WriteLine("Modular inverse does not exist. Decryption aborted");
                return null;
            }

            for (int i = 0; i < encoded18.Length; i++)
            {
                char[] bin = new char[8];
                for (int j = 0; j < 8; j++) bin[j] = '0';
                int temp = encoded18[i] * mir % q;

                while (temp > 0)
                {
                    int index = 7;

                    for (int j = 1; j < w.Length; j++)
                    {
                        if (w[j] > temp)
                        {
                            index = j - 1;
                            break;
                        }
                    }

                    bin[index] = '1';
                    temp -= w[index];
                }

                chars[i] = ConvertFromBinary(new string(bin));
            }

            return new string(chars);
        }
        #endregion

        static char ConvertFromBinary(string bin)
        {
            return (char)Convert.ToInt32(bin, 2);
        }

        static int ModInverse(int r, int q)
        {
            int i = q, v = 0, d = 1;

            while (r > 0)
            {
                int t = i / r, x = r;
                r = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }

            v %= q;
            if (v < 0) v = (v + q) % q;
            return v;
        }

        void clearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dt.Rows.Add(tanggal, decoded1); // decoded2, decoded3, decoded4, decoded5, decoded6, decoded7, decoded8, decoded9, decoded10, decoded11, decoded12, decoded13, decoded14, decoded15, decoded16, decoded17, decoded18);
            //this.dataGridView2.DataSource = dt;

           

            dt.Rows.Add(labelTanggal.Text, textBox1.Text);
            this.dataGridView2.DataSource = dt;
        }
    }
}
