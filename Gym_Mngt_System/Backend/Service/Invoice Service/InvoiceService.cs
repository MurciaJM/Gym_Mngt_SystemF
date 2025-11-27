using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Exceptions;
using Gym_Mngt_System.Backend.Repositories.InvoiceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Service.Invoice_Service
{
    class InvoiceService
    {
        private readonly InvoiceRepository _invoiceRepo = new InvoiceRepository();
        public IEnumerable<InvoiceLog> GetInvoiceLogs()
        {
            try
            {
                return _invoiceRepo.invoiceLogs();
            }
            catch (DetailsNotFound)
            {
                throw new DetailsNotFound("Failed to retrieve invoice logs.");
            }
        }
        public IEnumerable<MonthlyRevenue> GetMonthlyRevenue()
        {
            try
            {
                return _invoiceRepo.monthlyRevenue();
            }
            catch (DetailsNotFound)
            {
                throw new DetailsNotFound("Failed to retrieve monthly revenue.");
            }
        }
        public decimal TotalRevenue()
        {
            return _invoiceRepo.TotalRevenue();
        }
    }
}
