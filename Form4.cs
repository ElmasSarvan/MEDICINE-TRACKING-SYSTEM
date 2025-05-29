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
    public partial class Form4 : Form
    {
        private Kullanici _kullanici;
        public Form4(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DatabaseHelper database = new DatabaseHelper();
            database.ID_BELİRLEME(_kullanici);
            database.BİLDİRİMLER(_kullanici);
            listBox1.Items.Add(_kullanici.BILDIRIMLER + "\n");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 yeniForm = new Form1(_kullanici);
            yeniForm.Show();
            this.Hide();
        }
    }
}
