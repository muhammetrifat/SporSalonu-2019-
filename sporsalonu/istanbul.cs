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
    public partial class istanbul : Form
    {
        public istanbul()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salonlar salonlar = new salonlar();
            salonlar.Show();
            this.Hide();
        }
    }
}
