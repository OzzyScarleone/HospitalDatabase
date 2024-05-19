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
using System.Diagnostics.Eventing.Reader;


namespace WindowsFormsApp1
{

    public partial class AnaDal : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public AnaDal()
        {
            InitializeComponent();
        }
        void AnaDalGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-P5TBFG1\\SQLEXPRESS;Initial Catalog=universiteveritbani;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM AnaDal", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AnaDal_Load(object sender, EventArgs e)
        {
            AnaDalGetir();
        }

      

        private void btnAnaEkle_Click(object sender, EventArgs e)
        {
            bool bolumvarmi = true;
            bool ogtrnciVarMi = true;
            if (OgrenciVarMi(txtAnaOgrTc.Text)&&bolumVarmi(txtAnaBolumKod.Text))
            {

                string sorgu = "INSERT INTO AnaDal (OgrTc, BolumKod) VALUES (@OgrTc, @BolumKod)";/* "INSERT INTO AnaDal(OgrTc,BolumKod) VALUES(@OgrTc,@BolumKod) AND Ogrenci.OgrTc=Anadal.OgrTC";*/
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@OgrTc", txtAnaOgrTc.Text);
                komut.Parameters.AddWithValue("@BolumKod", txtAnaBolumKod.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                AnaDalGetir();
            }
            else
            {
                MessageBox.Show("Öğrenci yok veya Bölüm yok");
            }
            
        }

        bool OgrenciVarMi(string TcNo)
        {
            baglanti = new SqlConnection("server=DESKTOP-P5TBFG1\\SQLEXPRESS;Initial Catalog=universiteveritbani;Integrated Security=SSPI");
            baglanti.Open();
            komut = new SqlCommand("Select Count(*) from Ogrenci where OgrTc='" + TcNo +"'", baglanti);

           
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

            if (sayi>0)
                return true;
            else return false;

        }

        private void btnAnaSil_Click(object sender, EventArgs e)
        {
            //Silme işlemi için kullanılacak SQL sorgusu
            string sorgu = "DELETE FROM AnaDal WHERE OgrTc=@OgrTc";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@OgrTc", txtAnaOgrTc.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AnaDalGetir();
        }

        private void btnAnaGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE AnaDal SET OgrTc=@OgrTc,BolumKod=@BolumKod WHERE OgrTc=@OgrTc";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@OgrTc", txtAnaOgrTc.Text);
            komut.Parameters.AddWithValue("@BolumKod", txtAnaBolumKod.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AnaDalGetir();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAnaOgrTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAnaBolumKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAnaOgrTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAnaBolumKod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
