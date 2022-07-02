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
    public partial class giris : Form
    {
        private OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");

        public giris()
        {
            InitializeComponent();
        }
        public static string adsoyad, id, ad, soyad, brans;
        public static string tckno, textid;
        private void button_giris_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = baglanti;
            command.CommandText = "select * from uye where id = '" + textBox_id.Text + "' and pw = '" + textBox_pw.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();

            int sayi = 0;
            while (reader.Read())
            {
                sayi++;
            }

            if (sayi == 1)
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");

                DataSet ds = new DataSet();
                baglanti.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from uye", baglanti);
                adtr.Fill(ds, "uye");
                dataGridView1.DataSource = ds.Tables["uye"];

                int rowindex = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells["id"].Value.ToString() == textBox_id.Text)
                    {
                        rowindex = row.Index;
                        break;
                    }
                }

                id = textBox_id.Text;

                DataGridViewRow selectedRow = new DataGridViewRow();
                selectedRow = dataGridView1.Rows[rowindex];


                if (selectedRow.Cells[12].Value.ToString() == "1")
                {
                    selectedRow = dataGridView1.Rows[rowindex];
                    tckno = selectedRow.Cells[0].Value.ToString();
                    adsoyad = selectedRow.Cells[1].Value.ToString() + " " + selectedRow.Cells[2].Value.ToString();
                    anasayfa f3 = new anasayfa();
                    f3.Show();

                }
                else if (selectedRow.Cells[12].Value.ToString() == "2")
                {
                    selectedRow = dataGridView1.Rows[rowindex];
                    tckno = selectedRow.Cells[0].Value.ToString();
                    adsoyad = selectedRow.Cells[1].Value.ToString() + " " + selectedRow.Cells[2].Value.ToString();
                    brans = selectedRow.Cells[15].Value.ToString();
                    hocasayfasi hs = new hocasayfasi();
                    hs.Show();
                }
                else if (selectedRow.Cells[12].Value.ToString() == "0")
                {
                    selectedRow = dataGridView1.Rows[rowindex];
                    tckno = selectedRow.Cells[0].Value.ToString();
                    adsoyad = selectedRow.Cells[1].Value.ToString() + " " + selectedRow.Cells[2].Value.ToString();
                    ad = selectedRow.Cells[1].Value.ToString();
                    soyad = selectedRow.Cells[2].Value.ToString();
                    ogrsayfasi uyesayf = new ogrsayfasi();
                    ogrsayfasi.Rowndx = rowindex;
                    uyesayf.Show();
                } 
                baglanti.Close();
                baglanti.Dispose();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı", "Notice");
                this.Close();
            }

            baglanti.Close();
        }

        private void textBox_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_giris_Click_1(sender, e);
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
