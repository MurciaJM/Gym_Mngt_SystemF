using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QRCoder;
using System.Diagnostics;
using System.Drawing.Drawing2D;


namespace Gym_Mngt_System.Memberships
{
    public partial class GenerateQrFrm : Form
    {
        public GenerateQrFrm()
        {
            InitializeComponent();

            RoundFormCorners(50);

        }


        private void RoundFormCorners(int radius)
        {
            var path = new GraphicsPath();
            path.StartFigure();


            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);

            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);

            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);

            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);

            path.CloseFigure();
            Region = new Region(path);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            string membershipId = "MEM" + DateTime.Now.ToString("yyyyMMddHHmmss");

            
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(membershipId, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrImage = qrCode.GetGraphic(5);

          
            pictureBoxQR.Image = qrImage;

       
            string folderPath = @"C:\Users\Owner\Downloads\Gym_Mngt_System (2)\Gym_Mngt_System\QR's";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            
            string filePath = Path.Combine(folderPath, $"{membershipId}.png");

            
            qrImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

             
            MessageBox.Show($"Auto-generated ID: {membershipId}\nQR Code saved at:\n{filePath}",
                            "QR Code Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);

             
            Process.Start("explorer.exe", folderPath);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateQrFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
