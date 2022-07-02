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
    public partial class salonlar : Form
    {
        public salonlar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfasec = new anasayfa();
            anasayfasec.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            istanbul istanbul = new istanbul();
            istanbul.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bursa bursa = new bursa();
            bursa.Show();
            this.Hide();
        }
    }
}
