using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMKG_DataSafe_2
{
    public partial class UCStationData : UserControl
    {
        public UCStationData()
        {
            InitializeComponent();
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
