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
    public partial class hocasayfasi : Form
    {
        public hocasayfasi()
        {
            InitializeComponent();
        }

        private void hocasayfasi_Load(object sender, EventArgs e)
        {
            label2.Text = giris.adsoyad;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ogrenciverigirisi ogr = new ogrenciverigirisi();
            ogr.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            giris gr = new giris();
            gr.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ogrenciler ogr = new ogrenciler();
            ogr.Show();
            this.Close();
        }
    }
}
