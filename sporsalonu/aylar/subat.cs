﻿using System;
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
    public partial class subat : Form
    {
        public subat()
        {
            InitializeComponent();
        }
        private void pictureBox31_Click(object sender, EventArgs e)
        {
            gelisimtakvimi gl = new gelisimtakvimi();
            gl.Show();
            this.Close();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|/sporsalonudb.mdb");
        OleDbCommand komut = new OleDbCommand();
        int rowindex = 0;
        public static string motivasyon, boy, kilo, kitin, yagorani, suorani, kasorani, kemikorani, bazalmet, aktifmet;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("1.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte bir antrenman kaydınız bulunmamaktadır.");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("2.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("3.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("4.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("5.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("6.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("7.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("8.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("9.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("10.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("11.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("12.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("13.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("14.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("15.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("16.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("17.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("18.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("19.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("20.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("21.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("22.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("23.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("24.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("25.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("26.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("27.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("28.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("29.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("30.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            DateTime simdi = new DateTime();
            string tar = simdi.ToString("31.02.2019");
            DataSet dts = new DataSet();
            DataTable dt = new DataTable();
            OleDbDataAdapter addtr = new OleDbDataAdapter("Select * from " + giris.tckno + " where tarih like '%" + tar + "%'", baglanti);
            addtr.Fill(dt);
            dataGridView2.DataSource = dt;
            int rowindex = 0;
            rowindex = dataGridView2.RowCount - 2;
            foreach (DataGridViewRow rw in this.dataGridView2.Rows)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("Bu tarihte gelişim kaydı bulunmamaktadır.", "Empty");
                        subat sb = new subat();
                        sb.Show();
                        this.Close();
                    }
                    else
                    {
                        DataGridViewRow selectedRow = new DataGridViewRow();
                        selectedRow = dataGridView2.Rows[rowindex];
                        motivasyon = selectedRow.Cells[1].Value.ToString();
                        boy = selectedRow.Cells[2].Value.ToString();
                        kilo = selectedRow.Cells[3].Value.ToString();
                        kitin = selectedRow.Cells[4].Value.ToString();
                        yagorani = selectedRow.Cells[5].Value.ToString();
                        suorani = selectedRow.Cells[6].Value.ToString();
                        kasorani = selectedRow.Cells[7].Value.ToString();
                        kemikorani = selectedRow.Cells[8].Value.ToString();
                        bazalmet = selectedRow.Cells[9].Value.ToString();
                        aktifmet = selectedRow.Cells[10].Value.ToString();
                        tarihselgelisim.gon1 = motivasyon;
                        tarihselgelisim.gon2 = boy;
                        tarihselgelisim.gon3 = kilo;
                        tarihselgelisim.gon4 = kitin;
                        tarihselgelisim.gon5 = yagorani;
                        tarihselgelisim.gon6 = suorani;
                        tarihselgelisim.gon7 = kasorani;
                        tarihselgelisim.gon8 = kemikorani;
                        tarihselgelisim.gon9 = bazalmet;
                        tarihselgelisim.gon10 = aktifmet;
                        tarihselgelisim targel = new tarihselgelisim();
                        targel.Show();
                        this.Close();
                    }
                }
            }
        }

        private void subat_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from " + giris.tckno + "", baglanti);
            adtr.Fill(ds, "" + giris.tckno + "");
            dataGridView1.DataSource = ds.Tables["" + giris.tckno + ""];
            baglanti.Close();
        }
    }
}
