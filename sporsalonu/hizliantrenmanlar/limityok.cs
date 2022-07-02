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
    public partial class limityok : Form
    {
        public limityok()
        {
            InitializeComponent();
        }
        int saniye = 0;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            hizliegzersiz hz = new hizliegzersiz();
            hz.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.Visible = false;
        }

        private void limityok_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dinlenme dn = new dinlenme();
            kosu ks = new kosu();
            sinav sn = new sinav();
            barfiks bf = new barfiks();
            sinavv snv = new sinavv();
            squat sq = new squat();
            mekik mk = new mekik();
            ipatlama ip = new ipatlama();
            saniye++;

            label1.Text = Convert.ToString(saniye);
            if (saniye == 1)
            {
                sn.Show();
            }

            else if (saniye == 300)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 420)
            {
                timer1.Stop();
                ks.Show();
                timer1.Start();
            }//KOŞU

            else if (saniye == 720)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 840)
            {
                timer1.Stop();
                bf.Show();
                timer1.Start();
            }//BARFİKS

            else if (saniye == 900)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 1020)
            {
                timer1.Stop();
                bf.Show();
                timer1.Start();
            }//BARFİKS

            else if (saniye == 1080)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 1200)
            {
                timer1.Stop();
                sq.Show();
                timer1.Start();
            }//SQUAT

            else if (saniye == 1380)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 1500)
            {
                timer1.Stop();
                ip.Show();
                timer1.Start();
            }//İPATLAMA

            else if (saniye == 1800)
            {
                timer1.Stop();
                mk.Show();
                timer1.Start();
            }//MEKİK
            
            else if (saniye == 2100)
            {
                limityok lmt = new limityok();
                lmt.Visible = true;
                checkBox1.Checked = true;
                this.Close();
            }
        }
    }
}
