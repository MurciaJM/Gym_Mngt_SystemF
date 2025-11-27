using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;

namespace Gym_Mngt_System.CashierManagement.MemberLogs
{
    public partial class qrScanner: Form
    {
        private Timer timer;
        private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;

        public string ScannedText { get; private set; }
        public qrScanner()
        {
            InitializeComponent();
        }

        private void qrScanner_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No camera found.");
                Close();
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

            videoSource.NewFrame += (s, args) =>
            {
                Bitmap bitmap = (Bitmap)args.Frame.Clone();
                pictureBox1.Image = bitmap;
            };

            videoSource.Start();

            timer = new Timer();
            timer.Interval = 500; // Scan every 500 milliseconds
            timer.Tick += ScanQrCode;
            timer.Start();
        }
        private void ScanQrCode(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            var reader = new ZXing.BarcodeReader();
            var result = reader.Decode((Bitmap)pictureBox1.Image);
            if (result != null)
            {
                ScannedText = result.Text;
                timer.Stop();
                videoSource.SignalToStop();
                MessageBox.Show($"Scanned QR Code: {ScannedText}");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void qrScanner_FormClosing(object sender, FormClosingEventArgs e)
        {   
            if(videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
            }
        }

        private void importQr_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);

                    var reader = new ZXing.BarcodeReader();
                    var result = reader.Decode((Bitmap)pictureBox1.Image);

                    if (result != null)
                    {
                        ScannedText = result.Text;
                        MessageBox.Show("QR Code Scanned!\n\nResult: " + ScannedText);

                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No QR code detected in the image.");
                    }
                }
            }
        }
    }
}
