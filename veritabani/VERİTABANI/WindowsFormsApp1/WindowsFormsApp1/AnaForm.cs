using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Show();

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrEleman ogrEleman = new OgrEleman();
            ogrEleman.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Bolum bolum = new Bolum();
            bolum.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders();
            ders.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnaDal anaDal = new AnaDal();
            anaDal.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YanDal anaDal = new YanDal();
            anaDal.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
        }
    }
}
