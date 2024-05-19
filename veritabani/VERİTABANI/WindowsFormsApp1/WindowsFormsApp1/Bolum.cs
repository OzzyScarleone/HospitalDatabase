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
    public partial class Bolum : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Bolum()
        {
            InitializeComponent();
        }
        void BolumGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-P5TBFG1\\SQLEXPRESS;Initial Catalog=universiteveritbani;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM Bolum", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBlmKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bolum_Load(object sender, EventArgs e)
        {
            BolumGetir();
        }

        private void btnBlmEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Bolum(BolumKod,BolumAd,BolumTel,FakulteBilgisi) VALUES(@BlmKod,@BlmAd,@BlmTel,@FakBilgi)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@BlmKod", txtBlmKod.Text);
            komut.Parameters.AddWithValue("@BlmAd", txtBlmAd.Text);
            komut.Parameters.AddWithValue("@BlmTel", txtBlmTel.Text);
            komut.Parameters.AddWithValue("@FakBilgi", txtFakBilgi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            BolumGetir();
        }

       

        private void btnBlmSil_Click(object sender, EventArgs e)
        {
            //Silme işlemi için kullanılacak SQL sorgusu
            string sorgu = "DELETE FROM Bolum WHERE BolumKod=@BolumKod";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@BolumKod", txtBlmKod.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            BolumGetir();
        }

        private void btnBlmGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Bolum SET BolumKod=@BlmKod,BolumAd=@BlmAd,BolumTel=@BlmTel,FakulteBilgisi=@FakBilgi WHERE BolumKod=@BlmKod";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@BlmKod", txtBlmKod.Text);
            komut.Parameters.AddWithValue("@BlmAd", txtBlmAd.Text);
            komut.Parameters.AddWithValue("@BlmTel", txtBlmTel.Text);
            komut.Parameters.AddWithValue("@FakBilgi", txtFakBilgi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            BolumGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBlmKod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBlmAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBlmTel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtFakBilgi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
