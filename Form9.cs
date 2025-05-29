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
    public partial class Form9 : Form
    {
       
        public Form9()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 yeniForm = new Form9();
            yeniForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 yeniForm = new Form10();
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
                textBox2.UseSystemPasswordChar= true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici kullanici=new Kullanici();
            kullanici.KullaniciAdi =textBox1.Text;
            kullanici.KullaniciSoyadi=textBox3.Text;
            kullanici.dogum_tarihi =dateTimePicker1.Text;
            kullanici.Sifre=textBox2.Text;
            DatabaseHelper database =new DatabaseHelper();
            database.KullaniciEkle(kullanici);
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
