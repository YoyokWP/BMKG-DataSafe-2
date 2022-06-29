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
            int nHeightEllipse
        );

        public UCOpen()
        {
            InitializeComponent();
        }

        private void UCOpen_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));

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
    }
}
