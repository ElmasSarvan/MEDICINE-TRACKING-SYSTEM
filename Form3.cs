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
    public partial class Form3 : Form
    {
        private Kullanici _kullanici;
        public Form3(Kullanici kullanici)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'İLAÇLARDataSet2.ILACLAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.iLACLARTableAdapter.Fill(this.İLAÇLARDataSet2.ILACLAR);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            _kullanici.ilac_ara = comboBox1.Text;
            DatabaseHelper database= new DatabaseHelper();
            database.VeriGetir(_kullanici);
            this.Hide();
        }
    }
}
