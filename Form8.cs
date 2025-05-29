using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Data.SqlClient;
namespace İLAÇ_TAKİP_SİSTEMİ
{
    public partial class Form8 : Form
    {
        private Kullanici _kullanici;
        public Form8(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici=kullanici;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 yeniForm = new Form1(_kullanici);
            yeniForm.Show();
            this.Hide();
        }

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked == true)
            {
                maskedTextBox1.Visible = true;
            }
            else
            {
                maskedTextBox1.Visible = false;
            }

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'İLAÇLARDataSet4.ILACLAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.iLACLARTableAdapter.Fill(this.İLAÇLARDataSet4.ILACLAR);
            maskedTextBox1.Visible = false; 
            maskedTextBox2.Visible = false;
            maskedTextBox3.Visible = false;
            maskedTextBox1.Mask = "00:00";
            maskedTextBox2.Mask = "00:00";
            maskedTextBox3.Mask = "00:00";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                maskedTextBox2.Visible = true;
            }
            else
            {
                maskedTextBox2.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                maskedTextBox3.Visible = true;
            }
            else
            {
                maskedTextBox3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHelper database = new DatabaseHelper();
            database.ID_BELİRLEME(_kullanici);
            _kullanici.ilac_adi = comboBox1.Text;
            _kullanici.baslangic_tarihi =dateTimePicker1.Value;
            _kullanici.bitis_tarihi = dateTimePicker2.Value;
            _kullanici.sabah = checkBox1.Checked && !string.IsNullOrWhiteSpace(maskedTextBox1.Text.Trim())
                ? maskedTextBox1.Text.Trim()
                : null;

            _kullanici.ogle = checkBox2.Checked && !string.IsNullOrWhiteSpace(maskedTextBox2.Text.Trim())
                ? maskedTextBox2.Text.Trim()
                : null;

            _kullanici.aksam = checkBox3.Checked && !string.IsNullOrWhiteSpace(maskedTextBox3.Text.Trim())
                ? maskedTextBox3.Text.Trim()
                : null;
            database.ilaç_ekle(_kullanici);
            this.Hide();
        }    

        private void button2_Click(object sender, EventArgs e)
        {
           Form8 yeniForm = new Form8(_kullanici);
           yeniForm.Show();
           this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
