using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace İLAÇ_TAKİP_SİSTEMİ
{

        public partial class Form2 : Form
        {
        private Kullanici _kullanici;
        public Form2(Kullanici kullanici)
        {
             InitializeComponent();
            _kullanici = kullanici;
        }
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private string scannedBarcode = "";


        private void KameraBaşlat()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Kamera bulunamadı!");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.Image = bitmap;

            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null)
            {
                scannedBarcode = result.Text;
                _kullanici.barkod = scannedBarcode;

                // Kamerayı durdur
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.NewFrame -= video_NewFrame;
                }

                // Barkod göster
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Okunan Barkod: " + scannedBarcode);
                }));
                _kullanici.barkod = scannedBarcode;
                // Veritabanından veri getir
                DatabaseHelper database = new DatabaseHelper();
                database.VeriGetir2(_kullanici);
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.NewFrame -= video_NewFrame;
            }
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 yeniForm = new Form1(_kullanici);
            yeniForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           
            pictureBox2.Visible = true;
            KameraBaşlat();
            
            
        }
    }
}
