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
using System.Net;
using System.Runtime.InteropServices;

namespace İLAÇ_TAKİP_SİSTEMİ
{
    public partial class Form1 : Form
    {
        private Kullanici _kullanici;
        public Form1(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            
        }
        private void KULLANDIĞINIZ_İLAÇLAR_Click(object sender, EventArgs e)
        {
            Form7 yeniForm = new Form7(_kullanici);
            yeniForm.Show();
            this.Hide();
        }

        private void BARKOD_TARA_Click(object sender, EventArgs e)
        {
            Form2 yeniForm = new Form2(_kullanici);
            yeniForm.Show();
            this.Hide();
        }

       
        private void İLAÇ_ARA_Click(object sender, EventArgs e)
        {
            Form3 yeniForm = new Form3(_kullanici);
            yeniForm.Show();
            this.Hide();
        }

        private void DUYURULAR_Click(object sender, EventArgs e)
        {
            Form4 yeniForm = new Form4(_kullanici);
            yeniForm.Show();
            this.Hide();
        }

        private void ELLE_BARKOD_SORGULA_Click(object sender, EventArgs e)
        {
            Form5 yeniForm = new Form5(_kullanici);
            yeniForm.Show();
            this.Hide();
        }


        private void YAN_ETKİ_BİLDİR_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Yan etki bildirimi yapabilmek için lütfen 'Barkod Tara' veya 'Barkod Sorgula' butonuna basarak ilaç sorgulayınız.", "Onay", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            { 
                
                Form2 yeniForm = new Form2(_kullanici);
                yeniForm.Show();
                this.Hide();
            }
            if (sonuc == DialogResult.No)
            {
                Form5 yeniForm = new Form5(_kullanici);
                yeniForm.Show();
                this.Hide();
            }
            if(sonuc== DialogResult.Cancel)
            {
                Form1 yeniForm = new Form1(_kullanici);
                yeniForm.Show();
                this.Hide();
            }

        }

        private void İLAÇ_TAKİBİ_OLUŞTUR_Click(object sender, EventArgs e)
        {
            Form8 yeniForm = new Form8(_kullanici);
            yeniForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form10 yeniForm = new Form10();
            yeniForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
