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
    public partial class dumbeller : Form
    {
        public dumbeller()
        {
            InitializeComponent();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            antrenmanlar ant = new antrenmanlar();
            ant.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dumbell dl = new dumbell();
            dl.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dumbell1 dl1 = new dumbell1();
            dl1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dumbell2 dl2 = new dumbell2();
            dl2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dumbell3 dl3 = new dumbell3();
            dl3.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dumbell4 dl4 = new dumbell4();
            dl4.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dumbell5 dl5 = new dumbell5();
            dl5.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            dumbell6 dl6 = new dumbell6();
            dl6.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            dumbell7 dl7 = new dumbell7();
            dl7.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            dumbell9 dl9 = new dumbell9();
            dl9.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            dumbell8 dl8 = new dumbell8();
            dl8.Show();
        }
    }
}
