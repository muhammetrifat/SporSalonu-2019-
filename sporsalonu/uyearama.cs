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
    public partial class uyearama : Form
    {
        void Listele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");

            string sorgu = "select * from uye where tcno like '%" + textBox1.Text + "%'";
            baglanti.Open();
            OleDbDataAdapter getir = new OleDbDataAdapter(sorgu, baglanti);
            DataSet goster = new DataSet();
            getir.Fill(goster, "uye");
            dataGridView1.DataSource = goster.Tables["uye"];
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            getir.Dispose();
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "tcno like ''" + textBox1.Text + "%'";
        }

        public int Rowndx;

        String tckno;

        public uyearama()
        {
            InitializeComponent();
        }

        // void listele()
        // {
        //     OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\sporsalonudb.mdb");
        //
        //     DataSet ds = new DataSet();
        //     baglanti.Open();
        //     OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from uye", baglanti);
        //     adtr.Fill(ds, "uye");
        //     dataGridView1.DataSource = ds.Tables["uye"];
        //     dataGridView1.Columns[0].HeaderText = "TC Kimlik No";
        //     dataGridView1.Columns[1].HeaderText = "Adı";
        //     dataGridView1.Columns[2].HeaderText = "Soyadı";
        //     dataGridView1.Columns[3].HeaderText = "Cinsiyet";
        //     dataGridView1.Columns[4].HeaderText = "Doğum Tarihi";
        //     dataGridView1.Columns[5].HeaderText = "Meslek";
        //     dataGridView1.Columns[6].HeaderText = "Kilo";
        //     dataGridView1.Columns[7].HeaderText = "Boy";
        //     dataGridView1.Columns[8].HeaderText = "Telefon Numarası";
        //     dataGridView1.Columns[9].HeaderText = "Kayıt Tarihi";
        //     dataGridView1.Columns[10].HeaderText = "ID";
        //     dataGridView1.Columns[11].HeaderText = "Şifre";
        //     dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //     adtr.Dispose();
        //     baglanti.Close();
        // }

        public static string gonderilecekveri;



        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
            if (dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("Kayıt Bulunamadı.","Hata");
            }
            else if (dataGridView1.Rows.Count >= 2)
            {
                gonderilecekveri = textBox1.Text;
                DataGridViewRow selectedRow = new DataGridViewRow();
                selectedRow = dataGridView1.Rows[Rowndx];
                tckno = selectedRow.Cells[0].Value.ToString();

                if (textBox1.Text == tckno)
                {
                    raporlama form2sec = new raporlama();
                    form2sec.Show();
                    this.Hide();
                }
            }
        }

        private void uyearama_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfasec = new anasayfa();
            anasayfasec.Show();
            this.Hide();
        }
    }
}
