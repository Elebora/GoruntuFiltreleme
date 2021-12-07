using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;

namespace FiltreOperasyonlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // işlem dosya ve kamera olarak ayrıldı...
        }

        private void histogramEşitlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            HistogramEqualization he = new HistogramEqualization();
            if (bmp != null)
            {
                he.ApplyInPlace(bmp);
                pictureBox2.Image = bmp;
            }
            else
            {
                MessageBox.Show("Önce resim açmalısın...");
            }
        }

        private void kontrastGermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            pictureBox2.Image = null;
            ContrastStretch cs = new ContrastStretch();
            if (pictureBox1.Image != null)
            {
                cs.ApplyInPlace(bmp1);
                pictureBox2.Image = bmp1;
            }
            else
            {
                MessageBox.Show("Önce resim açmalısın...");
            }
        }

        private void dosyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.FileName = "";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
        private FilterInfoCollection CaptureDevice; // kayıtlı kamera listesi değişkeni
        private VideoCaptureDevice FinalFrame; // yakalanan görüntü değişkeni
        private void kameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[toolStripComboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += FinalFrame_NewFrame; //kamera altmenüsü işlemi fırlatıldığında
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                toolStripComboBox1.Items.Add(Device.Name);
            }
            toolStripComboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null) //picturebox2 de bir görüntü varsa
            {
                Bitmap varolan = new Bitmap(pictureBox2.Image);
                Bitmap yeni = new Bitmap(varolan);
                varolan.Save(@"C:\goruntu.png", ImageFormat.Png);
                varolan.Dispose();//bellekten alan kazanmak icin
                varolan = null;
            }
            else
            {
                MessageBox.Show("Herhangi bir görüntü işleme uygulaması çalıştırılmadı!");
            }
        }

        private void tersiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int r = 0, g = 0, b = 0;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    r = 255 - bmp.GetPixel(x, y).R;
                    g = 255 - bmp.GetPixel(x, y).G;
                    b = 255 - bmp.GetPixel(x, y).B;
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            pictureBox2.Image = bmp;
        }
    }
}
