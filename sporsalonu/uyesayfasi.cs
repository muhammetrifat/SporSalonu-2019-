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
    public partial class uyesayfasi : Form
    {
        public int Rowndx;

        String tckno, ad, soyad, sorgu, yol;


        OleDbConnection yeni = new OleDbConnection();
        OleDbCommand uygula = new OleDbCommand();
        //OleDbDataAdapter data = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        BindingSource bn = new BindingSource();

        private void uyesayfasi_Load_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");

            DataSet ds = new DataSet();
            baglanti.Open();
            OleDbDataAdapter data = new OleDbDataAdapter("Select * from uye", baglanti);

            DataTable dt = new DataTable();
            data.Fill(dt);
            BindingSource bn = new BindingSource();
            bn.DataSource = dt;
            DataGridView1.DataSource = bn;

            DataGridViewRow selectedRow = new DataGridViewRow();
            selectedRow = DataGridView1.Rows[Rowndx];

            tckno = selectedRow.Cells[0].Value.ToString();
            ad = selectedRow.Cells[1].Value.ToString();
            soyad = selectedRow.Cells[2].Value.ToString();
        }

        public uyesayfasi()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) //kaydet_butonu
        {
            OleDbCommand komut = new OleDbCommand();
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            DataGridViewRow selectedRow = new DataGridViewRow();
            selectedRow = DataGridView1.Rows[Rowndx];

            //tckno = selectedRow.Cells[0].Value.ToString();
            //ad = selectedRow.Cells[1].Value.ToString();
            //soyad = selectedRow.Cells[2].Value.ToString();
            //DateTime bugun = new DateTime();
            //bugun = DateTime.Now;
            //string tarih = "'" + bugun.ToString() + "'";

            DateTime dt = DateTime.Now;
            dt.ToString("MM/dd/yyyy");
            string tarih = dt.ToString();
            //string tarih = "" + dt.ToString() +"";

            //komut.CommandText = "insert into uyetakip (tcno,adi,soyadi,gboy,gkilo) values ('" + tckno + "','" + ad + "','" + soyad + "','" + TextBox1.Text + "','" + TextBox2.Text + "')";
            //komut.CommandText = "insert into " + tckno + " (tckno,ad,soyad,gboy,gkilo,yagorani,ortnabiz,tarih) values ('" + tckno + "','" + ad + "','" + soyad + "','" + TextBox1.Text + "','" + TextBox2.Text +"','" + textBox3.Text +"','" + textBox4.Text + "'," + tarih+  ")";
            komut.CommandText = "insert into " + 11111111115 + " (tarih) values ('" + tarih + "')";

            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarılı!", "Kayıt Güncelleme");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            giris gir = new giris();
            gir.Show();
            this.Close();

        }
    }
}
