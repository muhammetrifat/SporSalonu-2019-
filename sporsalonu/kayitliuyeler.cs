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
    public partial class kayitliuyeler : Form
    {
        private OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
        DataSet ds = new DataSet();
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();

        public kayitliuyeler()
        {
            InitializeComponent();
        }

        //private void Form2_Load(object sender, EventArgs e)
        //{
        //    baglanti.Open();

        //    OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From uye", baglanti);
        //    adtr.Fill(ds, "uye");
        //    dataGridView1.DataSource = ds.Tables["uye"];

        //    baglanti.Close();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfasec = new anasayfa();
            anasayfasec.Show();
            this.Hide();
        }

        private void kayitliuyeler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From uye", baglanti);
            adtr.Fill(ds, "uye");
            dataGridView1.DataSource = ds.Tables["uye"];

            dataGridView1.Columns[0].HeaderText = "TC Kimlik No";
            dataGridView1.Columns[1].HeaderText = "Adı";
            dataGridView1.Columns[2].HeaderText = "Soyadı";
            dataGridView1.Columns[3].HeaderText = "Cinsiyet";
            dataGridView1.Columns[4].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns[5].HeaderText = "Meslek";
            dataGridView1.Columns[6].HeaderText = "Kilo";
            dataGridView1.Columns[7].HeaderText = "Boy";
            dataGridView1.Columns[8].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[9].HeaderText = "Kayıt Tarihi";
            dataGridView1.Columns[10].HeaderText = "ID";
            dataGridView1.Columns[11].HeaderText = "Şifre";
            dataGridView1.Columns[12].HeaderText = "Yetki";
            dataGridView1.Columns[14].HeaderText = "Yaşı";
            dataGridView1.Columns[15].HeaderText = "Branşı";
            dataGridView1.Columns[16].HeaderText = "Abonelik Süresi";

            baglanti.Close();
        }
    }
}
