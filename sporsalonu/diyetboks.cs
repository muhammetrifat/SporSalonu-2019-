﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sporsalonu
{
    public partial class diyetboks : Form
    {
        public diyetboks()
        {
            InitializeComponent();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ogrsayfasi ogr = new ogrsayfasi();
            ogr.Show();
            this.Close();
        }
    }
}
