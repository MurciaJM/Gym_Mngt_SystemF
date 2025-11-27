using Gym_Mngt_System.Backend.Service.Member_Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mngt_System.Backend.Qrcode
{
    class qrCode
    {
        public byte[] generateQrCode(int membershipId)
        {
            try
            {
                byte[] qrCodeBytes;

                using (var qrGenerator = new QRCoder.QRCodeGenerator())
                {
                    var qrData = qrGenerator.CreateQrCode(
                        membershipId.ToString(),
                        QRCoder.QRCodeGenerator.ECCLevel.Q);

                    var qrCode = new QRCoder.QRCode(qrData);

                    using (var bitmap = qrCode.GetGraphic(20))
                    {
                        using (var ms = new MemoryStream())
                        {
                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            qrCodeBytes = ms.ToArray();

                        }

                        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string fileName = $"MemberQR_{membershipId}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                        string fullPath = Path.Combine(desktopPath, fileName);

                        // Save the QR code image
                        bitmap.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);

                        // Optional: Show success message with file location
                        MessageBox.Show(
                            $"QR Code saved successfully!\n\n" +
                            $"Location: {fullPath}\n" +
                            $"Membership ID: {membershipId}",
                            "QR Code Generated",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                return qrCodeBytes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to generate QR code for membership {membershipId}: {ex.Message}", ex);
            }
        }
    }
}
