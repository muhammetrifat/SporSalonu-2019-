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
    public partial class demir : Form
    {
        public demir()
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

        private void demir_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.Visible = false;
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
            dumbell dl = new dumbell();
            dumbell1 dl1 = new dumbell1();
            dumbell2 dl2 = new dumbell2();
            dumbell3 dl3 = new dumbell3();
            dumbell4 dl4 = new dumbell4();
            dumbell5 dl5 = new dumbell5();
            dumbell6 dl6 = new dumbell6();
            dumbell7 dl7 = new dumbell7();
            dumbell8 dl8 = new dumbell8();
            dumbell9 dl9 = new dumbell9();
            saniye++;

            label1.Text = Convert.ToString(saniye);
            if (saniye == 1)
            {
                sn.Show();
            }

            else if (saniye == 300)
            {
                timer1.Stop();
                ks.Show();
                timer1.Start();
            }//KOŞU

            else if (saniye == 600)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 720)
            {
                timer1.Stop();
                dl.Show();
                timer1.Start();
            }//DUMBELL MODE 1

            else if (saniye == 1020)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 1140)
            {
                timer1.Stop();
                dl1.Show();
                timer1.Start();
            }//DUMBELL MODE 2

            else if (saniye == 1440)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 1560)
            {
                timer1.Stop();
                dl8.Show();
                timer1.Start();
            }//BENCHPRESS

            else if (saniye == 1620)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 1740)
            {
                timer1.Stop();
                sq.Show();
                timer1.Start();
            }//SQUAT

            else if (saniye == 1920)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 2040)
            {
                timer1.Stop();
                mk.Show();
                timer1.Start();
            }//MEKİK

            else if (saniye == 2340)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 2460)
            {
                timer1.Stop();
                mk.Show();
                timer1.Start();
            }//MEKİK

            else if (saniye == 2760)
            {
                timer1.Stop();
                sq.Show();
                timer1.Start();
            }//SQUAT

            else if (saniye == 2940)
            {
                demir dm = new demir();
                dm.Visible = true;
                checkBox1.Checked = true;
                this.Close();
            }
        }
    }
}
