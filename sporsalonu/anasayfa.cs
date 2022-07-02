using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sporsalonu
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        
        
        private void Button1_Click_1(object sender, EventArgs e)
        {
            yenikayit form2sec = new yenikayit();
            form2sec.Show();
            this.Hide();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            kayitliuyeler f2 = new kayitliuyeler();
            f2.ShowDialog();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            uyearama uyearama = new uyearama();
            uyearama.Show();    
            this.Hide();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToLongDateString();
            label2.Text = dt.ToLongTimeString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            giris girissec = new giris();
            girissec.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            salonlar salonlar = new salonlar();
            salonlar.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            hakkımızda hakkımızda = new hakkımızda();
            hakkımızda.Show();
            this.Hide();
        }
    }
}
