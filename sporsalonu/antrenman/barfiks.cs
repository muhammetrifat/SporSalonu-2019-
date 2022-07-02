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
    public partial class barfiks : Form
    {
        public barfiks()
        {
            InitializeComponent();
        }
        int saniye = 0, salise = 0, dakika = 0;
        private void barfiks_Load(object sender, EventArgs e)
        {
            label2.Text = "BARFİKS";
            timer1.Interval = 100;
            timer2.Interval = 10;
            timer1.Start();
            timer2.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bahaneyok bh = new bahaneyok();
            demir dm = new demir();
            fit ft = new fit();
            incel inc = new incel();
            limityok lmt = new limityok();
            sikilas sk = new sikilas();

            egzersizler eg = new egzersizler();
            eg.Show();
            this.Close();
            bh.Close();
            dm.Close();
            ft.Close();
            inc.Close();
            lmt.Close();
            sk.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = Convert.ToString(saniye);

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
                label5.Text = Convert.ToString(dakika);

            }
            else if (dakika == 1 && saniye == 1)
            {
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (salise == 100)
            {
                salise = 0;
            }
            label3.Text = Convert.ToString(salise);
            salise++;
        }
    }
}
