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
    public partial class Ders : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Ders()
        {
            InitializeComponent();
        }
        void DersGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-P5TBFG1\\SQLEXPRESS;Initial Catalog=universiteveritbani;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM Ders", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ders_Load(object sender, EventArgs e)
        {
            DersGetir();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Ders(DersNo,DersAd,DersKredi,BolumKod,OgrElemanTc) VALUES(@DersNo,@DersAd,@DersKredi,@BolumKod,@OgrElemanTc)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@DersNo", txtDersNo.Text);
            komut.Parameters.AddWithValue("@DersAd", txtDersAd.Text);
            komut.Parameters.AddWithValue("@DersKredi", txtDersKredi.Text);
            komut.Parameters.AddWithValue("@BolumKod", txtDBolumKod.Text);
            komut.Parameters.AddWithValue("@OgrElemanTc", txtDOgrETc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DersGetir();
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            //Silme işlemi için kullanılacak SQL sorgusu
            string sorgu = "DELETE FROM Ders WHERE DersNo=@DersNo";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@DersNo", txtDersNo.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DersGetir();
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Ders SET DersNo=@DersNo,DersAd=@DersAd,DersKredi=@DersKredi,BolumKod=@BolumKod,OgrElemanTc=@OgrElemanTc WHERE DersNo=@DersNo";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@DersNo", txtDersNo.Text);
            komut.Parameters.AddWithValue("@DersAd", txtDersAd.Text);
            komut.Parameters.AddWithValue("@DersKredi", txtDersKredi.Text);
            komut.Parameters.AddWithValue("@BolumKod", txtDBolumKod.Text);
            komut.Parameters.AddWithValue("@OgrElemanTc", txtDOgrETc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DersGetir();
        }

   

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtDersNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDersAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDersKredi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDBolumKod.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDOgrETc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
