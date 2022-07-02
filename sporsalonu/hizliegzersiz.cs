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
    public partial class hizliegzersiz : Form
    {
        public hizliegzersiz()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            egzersizler eg = new egzersizler();
            eg.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bahaneyok bh = new bahaneyok();
            bh.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fit ft = new fit();
            ft.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sikilas sk = new sikilas();
            sk.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            demir dr = new demir();
            dr.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            incel i = new incel();
            i.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            limityok lt = new limityok();
            lt.Show();
            this.Close();
        }
    }
}
