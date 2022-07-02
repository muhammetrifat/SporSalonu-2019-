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
    public partial class ogrenciverigirisi : Form
    {
        public ogrenciverigirisi()
        {
            InitializeComponent();
        }

        private void ogrenciverigirisi_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tc Kimlik No yazınız.","Hata");
            }
            else
            {
                DateTime dt = DateTime.Now;
                string tarih = dt.ToString();
                OleDbCommand komut = new OleDbCommand();
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandType = CommandType.Text;
                komut.CommandText = "insert into " + textBox1.Text + " (tckno, motivasyon, gboy, gkilo, kitin, yagorani, suorani, kasorani, kemikorani, bazalmet, aktifmet, vucut_tipi, tarih) values ('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox2.Text + "','" + tarih + "')";
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Başarılı!", "Kayıt Güncelleme");

                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            hocasayfasi hc = new hocasayfasi();
            hc.Show();
            this.Close();
        }
    }
}
