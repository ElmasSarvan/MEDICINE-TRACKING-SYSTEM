using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using İLAÇ_TAKİP_SİSTEMİ;
namespace İLAÇ_TAKİP_SİSTEMİ
{
    public partial class Form6 : Form
    {
        
        public Form6()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 yeniForm = new Form10();
            yeniForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 yeniForm = new Form6();
            yeniForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici kullanici=new Kullanici();
            kullanici.KullaniciAdi=textBox1.Text;
            kullanici.KullaniciSoyadi = textBox3.Text;
            kullanici.Sifre = textBox2.Text;
            DatabaseHelper database= new DatabaseHelper();
            database.kullanıcı_giriş(kullanici);
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
