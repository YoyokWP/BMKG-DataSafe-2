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
    public partial class UCFKLIM71Data : UserControl
    {
        public UCFKLIM71Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
                /*creating or openning database*/
            con = new SqlConnection(@"Data Source=DESKTOP-1UAI1DD\SQLEXPRESS;Initial Catalog=1;Integrated Security=True");

            string sql = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Student1') 
                            CREATE TABLE [dbo].[Student1](
	                        [id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                        [FirstName] [nchar](10) NULL,
	                        [LastName] [nchar](10) NULL,
                            )";
            con.Open(); // AND xtype='U'
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
