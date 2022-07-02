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
    public partial class bahaneyok : Form
    {
        public bahaneyok()
        {
            InitializeComponent();
        }
        public static Boolean check;
        int saniye = 0;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            hizliegzersiz hz = new hizliegzersiz();
            hz.Show();
            this.Close();
        }//geributonu
        

        private void bahaneyok_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)//START
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
                bf.Show();
                timer1.Start();
            }//BARFİKS

            else if (saniye == 780)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 900)
            {
                timer1.Stop();
                bf.Show();
                timer1.Start();
            }//BARFİKS

            else if (saniye == 960)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 1020)
            {
                timer1.Stop();
                snv.Show();
                timer1.Start();
            }//ŞINAV

            else if (saniye == 1320)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 1440)
            {
                timer1.Stop();
                sq.Show();
                timer1.Start();
            }//SQUAT

            else if (saniye == 1620)
            {
                timer1.Stop();
                dn.Show();
                timer1.Start();
            }//DİNLENME

            else if (saniye == 1740)
            {
                timer1.Stop();
                ip.Show();
                timer1.Start();
            }//İPATLAMA

            else if (saniye == 2040)
            {
                timer1.Stop();
                mk.Show();
                timer1.Start();
            }//MEKİK

            else if (saniye == 2340)
            {
                bahaneyok bh = new bahaneyok();
                bh.Visible = true;
                checkBox1.Checked = true;
                this.Close();
            }
        }
    }
}
