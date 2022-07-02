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
    public partial class ogrsayfasi : Form
    {
        public ogrsayfasi()
        {
            InitializeComponent();
        }
        public static int Rowndx;
        OleDbConnection yeni = new OleDbConnection();
        OleDbCommand uygula = new OleDbCommand();
        OleDbDataAdapter data = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        BindingSource bn = new BindingSource();
        int rowindex = 0;

        public static string kitle, yag, su, kas, kemik, bazalmet, aktifmet, boy, kilo, motivasyon, brans;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (brans == "fitness")
            {
                diyetfit dyf = new diyetfit();
                dyf.Show();
                this.Close();
            }
            else if (brans == "boks")
            {
                diyetboks dyb = new diyetboks();
                dyb.Show();
                this.Close();
            }
            else if (brans == "pilates")
            {
                diyetpilates dyp = new diyetpilates();
                dyp.Show();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            egzersizler eg = new egzersizler();
            eg.Show();
            this.Close();
        }

        private void ogrsayfasi_Load(object sender, EventArgs e)
        {
            textBox1.Text = giris.id;
            label2.Text = giris.adsoyad;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
            DataSet ds = new DataSet();
            baglanti.Open();
            OleDbDataAdapter data = new OleDbDataAdapter("Select * from " + giris.tckno + "", baglanti);
            DataTable dt = new DataTable();
            data.Fill(dt);
            BindingSource bn = new BindingSource();
            bn.DataSource = dt;
            dataGridView1.DataSource = bn;
            baglanti.Close();

            baglanti.Open();
            OleDbDataAdapter adtr1 = new OleDbDataAdapter("Select * From uye", baglanti);
            adtr1.Fill(ds, "uye");
            dataGridView2.DataSource = ds.Tables["uye"];
            baglanti.Close();

            int rowindex = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                if (row.Cells["id"].Value.ToString() == textBox1.Text)
                {
                    rowindex = row.Index;
                    break;
                }
            }
            brans = dataGridView2.Rows[rowindex].Cells[15].Value.ToString();
            label4.Text = dataGridView2.Rows[rowindex].Cells[17].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Gelişim kaydınız bulunmamaktadır.","Hata");
            }
            else
            {
                DataGridViewRow selectedRow = new DataGridViewRow();
                selectedRow = dataGridView1.Rows[rowindex];
                motivasyon = selectedRow.Cells[3].Value.ToString();
                boy = selectedRow.Cells[3].Value.ToString();
                kilo = selectedRow.Cells[3].Value.ToString();
                kitle = selectedRow.Cells[3].Value.ToString();
                yag = selectedRow.Cells[3].Value.ToString();
                su = selectedRow.Cells[3].Value.ToString();
                kas = selectedRow.Cells[3].Value.ToString();
                kemik = selectedRow.Cells[3].Value.ToString();
                bazalmet = selectedRow.Cells[3].Value.ToString();
                aktifmet = selectedRow.Cells[3].Value.ToString();
                gelisim gl = new gelisim();
                gl.Show();
                this.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            giris g = new giris();
            g.Show();
            this.Close();
        }
    }
}
