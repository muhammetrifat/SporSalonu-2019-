using System;
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
    public partial class tarihselgelisim : Form
    {
        public tarihselgelisim()
        {
            InitializeComponent();
        }
        public static string gon1, gon2, gon3, gon4, gon5, gon6, gon7, gon8, gon9, gon10;
        private void tarihselgelisim_Load(object sender, EventArgs e)
        {
            label9.Text = gon1;
            label18.Text = gon2;
            label17.Text = gon3;
            label10.Text = gon4;
            label11.Text = gon5;
            label12.Text = gon6;
            label13.Text = gon7;
            label14.Text = gon8;
            label15.Text = gon9;
            label16.Text = gon10;
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            gelisimtakvimi gt = new gelisimtakvimi();
            gt.Show();
            this.Close();
        }
    }
}
