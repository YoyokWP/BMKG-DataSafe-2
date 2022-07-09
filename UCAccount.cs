﻿using System;
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
    public partial class UCAccount : UserControl
    {
        public UCAccount()
        {
            InitializeComponent();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLoginUser formLoginUser = new FormLoginUser();
            FormMainUser formMainUser = new FormMainUser();
            formLoginUser.Show();
            formMainUser.Close();
            this.Hide();
        }
    }
}
