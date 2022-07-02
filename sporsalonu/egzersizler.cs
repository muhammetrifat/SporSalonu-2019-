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
    public partial class egzersizler : Form
    {
        public egzersizler()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ogrsayfasi og = new ogrsayfasi();
            og.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hizliegzersiz heg = new hizliegzersiz();
            heg.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            antrenmanlar ant = new antrenmanlar();
            ant.Show();
            this.Close();
        }
    }
}
