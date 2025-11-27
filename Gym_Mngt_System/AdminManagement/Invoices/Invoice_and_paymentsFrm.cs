using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Gym_Mngt_System.Backend.Exceptions;
using Gym_Mngt_System.Backend.Service.Invoice_Service;
using Gym_Mngt_System.Invoices;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Gym_Mngt_System
{
    public partial class Invoice_and_paymentsFrm : Form
    {
        private readonly Dictionary<Control, Point> originalLocations = new Dictionary<Control, Point>();
        private readonly Dictionary<Control, int> currentOffsets = new Dictionary<Control, int>();
        private readonly Dictionary<Control, Control> linkedControls = new Dictionary<Control, Control>();
        private readonly InvoiceService _invoiceService;
        private List<InvoiceCard> _allInvoices = new List<InvoiceCard>();

        private Timer hoverTimer;

        private const int HoverAmount = -6;
        private const int Step = 1;

        public Invoice_and_paymentsFrm()
        {
            InitializeComponent();
            InitializeHoverEffects();

            btnAddMachine.Click += btnAddMachine_Click;

            _invoiceService = new InvoiceService();
        }

        private void InitializeHoverEffects()
        {

            RegisterControlPosition(btnTotalRevenue, lblTotalRevenue);
            RegisterControlPosition(btnTotalInvoice, lblTotalInvoices);


            hoverTimer = new Timer { Interval = 15 };
            hoverTimer.Tick += HoverTimer_Tick;


            RegisterHoverEffect(btnTotalRevenue);
            RegisterHoverEffect(btnTotalInvoice);
        }

        private void RegisterControlPosition(Control button, Control label)
        {
            originalLocations[button] = button.Location;
            originalLocations[label] = label.Location;
            currentOffsets[button] = 0;
            currentOffsets[label] = 0;
            linkedControls[button] = label;
        }

        private void RegisterHoverEffect(Control control)
        {
            control.MouseEnter += (s, e) =>
            {
                control.Tag = HoverAmount;
                if (linkedControls.ContainsKey(control))
                    linkedControls[control].Tag = HoverAmount;

                hoverTimer.Start();
            };

            control.MouseLeave += (s, e) =>
            {
                control.Tag = 0;
                if (linkedControls.ContainsKey(control))
                    linkedControls[control].Tag = 0;

                hoverTimer.Start();
            };
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            bool anyAnimating = false;

            foreach (var control in originalLocations.Keys)
            {
                int targetOffset = (control.Tag is int tag) ? tag : 0;
                int currentOffset = currentOffsets[control];


                if (currentOffset < targetOffset)
                    currentOffset += Step;
                else if (currentOffset > targetOffset)
                    currentOffset -= Step;

                currentOffsets[control] = currentOffset;


                Point originalPosition = originalLocations[control];
                control.Location = new Point(originalPosition.X, originalPosition.Y + currentOffset);


                if (currentOffset != targetOffset)
                    anyAnimating = true;
            }

            if (!anyAnimating)
                hoverTimer.Stop();
        }

        private void SearchInvoices(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                foreach (InvoiceCard card in flowInvoices.Controls)
                {
                    card.Visible = true;
                }
                return;
            }

            keyword = keyword.Trim();

            foreach (InvoiceCard card in flowInvoices.Controls)
            {
                bool isVisible =
                    card.Customer.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    card.staff.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    card.InvoiceID.ToString().Contains(keyword);

                card.Visible = isVisible;
            }
        }
        private void LoadRevenueSummary()
        {
            try
            {
                decimal totalRevenue = _invoiceService.TotalRevenue();
                lblTotalRevenue.Text = $"₱{totalRevenue:N2}";

                var monthlyRevenues = _invoiceService.GetMonthlyRevenue();
                decimal total = monthlyRevenues.Sum(x => x.Revenue);

                lblTotalInvoices.Text = $"₱{total:N2}";
            }
            catch
            {
                throw new DetailsNotFound("Failed to load revenue summary.");
            }
        }
        private InvoiceCard createCard(string invoiceId, string customer, string amount, string staffName, string date)
        {
            return new InvoiceCard
            {
                InvoiceID = int.Parse(invoiceId),
                Customer = customer ?? "N/A",
                Amount = decimal.Parse(amount),
                staff = staffName ?? "N/A",
                Date = date ?? "N/A"
            };
        }
        private void displayLogs(List<InvoiceCard> invoices)
        {
            flowInvoices.SuspendLayout();
            flowInvoices.Controls.Clear();

            if (invoices == null || invoices.Count == 0)
            {
                var noDataLabel = new Label
                {
                    Text = "No invoices found",
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Padding = new Padding(20)
                };
                flowInvoices.Controls.Add(noDataLabel);
            }
            else
            {
                foreach (var card in invoices)
                {
                    flowInvoices.Controls.Add(card);
                }
            }

            flowInvoices.ResumeLayout();
        }
        private void LoadInvoiceLogs()
        {
            try
            {
                _allInvoices.Clear();

                var invoices = _invoiceService.GetInvoiceLogs();

                foreach (var invoice in invoices)
                {
                    var card = createCard(
                        invoice.invoiceId.ToString(),
                        invoice.customerName,
                        invoice.amount.ToString(),  // Pass raw decimal value
                        invoice.staffName,
                        invoice.FormattedDate()
                    );
                    _allInvoices.Add(card);
                }

                displayLogs(_allInvoices);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load invoice logs: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Invoice_and_paymentsFrm_Load(object sender, EventArgs e)
        {
            LoadInvoiceLogs();
            LoadRevenueSummary();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchInvoices(tbSearch.Text);
        }

        private void flowInvoices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            ExportMonthlyRevenuePdf();
        }
        private void ExportMonthlyRevenuePdf()
        {
            try
            {
                var monthlyData = _invoiceService.GetMonthlyRevenue().ToList();
                if (monthlyData.Count == 0)
                {
                    MessageBox.Show("No monthly revenue data found.", "Export Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "PDF File|*.pdf",
                    FileName = $"Monthly_Revenue_Report_{DateTime.Now:yyyyMMdd}.pdf"
                };

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;

                string path = saveDialog.FileName;

                Document doc = new Document(PageSize.A4, 30, 30, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();

                // ======================
                // Title Section
                // ======================
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Paragraph header = new Paragraph("MONTHLY SALES ACTIVITY REPORT\n\n", titleFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(header);


                // ======================
                // Table Setup
                // ======================
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 1.5f, 2f, 1.5f, 2f, 2f });

                BaseColor darkBlue = new BaseColor(40, 50, 70);
                BaseColor greyHeader = new BaseColor(230, 230, 230);

                var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, BaseColor.WHITE);
                var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);

                // ======================
                // Header Row
                // ======================
                string[] headers = { "YEAR", "MONTH", "QUARTER", "REVENUE", "PROJECTED" };

                foreach (string col in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(col, headerFont))
                    {
                        BackgroundColor = darkBlue,
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        Padding = 6
                    };
                    table.AddCell(cell);
                }

                // ======================
                // Body Rows (Alternating Colors)
                // ======================

                bool useGrey = false;

                foreach (var m in monthlyData)
                {
                    BaseColor rowColor = useGrey ? greyHeader : BaseColor.WHITE;
                    useGrey = !useGrey;

                    string monthName = new DateTime(m.Year, m.Month, 1).ToString("MMM");
                    string quarter = GetQuarter(m.Month);

                    AddBodyCell(table, m.Year.ToString(), rowColor, bodyFont);
                    AddBodyCell(table, monthName, rowColor, bodyFont);
                    AddBodyCell(table, quarter, rowColor, bodyFont);
                    AddBodyCell(table, $"₱{m.Revenue:N2}", rowColor, bodyFont);
                    AddBodyCell(table, $"₱{(m.Revenue * 1.05m):N2}", rowColor, bodyFont); // Example projected
                }

                doc.Add(table);


                // ======================
                // Summary Section (Styled Grey Box)
                // ======================
                decimal totalRevenue = monthlyData.Sum(x => x.Revenue);
                decimal projected = totalRevenue * 1.05m;

                PdfPTable summary = new PdfPTable(2);
                summary.WidthPercentage = 50;
                summary.HorizontalAlignment = Element.ALIGN_RIGHT;
                summary.SetWidths(new float[] { 3f, 3f });

                var sumHeaderFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var sumValueFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);

                summary.AddCell(new PdfPCell(new Phrase("REVENUE TOTAL", sumHeaderFont))
                {
                    BackgroundColor = greyHeader,
                    Padding = 8
                });

                summary.AddCell(new PdfPCell(new Phrase($"₱{totalRevenue:N2}", sumValueFont))
                {
                    BackgroundColor = BaseColor.WHITE,
                    Padding = 8
                });

                doc.Add(new Paragraph("\n"));
                doc.Add(summary);

                // Close
                doc.Close();

                Process.Start(path);

                MessageBox.Show("Report exported successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to export: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ==========================================
        // Helper: Adds styled cell
        // ==========================================
        private void AddBodyCell(PdfPTable table, string text, BaseColor bg, iTextSharp.text.Font font)
        {
            table.AddCell(new PdfPCell(new Phrase(text, font))
            {
                BackgroundColor = bg,
                Padding = 6,
                HorizontalAlignment = Element.ALIGN_CENTER
            });
        }

        // ==========================================
        // Helper: Convert Month → Quarter
        // ==========================================
        private string GetQuarter(int month)
        {
            if (month <= 3) return "Q1";
            if (month <= 6) return "Q2";
            if (month <= 9) return "Q3";
            return "Q4";
        }
    }
}