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

    public partial class yenikayit : Form
    {
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "tcno like ''" + textBox13.Text + "%'";
        }

        public void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[2].Value.ToString();
            textBox4.Text = selectedRow.Cells[3].Value.ToString();
            textBox5.Text = selectedRow.Cells[4].Value.ToString();
            textBox6.Text = selectedRow.Cells[5].Value.ToString();
            textBox7.Text = selectedRow.Cells[6].Value.ToString();
            textBox8.Text = selectedRow.Cells[7].Value.ToString();
            textBox9.Text = selectedRow.Cells[8].Value.ToString();
            //textBox10.Text = selectedRow.Cells[9].Value.ToString();
            textBox11.Text = selectedRow.Cells[10].Value.ToString();
            textBox12.Text = selectedRow.Cells[11].Value.ToString();
            //textBox14.Text = selectedRow.Cells[12].Value.ToString();
            textBox15.Text = selectedRow.Cells[14].Value.ToString();
            //textBox16.Text = selectedRow.Cells[15].Value.ToString();
            //textBox17.Text = selectedRow.Cells[16].Value.ToString();
        }





        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut1 = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        public yenikayit()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)//temizle butonu
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            //textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            comboBox3.Text = "";
            textBox15.Clear();
            comboBox2.Text = "";
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)//anasayfa butonu
        {
            anasayfa anasayfasec = new anasayfa();
            anasayfasec.Show();
            this.Hide();
        }

        void istele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");

            DataSet ds = new DataSet();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from uye", baglanti);
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            adtr.Dispose();
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)// ekle butonu
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
            DateTime basla = DateTime.Now.AddDays(Convert.ToInt16(comboBox1.Text));
            DateTime dt = DateTime.Now;
            string tarihh = dt.ToString();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox11.Text != "" && textBox12.Text != "" && comboBox3.Text != "" && textBox15.Text != "" && comboBox2.Text != "" && comboBox1.Text != "")
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut1.Connection = baglanti;
                komut.CommandText = "Insert Into uye(tcno,adi,soyadi,cinsiyet,dog_tar,meslegi,kilo,boy,telno,kayit_tar,id,pw,yetki,yas,brans,kalan_gun_sayisi,uyelik_bitis) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + tarihh + "','" + textBox11.Text + "','" + textBox12.Text + "','" + comboBox3.Text + "','" + textBox15.Text + "','" + comboBox2.Text + "','" + comboBox1.Text +"','" + basla + "')";
                komut1.CommandText = "CREATE TABLE " + textBox1.Text + " (tckno char(11),motivasyon char(30),gboy char(3),gkilo char(3),kitin char(4),yagorani char(4),suorani char(4),kasorani char(4),kemikorani char(4),bazalmet char(5),aktifmet char(5),tarih datetime,vucut_tipi char(15))";
                try
                {
                    komut.ExecuteNonQuery();
                    komut1.ExecuteNonQuery();
                    komut.Dispose();
                    komut1.Dispose();
                    MessageBox.Show("Kayıt Tamamlandı!");
                }
                catch (OleDbException ex)
                {
                    if (ex.ErrorCode == -2147467259)
                    {
                        MessageBox.Show("Hatalı giriş. Girdiğiniz TC bir başkası adına alınmıştır.");
                    }
                }
                baglanti.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                //textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                comboBox3.Text = "";
                textBox15.Clear();
                comboBox2.Text = "";
                comboBox1.Text = "";
            }

            else
            {
                MessageBox.Show("Boş alan geçmeyiniz!");
            }


        }

        public void button4_Click(object sender, EventArgs e)// sil butonu
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != ""  && textBox11.Text != "" && textBox12.Text != "" && comboBox3.Text != "" && textBox15.Text != "" && comboBox2.Text != "" && comboBox1.Text != "")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");

                OleDbCommand komut = new OleDbCommand();
                OleDbDataAdapter adtr = new OleDbDataAdapter();
                DialogResult c;
                c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from uye where tcno= '" + textBox13.Text + "'";
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Silindi !", "Başarılı");
                    istele();
                }

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                //textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                comboBox3.Text = "";
                textBox15.Clear();
                comboBox2.Text = "";
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız.","Hata");
            }
        }

        void Listele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");

            string sorgu = "select * from uye where tcno like '%" + textBox13.Text + "%'";
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
            dataGridView1.Columns[12].HeaderText = "Yetki";
            dataGridView1.Columns[13].HeaderText = "Yaşı";
            dataGridView1.Columns[14].HeaderText = "Branşı";
            dataGridView1.Columns[15].HeaderText = "Abonelik Süresi";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            getir.Dispose();
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e) // güncelle butonu
        {
            string kaytar = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            DateTime hep = Convert.ToDateTime(kaytar).AddDays(Convert.ToInt16(comboBox1.Text));
            MessageBox.Show(hep.ToString());
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != ""  && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text !="" && comboBox3.Text != "" && textBox15.Text != "" && comboBox2.Text != "" && comboBox1.Text != "")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut1.Connection = baglanti;
                komut.CommandText = "update uye set adi='" + textBox2.Text + "', soyadi='" + textBox3.Text + "', cinsiyet='" + textBox4.Text + "', dog_tar ='" + textBox5.Text + "', meslegi ='" + textBox6.Text + "', kilo ='" + textBox7.Text + "', boy='" + textBox8.Text + "', telno='" + textBox9.Text + "', id='" + textBox11.Text + "', pw='" + textBox12.Text + "', yetki='" + comboBox3.Text + "', yas= '" + textBox15.Text + "', brans='" + comboBox2.Text + "', kalan_gun_sayisi='" + comboBox1.Text + "', uyelik_bitis = '" + hep + "' where tcno= '" + textBox13.Text + "'";
                komut1.CommandText = "update " + textBox13.Text + " set tckno='" + textBox1.Text + "'";
                komut.ExecuteNonQuery();
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Başarılı !","Notice");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                //textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                comboBox3.Text = "";
                textBox15.Clear();
                comboBox2.Text = "";
                comboBox1.Text = "";
                istele();
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız.","Hata");
            }
        }

        private void button6_Click(object sender, EventArgs e) // listele butonu
        {
            textBox13.Clear();
            istele();
        }

        private void button7_Click(object sender, EventArgs e) //sorgula butonu
        {
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells["tcno"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["adi"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["soyadi"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["cinsiyet"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["dog_tar"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["meslegi"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["kilo"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["boy"].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells["telno"].Value.ToString();
            //textBox10.Text = dataGridView1.CurrentRow.Cells["kayit_tar"].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells["pw"].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells["tcno"].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells["yetki"].Value.ToString();
            textBox15.Text = dataGridView1.CurrentRow.Cells["yas"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["brans"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["kalan_gun_sayisi"].Value.ToString();
            Listele();
        }
    }
}
