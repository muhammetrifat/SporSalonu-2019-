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
    public partial class antrenmanlar : Form
    {
        public antrenmanlar()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            egzersizler eg = new egzersizler();
            eg.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sinavv snv = new sinavv();
            snv.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mekik mk = new mekik();
            mk.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            barfiks bf = new barfiks();
            bf.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            squat sq = new squat();
            sq.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ipatlama ip = new ipatlama();
            ip.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dumbeller dller = new dumbeller();
            dller.Show();
        }
    }
}
