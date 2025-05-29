using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İLAÇ_TAKİP_SİSTEMİ
{
    public partial class Form11 : Form
    {
        private Kullanici _kullanici;
        public Form11(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(_kullanici);
            form.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {  
            DatabaseHelper database= new DatabaseHelper();
            groupBox1.Text = _kullanici.ilac_ara;
            textBox4.Text = _kullanici.ilac_sinifi;
            textBox1.Text=_kullanici.genel_bilgi;
            textBox2.Text = _kullanici.sik_gorulen;
            textBox5.Text = _kullanici.nadir_gorulen;
            textBox6.Text = _kullanici.kullanma_talimati;
            textBox3.Text = _kullanici.onemli_uyarilar;
            label7.Text = _kullanici.kullanim_uyari;
            label10.Text = _kullanici.atc;
            label11.Text = _kullanici.etken_madde;
            label13.Text = _kullanici.firma_adi;
            label15.Text = _kullanici.barkod;
            label17.Text = _kullanici.recete_durumu;
            label19.Text = _kullanici.satis_fiyati;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
