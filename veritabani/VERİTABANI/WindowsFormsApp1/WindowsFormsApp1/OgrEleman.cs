using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class OgrEleman : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public OgrEleman()
        {
            InitializeComponent();
        }

        void OgrElemanGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-P5TBFG1\\SQLEXPRESS;Initial Catalog=universiteveritbani;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM OgrEleman", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }


            private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OgrEleman_Load(object sender, EventArgs e)
        {
            OgrElemanGetir();
        }

       

        private void btnOgrEEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO OgrEleman(OgrElemanTc,OgrElemanAd,OgrElemanSoyad,OgrElemanDT,OgrElemanCinsiyet,OgrElemanAdres,OgrElemanTel,OgrElemanMaas,BolumKod) VALUES(@OgrElemanTc,@OgrElemanAd,@OgrElemanSoyad,@OgrElemanDT,@OgrElemanCinsiyet,@OgrElemanAdres,@OgrElemanTel,@OgrElemanMaas,@BolumKod)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@OgrElemanTc", txtOgrETc.Text);
            komut.Parameters.AddWithValue("@OgrElemanAd", txtOgrEAd.Text);
            komut.Parameters.AddWithValue("@OgrElemanSoyad", txtOgrESoyad.Text);
            komut.Parameters.AddWithValue("@OgrElemanDT", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@OgrElemanCinsiyet", txtOgrECinsiyet.Text);
            komut.Parameters.AddWithValue("@OgrElemanAdres", txtOgrEAdres.Text);
            komut.Parameters.AddWithValue("@OgrElemanTel", txtOgrETel.Text);
            komut.Parameters.AddWithValue("@OgrElemanMaas", txtOgrEMaas.Text);
            komut.Parameters.AddWithValue("@BolumKod", txtOgrEBolumKod.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrElemanGetir();
        }

        private void btnOgrESil_Click(object sender, EventArgs e)
        {
           
            //Silme işlemi için kullanılacak SQL sorgusu
            string sorgu = "DELETE FROM OgrEleman WHERE OgrElemanTc=@OgrElemanTc";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@OgrElemanTc", txtOgrETc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrElemanGetir();
        }

        private void btnOgrEGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE OgrEleman SET OgrElemanTc=@OgrElemanTc, OgrElemanAd=@OgrElemanAd, OgrElemanSoyad=@OgrElemanSoyad, OgrElemanDT=@OgrElemanDT, OgrElemanCinsiyet=@OgrElemanCinsiyet, OgrElemanAdres=@OgrElemanAdres, OgrElemanTel=@OgrElemanTel, OgrElemanMaas=@OgrElemanMaas,BolumKod=@BolumKod WHERE OgrElemanTc=@OgrElemanTc";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@OgrElemanTc", txtOgrETc.Text);
            komut.Parameters.AddWithValue("@OgrElemanAd", txtOgrEAd.Text);
            komut.Parameters.AddWithValue("@OgrElemanSoyad", txtOgrESoyad.Text);
            komut.Parameters.AddWithValue("@OgrElemanDT", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@OgrElemanCinsiyet", txtOgrECinsiyet.Text);
            komut.Parameters.AddWithValue("@OgrElemanAdres", txtOgrEAdres.Text);
            komut.Parameters.AddWithValue("@OgrElemanTel", txtOgrETel.Text);
            komut.Parameters.AddWithValue("@OgrElemanMaas", txtOgrEMaas.Text);
            komut.Parameters.AddWithValue("@BolumKod", txtOgrEBolumKod.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            OgrElemanGetir(); 
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrETc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOgrEAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOgrESoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtOgrECinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtOgrEAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtOgrETel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtOgrEMaas.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtOgrEBolumKod.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
