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

namespace Kütüphane_Otomasyonu
{
    public partial class Form2 : Form
    {
        static string baglantiYolu = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\bertug\Desktop\C#\UYGULAMALAR\Kütüphane_Otomasyonu\KütüphaneBilgileri.mdb";
        static OleDbConnection baglanti = new OleDbConnection(baglantiYolu);

        public Form2()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU PROGRAM BİLGİSAYAR MÜHENDİSLİĞİ 1.SINIF ÖĞRENCİSİ BERTUĞ İLK TARAFINDAN YAPILMIŞTIR...");
        }

        private void hESAPMAKİNESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        public void kitapListele(string veri)
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter(veri,baglanti);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            dataGridView1.Visible = true;
            kitapListele("select*from Kitap");
        }

        public void emanetListele(string veri)
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter(veri, baglanti);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            dataGridView1.Visible = true;
            emanetListele("select*from Emanetler");
        }

        public void üyeleriListele(string veri)
        {
            OleDbDataAdapter adaptor = new OleDbDataAdapter(veri, baglanti);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            dataGridView1.Visible = true;
            üyeleriListele("select*from Üyeler");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 kapat = new Form2();
            kapat.Close();
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void kİTAPARAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 kapat = new Form2();
            kapat.Close();
            Form4 yeni = new Form4();
            yeni.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            dataGridView1.Visible = true;
            emanetListele("select*from Emanetler");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 kapat = new Form2();
            kapat.Close();
            Form5 yeni = new Form5();
            yeni.Show();
            this.Hide();
        }
    }
}
