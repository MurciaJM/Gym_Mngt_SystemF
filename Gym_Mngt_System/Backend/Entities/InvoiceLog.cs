using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Entities
{
    class InvoiceLog
    {
        public int invoiceId { get; set; }
        public string customerName { get; set; }
        public string staffName { get; set; }
        public decimal amount { get; set; }
        public DateTime invoiceDate { get; set; }
        public string FormattedAmount() => $"₱{amount:N2}";
        public string FormattedDate() => invoiceDate.ToString("yyyy-MM-dd");
    }
}
