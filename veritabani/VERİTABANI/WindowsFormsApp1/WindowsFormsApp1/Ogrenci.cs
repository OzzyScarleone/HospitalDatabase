using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //

namespace WindowsFormsApp1
{
    public partial class Ogrenci : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Ogrenci()
        {
            InitializeComponent();
        }
        void OgrenciGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-P5TBFG1\\SQLEXPRESS;Initial Catalog=universiteveritbani;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM Ogrenci", baglanti);
            DataTable tablo=new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource= tablo;
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            OgrenciGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Silme işlemi için kullanılacak SQL sorgusu
            string sorgu = "DELETE FROM Ogrenci WHERE OgrTc=@OgrTc";

            komut=new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@OgrTc", txtOgrTc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            OgrenciGetir();
        }


        private void btnOgrEkle_Click(object sender, EventArgs e)
        {
            string sorgu="INSERT INTO Ogrenci(OgrTc,OgrAd,OgrSoyad,OgrDT,OgrCinsiyet,OgrAdres,OgrTel) VALUES(@OgrTc,@OgrAd,@OgrSoyad,@OgrDT,@OgrCinsiyet,@OgrAdres,@OgrTel)";
            komut =new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@OgrTc", txtOgrTc.Text);
            komut.Parameters.AddWithValue("@OgrAd", txtOgrAd.Text);
            komut.Parameters.AddWithValue("@OgrSoyad", txtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@OgrDT", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@OgrCinsiyet", txtOgrCinsiyet.Text);
            komut.Parameters.AddWithValue("@OgrAdres", txtOgrAdres.Text);
            komut.Parameters.AddWithValue("@OgrTel", txtOgrTel.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrenciGetir();
        }

        private void btnOgrGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Ogrenci SET OgrTc=@OgrTc, OgrAd=@OgrAd, OgrSoyad=@OgrSoyad, OgrDT=@OgrDT, OgrCinsiyet=@OgrCinsiyet, OgrAdres=@OgrAdres, OgrTel=@OgrTel WHERE OgrTc=@OgrTc";
            komut=new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@OgrTc", txtOgrTc.Text);
            komut.Parameters.AddWithValue("@OgrAd", txtOgrAd.Text);
            komut.Parameters.AddWithValue("@OgrSoyad", txtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@OgrDT", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@OgrCinsiyet", txtOgrCinsiyet.Text);
            komut.Parameters.AddWithValue("@OgrAdres", txtOgrAdres.Text);
            komut.Parameters.AddWithValue("@OgrTel", txtOgrTel.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrenciGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOgrAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOgrSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtOgrCinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtOgrAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtOgrTel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }


    }
}
