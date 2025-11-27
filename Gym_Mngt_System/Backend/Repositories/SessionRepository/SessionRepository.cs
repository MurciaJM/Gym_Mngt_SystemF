using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Session;
using Gym_Mngt_System.Backend.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Repositories.SessionRepository
{
    class SessionRepository : ISessionRepository
    {
        public void addSession(Sessions session)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    using (var cmd = new System.Data.SqlClient.SqlCommand("sp_AddSession", _conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@fname", session.fname);
                        cmd.Parameters.AddWithValue("@middle", session.middle);
                        cmd.Parameters.AddWithValue("@lname", session.lname);
                        cmd.Parameters.AddWithValue("@staff_id", StaffSession.LoggedInStaff.StaffID);

                        cmd.ExecuteNonQuery();
                    }
                }
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
        public IEnumerable<Sessions> GetAll()
        {
            List<Sessions> sessions = new List<Sessions>();

            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"SELECT s.*, CONCAT(st.fname, '', st.middle, '', st.lname) AS staffName FROM Sessions s  
                        INNER JOIN session_payment sp ON s.session_id = sp.session_id
                        INNER JOIN invoice i ON sp.invoice_id = i.invoice_id
                        INNER JOIN staff_accounts sa ON i.staff_account_id = sa.staff_account_id
                        INNER JOIN staff st ON sa.staff_id = st.staff_id";

                    using (var cmd = new System.Data.SqlClient.SqlCommand(query, _conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sessions.Add(new Sessions
                                {
                                    SessionID = Convert.ToInt32(reader["session_id"]),
                                    fname = reader["fname"].ToString(),
                                    middle = reader["middle"].ToString().Trim(),
                                    lname = reader["lname"].ToString(),
                                    date = Convert.ToDateTime(reader["date"]),
                                    staffName = reader["staffName"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _connection.closeConnection();
            }
            return sessions;
        }

    }
}
