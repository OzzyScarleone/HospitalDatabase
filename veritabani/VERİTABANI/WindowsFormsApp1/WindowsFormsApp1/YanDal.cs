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
    public partial class YanDal : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public YanDal()
        {
            InitializeComponent();
        }
        void YanDalGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-P5TBFG1\\SQLEXPRESS;Initial Catalog=universiteveritbani;Integrated Security=SSPI"); 
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM YanDal", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void YanDal_Load(object sender, EventArgs e)
        {
            YanDalGetir();
        }

        private void btnYanEkle_Click(object sender, EventArgs e)
        {
            bool bolumvarmi = true;
            bool ogrenciVarMi = true;
            if (OgrenciVarMi(txtYanOgrTc.Text)&&bolumVarmi(txtYanBolumKod.Text))
            {
                string sorgu = "INSERT INTO YanDal(OgrTc,BolumKod) VALUES(@OgrTc,@BolumKod)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@OgrTc", txtYanOgrTc.Text);
                komut.Parameters.AddWithValue("@BolumKod", txtYanBolumKod.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                YanDalGetir();
            }
            else
            {
                MessageBox.Show("Öğrenci yok veya bölüm yok");
            }
        }
        bool OgrenciVarMi(string TcNo)
        {
            baglanti = new SqlConnection("server=DESKTOP-P5TBFG1\\SQLEXPRESS;Initial Catalog=universiteveritbani;Integrated Security=SSPI");
            baglanti.Open();
            komut = new SqlCommand("Select Count(*) from Ogrenci where OgrTc='" + TcNo + "'", baglanti);


            int sayi = (int)komut.ExecuteScalar();

            baglanti.Close();

            if (sayi > 0)
                return true;
            else return false;

        }
        bool bolumVarmi(string bolumkod)
        {
            baglanti = new SqlConnection("server=DESKTOP-P5TBFG1\\SQLEXPRESS;Initial Catalog=universiteveritbani;Integrated Security=SSPI");
            baglanti.Open();
            komut = new SqlCommand("Select Count(*) from Bolum where BolumKod='" + bolumkod + "'", baglanti);


            int sayi = (int)komut.ExecuteScalar();

            baglanti.Close();

            if (sayi > 0)
                return true;
            else return false;

        }

        private void btnYanSil_Click(object sender, EventArgs e)
        {
            //Silme işlemi için kullanılacak SQL sorgusu
            string sorgu = "DELETE FROM YanDal WHERE OgrTc=@OgrTc";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@OgrTc", txtYanOgrTc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            YanDalGetir();
        }

        private void btnYanGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE YanDal SET OgrTc=@OgrTc,BolumKod=@BolumKod WHERE OgrTc=@OgrTc";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@OgrTc", txtYanOgrTc.Text);
            komut.Parameters.AddWithValue("@BolumKod", txtYanBolumKod.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            YanDalGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtYanOgrTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtYanBolumKod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
