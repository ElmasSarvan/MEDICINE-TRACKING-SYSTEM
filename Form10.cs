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
    public partial class Form10 : Form
    {
        
        public Form10()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 yeniform= new Form6();
            yeniform.Show();
            this.Hide();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 yeniForm = new Form9();
            yeniForm.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
