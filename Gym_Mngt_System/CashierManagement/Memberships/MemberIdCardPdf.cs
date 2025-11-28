using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.CashierManagement.Memberships
{
    class MemberIdCardPdf
    {
        /// <summary>
        /// Generate an ID card PDF saved at outputPath.
        /// Uses iTextSharp to draw a simple card: logo (optional), member name/id, qr image.
        /// </summary>
        public static void GenerateIdCard(string memberName, string memberId, string qrValue, string outputPath, byte[] qrBytes = null, string logoPath = null)
        {
            // If user provided QR bytes, use them; otherwise generate quick QR image on the fly using QRCoder (optional)
            byte[] qrPng = qrBytes;
            if (qrPng == null)
            {
                // Quick fallback (requires QRCoder) — create a small QR for embedding
                var gen = new Gym_Mngt_System.Backend.Qrcode.qrCode();
                // Attempt to create a QR using the membershipId string
                try
                {
                    // create a temporary member param
                    var m = new Gym_Mngt_System.Backend.Entities.Member { fname = memberName, lname = "", memberID = 0 };
                    qrPng = gen.generateQrCode(int.TryParse(memberId, out int idVal) ? idVal : 0, m);
                }
                catch
                {
                    qrPng = null;
                }
            }

            Rectangle idCardSize = new Rectangle(350, 220); // width, height
            Document doc = new Document(idCardSize, 10, 10, 10, 10);

            using (var fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
            {
                var writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                var cb = writer.DirectContent;
                cb.SetLineWidth(2f);
                cb.Rectangle(5, 5, idCardSize.Width - 10, idCardSize.Height - 10);
                cb.Stroke();

                // Optional logo
                if (!string.IsNullOrWhiteSpace(logoPath) && File.Exists(logoPath))
                {
                    try
                    {
                        var logo = iTextSharp.text.Image.GetInstance(logoPath);
                        logo.ScaleAbsolute(60f, 60f);
                        logo.SetAbsolutePosition(15, idCardSize.Height - 75);
                        doc.Add(logo);
                    }
                    catch { /* ignore */ }
                }

                // Title
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                var bigNameFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                Paragraph title = new Paragraph("GYM MEMBER ID", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph("\n"));

                // Member name and id (left)
                PdfPTable tbl = new PdfPTable(2);
                tbl.TotalWidth = idCardSize.Width - 20;
                tbl.LockedWidth = true;
                tbl.SetWidths(new float[] { 1.6f, 1f });

                // Left cell: text
                var leftCell = new PdfPCell();
                leftCell.Border = Rectangle.NO_BORDER;
                leftCell.VerticalAlignment = Element.ALIGN_MIDDLE;

                leftCell.AddElement(new Paragraph(memberName, bigNameFont));
                leftCell.AddElement(new Paragraph("ID: " + memberId, normalFont));
                leftCell.AddElement(new Paragraph("Valid Member", normalFont));
                leftCell.Padding = 6f;

                // Right cell: QR image
                var rightCell = new PdfPCell();
                rightCell.Border = Rectangle.NO_BORDER;
                rightCell.HorizontalAlignment = Element.ALIGN_CENTER;
                rightCell.VerticalAlignment = Element.ALIGN_MIDDLE;

                if (qrPng != null)
                {
                    try
                    {
                        var qrImg = iTextSharp.text.Image.GetInstance(qrPng);
                        qrImg.ScaleAbsolute(100f, 100f);
                        rightCell.AddElement(qrImg);
                    }
                    catch { rightCell.AddElement(new Paragraph("[QR]")); }
                }
                else
                {
                    rightCell.AddElement(new Paragraph("[QR]"));
                }

                tbl.AddCell(leftCell);
                tbl.AddCell(rightCell);

                doc.Add(tbl);

                doc.Close();
            }
        }
    }
}
