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
    public partial class ogrenciler : Form
    {
        public ogrenciler()
        {
            InitializeComponent();
        }
        OleDbConnection yeni = new OleDbConnection();
        OleDbCommand uygula = new OleDbCommand();
        OleDbDataAdapter data = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bn = new BindingSource();
        DataSet ds = new DataSet();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
        private void ogrenciler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr1 = new OleDbDataAdapter("Select tcno,adi,soyadi,cinsiyet,dog_tar,meslegi,kilo,boy,telno,kayit_tar,vucut_tipi,yas,brans,kalan_gun_sayisi from uye where brans like '%" + giris.brans + "%'", baglanti);
            adtr1.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

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
            dataGridView1.Columns[10].HeaderText = "Vücut Tipi";
            dataGridView1.Columns[11].HeaderText = "Yaş";
            dataGridView1.Columns[12].HeaderText = "Branş";
            dataGridView1.Columns[13].HeaderText = "Kalan Gün Sayısı";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            hocasayfasi hc = new hocasayfasi();
            hc.Show();
            this.Close();
        }
    }
}
