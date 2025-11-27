using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mngt_System.Invoices
{
    public partial class InvoiceCard : UserControl
    {
        private const string InvoicePrefix = "INV-";
        public InvoiceCard()
        {
            InitializeComponent();
        }

        public int InvoiceID
        {
            get => InvoiceId(lblInvoiceID.Text);
            set => lblInvoiceID.Text = $"{InvoicePrefix}{value}";
        }

        public string Customer
        {
            get => lblMember.Text;
            set => lblMember.Text = value;
        }

        public decimal Amount
        {
            get => ToAmount(lblAmount.Text);
            set => lblAmount.Text = $"₱{value:N2}";
        }

        public string Date
        {
            get => lblDate.Text;
            set => lblDate.Text = value;
        }
        public string staff
        {
            get => lblStaff.Text;
            set => lblStaff.Text = value;
        }
        //public string Status
        //{
        //    get => lblStatus.Text;
        //    set
        //    {
        //        lblStatus.Text = value;


        //        if (value == "Paid") lblStatus.ForeColor = Color.Green;
        //        else if (value == "Pending") lblStatus.ForeColor = Color.Red;
        //        else lblStatus.ForeColor = Color.Red;
        //    }
        //}
        private int InvoiceId(string invoiceId)
        {
            if (string.IsNullOrWhiteSpace(invoiceId))
                return 0;

            string numericPart = invoiceId.Replace(InvoicePrefix, string.Empty).Trim();
            return int.TryParse(numericPart, out int id) ? id : 0;
        }
        private decimal ToAmount(string amount)
        {
            if (string.IsNullOrWhiteSpace(amount))
                return 0m;

            string numericPart = amount.Replace("₱", string.Empty)
                                       .Replace(",", string.Empty)
                                       .Trim();
            return decimal.TryParse(numericPart, out decimal amt) ? amt : 0m;
        }
        public InvoiceCard(string invoiceId, string member, string amount, string staffName, string date) : this()
        {
            InvoiceID = InvoiceId(invoiceId);
            Customer = member;
            Amount = ToAmount(amount);
            staff = staffName;
            Date = date;
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
