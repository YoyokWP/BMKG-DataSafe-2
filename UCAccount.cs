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
    public partial class UCAccount : UserControl
    {
        public UCAccount()
        {
            InitializeComponent();
        }

        private void UCAccount_Load(object sender, EventArgs e)
        {
            textBoxEmail.Text = FormLoginUser.SetValueForEmail;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=User;Integrated Security=True");

            string query = string.Empty;
            if (textBoxEmail.Text.Trim().Length > 0)
            {
                try
                {
                    con.Open();
                    query = "SELECT Nama,Asal_Stasiun FROM Daftar_User WHERE Email='" + textBoxEmail.Text + "'";
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataReader sdr = command.ExecuteReader();
                    
                    while (sdr.Read())
                    {
                        textBoxName.Text = sdr["Nama"].ToString();
                        textBoxStation.Text = sdr["Asal_Stasiun"].ToString();
                    }
                    sdr.Close();
                    con.Close();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //private void Search_button1_Click(object sender, EventArgs e)
        //{
        //    string query = string.Empty;
        //    if (ID_textBox1.Text.Trim().Length > 0)
        //    {
        //        try
        //        {
        //            query = "SELECT ProductName,ProductDescription,SellPrice FROM Table2 WHERE ProductID='" + ID_textBox1.Text + "'";
        //            SqlConnection Conn = CreateConnection.create_connection();
        //            SqlCommand cd = new SqlCommand(query, Conn);
        //            SqlDataReader reader = cd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                Name_textBox2.Text = reader["ProductName"].ToString();
        //                Description_textBox3.Text = reader["ProductDescription"].ToString();
        //                Unit_Price_textBox5.Text = reader["SellPrice"].ToString();
        //            }
        //            reader.Close();
        //            Name_textBox2.Text = Name_textBox2.Text;
        //            Description_textBox3.Text = Description_textBox3.Text;
        //            QTY_textBox4.Text = 1.ToString();
        //            Unit_Price_textBox5.Text = Unit_Price_textBox5.Text;
        //            Price_textBox6.Text = (decimal.Parse(QTY_textBox4.Text) * decimal.Parse(Unit_Price_textBox5.Text)).ToString();

        //        }

        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}


    }
}
