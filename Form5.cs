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
    public partial class Form5 : Form
    {
        private Kullanici _kullanici;
        public Form5(Kullanici kullanici)
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            if (maskedTextBox1.TextLength == 13)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _kullanici.barkod=maskedTextBox1.Text;
            DatabaseHelper database=new DatabaseHelper();
            database.VeriGetir1(_kullanici);
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button1.Enabled=false;
        }
    }
}
