using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İLAÇ_TAKİP_SİSTEMİ
{
    public partial class Form7 : Form
    {
        private Kullanici _kullanici;
        public Form7(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 yeniForm = new Form1(_kullanici);
            yeniForm.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            DatabaseHelper database=new DatabaseHelper();
            database.ID_BELİRLEME(_kullanici);
            database.KULLANDIĞI_İLAÇLAR(_kullanici);
            listBox1.Items.Add("İLAÇ ADI : "+_kullanici.ilac_adi+ "\n" +"BAŞLANGIÇ TARİHİ : "+_kullanici.baslangic_tarihi + "\t"+"BİTİŞ TARİHİ : " + _kullanici.bitis_tarihi + "\n"+"SABAH SAAT : " + _kullanici.sabah + "\t" + "ÖĞLE SAAT : " + _kullanici.ogle + "\t" + "AKŞAM SAAT : " + _kullanici.aksam + "\t");
            
        }
    }
}
