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
    public partial class gelisim : Form
    {
        public gelisim()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ogrsayfasi og = new ogrsayfasi();
            og.Show();
            this.Close();
        }
        public static string akboy, akkilo, akkitindex, akyagorani, aksuorani, akkasorani, akkemikorani, akbazalmet, akaktifmet;
        public int Rowndx;
        public string tarih;
        private void gelisim_Load(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            string tar = simdi.ToString("dd.MM.yyyy");
            string tarr = simdi.ToString("MM.yyyy");
            string tarr1 = simdi.ToString("yyyy");
            int rowindex = 0;
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();

            //OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            //addtr.Fill(dt);
            //OleDbDataAdapter addtr1 = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tarr + "%'", baglanti);
            //addtr1.Fill(dt);
            OleDbDataAdapter addtr2 = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tarr1 + "%'", baglanti);
            addtr2.Fill(dt);
            int satirsayisi;
            dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[11], ListSortDirection.Descending);
            foreach (DataGridViewRow rw in this.dataGridView1.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        
                         dataGridView1.DataSource = dt;
                         satirsayisi = 0;
                         for (int a = 0; a < 1; a++)
                         {
                             for (int b = 0; b < 14; b++)
                             {
                                 label9.Text = dataGridView1.Rows[satirsayisi].Cells[1].Value.ToString();
                                 label18.Text = dataGridView1.Rows[satirsayisi].Cells[2].Value.ToString();
                                 label17.Text = dataGridView1.Rows[satirsayisi].Cells[3].Value.ToString();
                                 label10.Text = dataGridView1.Rows[satirsayisi].Cells[4].Value.ToString();
                                 label11.Text = dataGridView1.Rows[satirsayisi].Cells[5].Value.ToString();
                                 label12.Text = dataGridView1.Rows[satirsayisi].Cells[6].Value.ToString();
                                 label13.Text = dataGridView1.Rows[satirsayisi].Cells[7].Value.ToString();
                                 label14.Text = dataGridView1.Rows[satirsayisi].Cells[8].Value.ToString();
                                 label15.Text = dataGridView1.Rows[satirsayisi].Cells[9].Value.ToString();
                                 label16.Text = dataGridView1.Rows[satirsayisi].Cells[10].Value.ToString();
                             }
                         }
                    }
                    
                }
            }
            akboy = label18.Text;
            akkilo = label17.Text;
            akkitindex = label10.Text;
            akyagorani = label11.Text;
            aksuorani = label12.Text;
            akkasorani = label13.Text;
            akkemikorani = label14.Text;
            akbazalmet = label15.Text;
            akaktifmet = label16.Text;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gelisimtakvimi gl = new gelisimtakvimi();
            gl.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gelisimraporu gr = new gelisimraporu();
            gr.Show();
        }
    }
}
