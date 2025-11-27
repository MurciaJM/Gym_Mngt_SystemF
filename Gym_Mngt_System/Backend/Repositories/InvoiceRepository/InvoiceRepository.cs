using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Singleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Repositories.InvoiceRepository
{
    class InvoiceRepository : IInvoiceRepository
    {
        public IEnumerable<InvoiceLog> invoiceLogs()
        {
            List<InvoiceLog> invoiceLogs = new List<InvoiceLog>();
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"SELECT 
                                i.invoice_id AS invoiceId,
                                COALESCE(CONCAT(m.fname, ' ',m.middle, ' ',m.lname), CONCAT(se.fname, ' ',se.middle, ' ', se.lname)) AS customerName,
                                i.invoice_date AS invoiceDate,
                                CONCAT(s.fname, ' ', s.middle, ' ', s.lname) AS staffName,
                                i.amount AS amount
                                FROM invoice i
                                INNER JOIN staff_accounts sa ON i.staff_account_id = sa.staff_account_id
                                INNER JOIN staff s ON sa.staff_id = s.staff_id
                                LEFT JOIN member_payment mp ON mp.invoice_id = i.invoice_id
                                LEFT JOIN members m ON mp.member_id = m.member_id
                                LEFT JOIN session_payment sp ON sp.invoice_id = i.invoice_id
                                LEFT JOIN sessions se ON sp.session_id = se.session_id";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                invoiceLogs.Add(new InvoiceLog
                                {
                                    invoiceId = Convert.ToInt32(reader["invoiceId"]),
                                    customerName = reader["customerName"].ToString(),
                                    invoiceDate = Convert.ToDateTime(reader["invoiceDate"]),
                                    staffName = reader["staffName"].ToString(),
                                    amount = Convert.ToDecimal(reader["amount"])
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error occurred while retrieving invoice logs.", ex);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.closeConnection();
            }
            return invoiceLogs;
        }

        public IEnumerable<MonthlyRevenue> monthlyRevenue()
        {
            List<MonthlyRevenue> monthly = new List<MonthlyRevenue>();

            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"
                    SELECT 
                        YEAR(invoice_date) AS year,
                        MONTH(invoice_date) AS month,
                        SUM(amount) AS revenue
                        FROM invoice
                        GROUP BY YEAR(invoice_date), MONTH(invoice_date)
                        ORDER BY year, month";

                    using (var cmd = new SqlCommand(query, _conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            monthly.Add(new MonthlyRevenue
                            {
                                Year = (int)reader["year"],
                                Month = (int)reader["month"],
                                Revenue = (decimal)reader["revenue"]
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException($"Database error while retrieving monthly revenue: {ex.Message}", ex);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.closeConnection();
            }
            return monthly;
        }

        public decimal TotalRevenue()
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "SELECT SUM(amount) AS totalRevenue FROM invoice";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        var totalRevenue = cmd.ExecuteScalar();

                        return totalRevenue != DBNull.Value ? Convert.ToDecimal(totalRevenue) : 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new InvalidOperationException($"Database error while calculating total revenue: {ex.Message}", ex);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.closeConnection();
            }
        }
    }
}
