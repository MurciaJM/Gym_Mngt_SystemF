using Gym_Mngt_System.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Repositories.InvoiceRepository
{
    interface IInvoiceRepository
    {
        IEnumerable<InvoiceLog> invoiceLogs();
        IEnumerable<MonthlyRevenue> monthlyRevenue();
        decimal TotalRevenue();
    }
}
