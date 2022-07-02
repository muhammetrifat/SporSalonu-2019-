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
    public partial class gelisimtakvimi : Form
    {
        public gelisimtakvimi()
        {
            InitializeComponent();
        }

        private void pictureBox31_Click(object sender, EventArgs e)//ocak
        {
            ocak oc = new ocak();
            oc.Show();
            this.Close();
        }

        private void pictureBox32_Click(object sender, EventArgs e)//şubat
        {
            subat sb = new subat();
            sb.Show();
            this.Close();
        }

        private void pictureBox33_Click(object sender, EventArgs e)//mart
        {
            mart mr = new mart();
            mr.Show();
            this.Close();
        }

        private void pictureBox34_Click(object sender, EventArgs e)//nisan
        {
            nisan ns = new nisan();
            ns.Show();
            this.Close();
        }

        private void pictureBox35_Click(object sender, EventArgs e)//mayıs
        {
            mayis ms = new mayis();
            ms.Show();
            this.Close();
        }

        private void pictureBox36_Click(object sender, EventArgs e)//haziran
        {
            haziran hz = new haziran();
            hz.Show();
            this.Close();
        }

        private void pictureBox37_Click(object sender, EventArgs e)//temmuz
        {
            temmuz tm = new temmuz();
            tm.Show();
            this.Close();
        }

        private void pictureBox38_Click(object sender, EventArgs e)//ağustos
        {
            agustos ag = new agustos();
            ag.Show();
            this.Close();
        }

        private void pictureBox39_Click(object sender, EventArgs e)//eylül
        {
            eylul ey = new eylul();
            ey.Show();
            this.Close();
        }

        private void pictureBox40_Click(object sender, EventArgs e)//ekim
        {
            ekim ek = new ekim();
            ek.Show();
            this.Close();
        }

        private void pictureBox41_Click(object sender, EventArgs e)//kasim
        {
            kasim ks = new kasim();
            ks.Show();
            this.Close();
        }

        private void pictureBox42_Click(object sender, EventArgs e)//aralik
        {
            aralik ar = new aralik();
            ar.Show();
            this.Close();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gelisim gl = new gelisim();
            gl.Show();
            this.Close();
        }
    }
}
