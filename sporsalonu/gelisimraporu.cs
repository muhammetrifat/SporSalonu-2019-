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
using System.IO;

namespace sporsalonu
{
    public partial class gelisimraporu : Form
    {
        public gelisimraporu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void gelisimraporu_Load(object sender, EventArgs e)
        {
            textBox1.Text = giris.id;
            DataSet ds = new DataSet();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From " + giris.tckno + "", baglanti);
            adtr.Fill(ds, "" + giris.tckno + "");
            dataGridView1.DataSource = ds.Tables["" + giris.tckno + ""];
            baglanti.Close();

            baglanti.Open();
            OleDbDataAdapter adtr1 = new OleDbDataAdapter("Select * From uye", baglanti);
            adtr1.Fill(ds, "uye");
            dataGridView2.DataSource = ds.Tables["uye"];
            baglanti.Close();

            DateTime dt = DateTime.Now;
            label2.Text = dt.ToLongDateString();
            label3.Text = dt.ToLongTimeString();

            int rowindex = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                if (row.Cells["id"].Value.ToString() == textBox1.Text)
                {
                    rowindex = row.Index;
                    break;
                }
            }


            label51.Text = dataGridView1.Rows[0].Cells[12].Value.ToString();
            label52.Text = dataGridView2.Rows[rowindex].Cells[3].Value.ToString();
            label54.Text = dataGridView2.Rows[rowindex].Cells[14].Value.ToString();
            label53.Text = gelisim.akboy;
            label57.Text = gelisim.akkilo;
            label56.Text = gelisim.akkitindex;
            label55.Text = gelisim.akbazalmet;
            label62.Text = gelisim.akyagorani;

            double z1 = (Convert.ToDouble(label57.Text) * Convert.ToDouble(label62.Text) / 100);
            label61.Text = z1.ToString();

            double z2 = Convert.ToDouble(label57.Text) - Convert.ToDouble(label61.Text);
            label60.Text = z2.ToString();

            label59.Text = gelisim.aksuorani;

            label64.Text = "20% -- 30%";

            double z3 = (Convert.ToDouble(label57.Text) * 17.14 / 100);
            label63.Text = z1.ToString();

            double z4 = (Convert.ToDouble(label57.Text) * 30 / 100);
            label58.Text = z4.ToString();

            double z5 = (Convert.ToDouble(label69.Text) * 41 / 100);
            label68.Text = z5.ToString();

            double z6 = (Convert.ToDouble(label69.Text) * 40.5 / 100);
            label67.Text = z6.ToString();

            double z7 = (Convert.ToDouble(label69.Text) * 55.2 / 100);
            label66.Text = z7.ToString();

            double z8 = (Convert.ToDouble(label69.Text) * 55.4 / 100);
            label65.Text = z8.ToString();

            //SAĞAYAK
            double z9 = (Convert.ToDouble(label62.Text) + (Convert.ToDouble(label62.Text) * 21 / 100));
            label73.Text = z9.ToString();

            double z10 = (Convert.ToDouble(label61.Text) * 21.4 / 100);
            label72.Text = z10.ToString();

            double z12 = (Convert.ToDouble(label60.Text) * 16.2 / 100);
            label70.Text = z12.ToString();

            double z11 = (Convert.ToDouble(label60.Text) * 15.2 / 100);
            label71.Text = z11.ToString();

            //SOLAYAK
            double z13 = (Convert.ToDouble(label62.Text) + (Convert.ToDouble(label62.Text) * 20 / 100));
            label77.Text = z13.ToString();

            double z14 = (Convert.ToDouble(label61.Text) * 21.1 / 100);
            label76.Text = z14.ToString();

            double z16 = (Convert.ToDouble(label60.Text) * 16.1 / 100);
            label75.Text = z16.ToString();

            double z15 = (Convert.ToDouble(label60.Text) * 14.9 / 100);
            label74.Text = z15.ToString();

            //SAĞKOL
            double z17 = (Convert.ToDouble(label62.Text) + (Convert.ToDouble(label62.Text) * 2 / 100));
            label81.Text = z17.ToString();

            double z18 = (Convert.ToDouble(label61.Text) * 4 / 100);
            label80.Text = z18.ToString();

            double z20 = (Convert.ToDouble(label60.Text) * 5 / 100);
            label79.Text = z20.ToString();

            double z19 = (Convert.ToDouble(label60.Text) * 4.6 / 100);
            label78.Text = z19.ToString();

            //SOLKOL
            double z21 = (Convert.ToDouble(label62.Text) + (Convert.ToDouble(label62.Text) * 2.2 / 100));
            label85.Text = z21.ToString();

            double z22 = (Convert.ToDouble(label61.Text) * 4.1 / 100);
            label84.Text = z22.ToString();

            double z24 = (Convert.ToDouble(label60.Text) * 4.9 / 100);
            label83.Text = z24.ToString();

            double z23 = (Convert.ToDouble(label60.Text) * 4.7 / 100);
            label82.Text = z23.ToString();

            //GÖVDE
            double z25 = (Convert.ToDouble(label62.Text) + (Convert.ToDouble(label62.Text) * 2.4 / 100));
            label89.Text = z25.ToString();

            double z26 = (Convert.ToDouble(label61.Text) * 47 / 100);
            label88.Text = z26.ToString();

            double z28 = (Convert.ToDouble(label60.Text) * 57 / 100);
            label87.Text = z28.ToString();

            double z27 = (Convert.ToDouble(label60.Text) * 55 / 100);
            label86.Text = z27.ToString();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
