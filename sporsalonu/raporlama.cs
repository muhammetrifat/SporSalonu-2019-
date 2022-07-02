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
    public partial class raporlama : Form
    {
        public raporlama()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();
        }


        private void raporlama_Load_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
            label1.Text = uyearama.gonderilecekveri;
            DataSet ds = new DataSet();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from " + label1.Text + "", baglanti);
            adtr.Fill(ds, "" + label1.Text + "");
            DataGridView1.DataSource = ds.Tables["" + label1.Text + ""];

            DataGridView1.Columns[0].HeaderText = "TC Kimlik No";
            DataGridView1.Columns[1].HeaderText = "Motivasyon";
            DataGridView1.Columns[2].HeaderText = "Güncel Boy";
            DataGridView1.Columns[3].HeaderText = "Güncel Kilo";
            DataGridView1.Columns[4].HeaderText = "Vücut Kitle İndeksi";
            DataGridView1.Columns[5].HeaderText = "Yağ Oranı (%)";
            DataGridView1.Columns[6].HeaderText = "Su Oranı";
            DataGridView1.Columns[7].HeaderText = "Kas Oranı";
            DataGridView1.Columns[8].HeaderText = "Kemik Oranı";
            DataGridView1.Columns[9].HeaderText = "Bazal Metabolizma Hızı";
            DataGridView1.Columns[10].HeaderText = "Aktif Metabolizma Hızı";
            DataGridView1.Columns[11].HeaderText = "Güncelleme Tarihi";
            DataGridView1.Columns[12].HeaderText = "Vücut Tipi";

        }
    }
}
