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

namespace BMKG_DataSafe_2
{
    public partial class UCStasiun : UserControl
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

        private void UCStasiun_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 8, 8));
        }

        public UCStasiun()
        {
            InitializeComponent();
        }

        public UCStasiun(int id, string stasiun, int wmoid, string latitude, string longitude)
        {
            InitializeComponent();
            ID = id;
            Stasiun = stasiun;
            WmoId = wmoid;
            Latitude = latitude;
            Longitude = longitude;
        }

        public int ID { get; set; }

        public string Stasiun
        {
            get => lblStasiun.Text;
            set => lblStasiun.Text = value;
        }

        public int WmoId
        {
            get => int.Parse(lblWmoid.Text);
            set => lblWmoid.Text = value + "";
        }

        public string Latitude
        {
            get => lblLat.Text;
            set => lblLat.Text = value;
        }

        public string Longitude
        {
            get => lblLong.Text;
            set => lblLong.Text = value;
        }
    }
}
