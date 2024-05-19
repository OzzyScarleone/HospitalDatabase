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
    public partial class Kayit : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Kayit()
        {
            InitializeComponent();
        }
        void KayitGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-P5TBFG1\\SQLEXPRESS;Initial Catalog=universiteveritbani;Integrated Security=SSPI"); 
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM Kayit", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Kayit_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

      

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Kayit(OgrTc,DersNo,KayitNot) VALUES(@OgrTc,@DersNo,@KayitNot)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@OgrTc", txtKOgrTc.Text);
            komut.Parameters.AddWithValue("@DersNo", txtKDersNo.Text);
            komut.Parameters.AddWithValue("@KayitNot", txtKNot.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KayitGetir();
        }

       
        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            //Silme işlemi için kullanılacak SQL sorgusu
            string sorgu = "DELETE FROM Kayit WHERE OgrTc=@OgrTc";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@OgrTc", txtKOgrTc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KayitGetir();
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Kayit SET OgrTc=@OgrTc,DersNo=@DersNo,KayitNot=@KayitNot WHERE OgrTc=@OgrTc";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@OgrTc", txtKOgrTc.Text);
            komut.Parameters.AddWithValue("@DersNo", txtKDersNo.Text);
            komut.Parameters.AddWithValue("@KayitNot", txtKNot.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KayitGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtKOgrTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKDersNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKNot.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
