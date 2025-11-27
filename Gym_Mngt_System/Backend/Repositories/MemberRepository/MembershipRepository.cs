using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Singleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_Mngt_System.Backend.Session;
using System.Windows.Forms;

namespace Gym_Mngt_System.Backend.Repositories.MemberRepository
{
    class MembershipRepository : IMembershipRepository
    {
        public IEnumerable<Membership> GetAll()
        {
            List<Membership> membership = new List<Membership>();
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    //string query = @"SELECT ms.*, m.name AS MemberName, mt.membership_type AS MembershipType, 
                    //            FROM [Membership] ms
                    //            INNER JOIN members m ON ms.member_id = m.member_id
                    //            INNER JOIN membership_type mt ON ms.mem_type_id = mt.mem_type_id";
                    using (var cmd = new SqlCommand("sp_getAllMembership", _conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                membership.Add(new Membership
                                {
                                    memberID = Convert.ToInt32(reader["member_id"]),
                                    membershipID = Convert.ToInt32(reader["membership_id"]),
                                    memberName = reader["MemberName"].ToString(),
                                    startDate = Convert.ToDateTime(reader["date_start"]),
                                    endDate = Convert.ToDateTime(reader["date_end"]),
                                    membershipType = reader["MembershipType"].ToString(),
                                    //trainerName = reader[""].ToString(),
                                    staffInCharge = reader["staffName"].ToString(),
                                    status = reader["status"].ToString()
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
            return membership;
        }
        public IEnumerable<MembershipType> GetMembershipType()
        {
            List<MembershipType> membershipType = new List<MembershipType>();
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "SELECT * FROM membership_type WHERE mem_type_id <> 1";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                membershipType.Add(new MembershipType
                                {
                                    membershipTypeID = Convert.ToInt32(reader["mem_type_id"]),
                                    typeName = reader["membership_type"].ToString(),
                                    durationInDays = Convert.ToInt32(reader["duration"]),
                                    price = Convert.ToDecimal(reader["price"])
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
            return membershipType;
        }
        public IEnumerable<MemberLog> MemberLogs() //Retrieval of member logs
        {
            List<MemberLog> memberLogs = new List<MemberLog>();
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"SELECT a.attendance_id AS log_id, 
                            m.fname AS fname, 
                            m.middle AS middle, 
                            m.lname AS lname, 
                            a.checked_in as check_in_time 
                            FROM attendance a 
                            INNER JOIN membership ms ON a.membership_id = ms.membership_id 
                            INNER JOIN members m ON ms.member_id = m.member_id";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                memberLogs.Add(new MemberLog
                                {
                                    logId = Convert.ToInt32(reader["log_id"]),
                                    fname = reader["fname"].ToString(),
                                    middle = reader["middle"].ToString(),
                                    lname = reader["lname"].ToString(),
                                    checkInTime = Convert.ToDateTime(reader["check_in_time"])
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
            return memberLogs;
        }
        public void MemberCheckIn(Membership membershipId)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    // BUG: This should be a direct query, not a stored procedure
                    string query = "INSERT INTO attendance (membership_id, checked_in) VALUES (@membership_id, GETDATE())";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.CommandType = CommandType.Text; // Changed from StoredProcedure
                        cmd.Parameters.AddWithValue("@membership_id", membershipId.membershipID); // Changed from memberID
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
        public int addMembership(Member member)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    using (var cmd = new SqlCommand("sp_AddMembership", _conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Input parameters
                        cmd.Parameters.AddWithValue("@fname", member.fname);
                        cmd.Parameters.AddWithValue("@middle", string.IsNullOrEmpty(member.middle) ? (object)DBNull.Value : member.middle);
                        cmd.Parameters.AddWithValue("@lname", member.lname);
                        cmd.Parameters.AddWithValue("@gender", member.gender);
                        cmd.Parameters.AddWithValue("@phonenum", member.phonenum);
                        cmd.Parameters.AddWithValue("@mem_type_id", member.membershipType.membershipTypeID);
                        cmd.Parameters.AddWithValue("@staff_account_id", StaffSession.LoggedInStaff.StaffID);

                        // Output parameter
                        SqlParameter outputParam = new SqlParameter("@membership_id", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();

                        // Get the output value
                        int membershipId = Convert.ToInt32(outputParam.Value);

                        if (membershipId == 0)
                        {
                            throw new Exception("Failed to create membership - returned ID is 0");
                        }

                        return membershipId;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding membership: {ex.Message}", ex);
            }
            finally
            {
                _connection.closeConnection();
            }
        }

        public int addMemberWithTrainer(Member member, Staff trainer)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    using (var cmd = new SqlCommand("sp_AddMemberWithTrainer", _conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Input parameters
                        cmd.Parameters.AddWithValue("@fname", member.fname);
                        cmd.Parameters.AddWithValue("@middle", string.IsNullOrEmpty(member.middle) ? (object)DBNull.Value : member.middle);
                        cmd.Parameters.AddWithValue("@lname", member.lname);
                        cmd.Parameters.AddWithValue("@gender", member.gender);
                        cmd.Parameters.AddWithValue("@phonenum", member.phonenum);
                        cmd.Parameters.AddWithValue("@mem_type_id", member.membershipType.membershipTypeID);
                        cmd.Parameters.AddWithValue("@trainer_plan_id", member.planName.trainerPlanID);
                        cmd.Parameters.AddWithValue("@trainer_staff_id", trainer.StaffID);
                        cmd.Parameters.AddWithValue("@staff_account_id", StaffSession.LoggedInStaff.StaffID);

                        // Output parameter
                        SqlParameter outputParam = new SqlParameter("@membership_id", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();

                        // Get the output value
                        int membershipId = Convert.ToInt32(outputParam.Value);

                        if (membershipId == 0)
                        {
                            throw new Exception("Failed to create membership with trainer - returned ID is 0");
                        }

                        return membershipId;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding membership with trainer: {ex.Message}", ex);
            }
            finally
            {
                _connection.closeConnection();
            }
        }

        public void insertQrCode(int membershipId, byte[] qrCode)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "UPDATE membership SET qrCode = @qrCode WHERE membership_id = @membership_id";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", membershipId);
                        cmd.Parameters.Add("@qrCode", SqlDbType.VarBinary, -1).Value = qrCode;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new Exception($"No membership found with ID {membershipId} to update QR code");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting QR code: {ex.Message}", ex);
            }
            finally
            {
                _connection.closeConnection();
            }
        }
        public void updateMember(Member member)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    using (var cmd = new SqlCommand("sp_UpdateMembership", _conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        MessageBox.Show(member.memberID.ToString());
                        cmd.Parameters.AddWithValue("@member_id", member.memberID);
                        cmd.Parameters.AddWithValue("@mem_type_id", member.membershipType.membershipTypeID);
                        cmd.Parameters.AddWithValue("@staff_account_id", StaffSession.LoggedInStaff.StaffID);

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

        public bool qrCodeScanned(long membershipId)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"INSERT INTO attendance (membership_id, checked_in) 
                                    VALUES (@membership_id, GETDATE())";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", membershipId);

                        return cmd.ExecuteNonQuery() > 0;
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


        /// <summary>
        /// Retrieves QR code bytes for a specific membership
        /// </summary>
        /// <param name="membershipId">The membership ID</param>
        /// <returns>QR code as byte array, or null if not found</returns>
        public byte[] GetQrCode(int membershipId)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "SELECT qrCode FROM membership WHERE membership_id = @membership_id";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", membershipId);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return (byte[])result;
                        }

                        return null;
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

        /// <summary>
        /// Retrieves membership details by membership ID (useful for QR code scanning)
        /// </summary>
        /// <param name="membershipId">The membership ID from QR code</param>
        /// <returns>Membership object or null if not found</returns>
        public Membership GetMembershipById(int membershipId)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"SELECT ms.*, 
                            CONCAT(m.fname, ' ', m.middle, ' ', m.lname) AS MemberName,
                            mt.membership_type AS MembershipType,
                            CONCAT(s.fname, ' ', s.lname) AS staffName
                            FROM membership ms
                            INNER JOIN members m ON ms.member_id = m.member_id
                            INNER JOIN membership_type mt ON ms.mem_type_id = mt.mem_type_id
                            LEFT JOIN staff_account s ON ms.staff_account_id = s.staff_account_id
                            WHERE ms.membership_id = @membership_id";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", membershipId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Membership
                                {
                                    memberID = Convert.ToInt32(reader["member_id"]),
                                    membershipID = Convert.ToInt32(reader["membership_id"]),
                                    memberName = reader["MemberName"].ToString(),
                                    startDate = Convert.ToDateTime(reader["date_start"]),
                                    endDate = Convert.ToDateTime(reader["date_end"]),
                                    membershipType = reader["MembershipType"].ToString(),
                                    staffInCharge = reader["staffName"].ToString(),
                                    status = reader["status"].ToString()
                                };
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

            return null;
        }

        /// <summary>
        /// Checks if a QR code exists for a membership
        /// </summary>
        /// <param name="membershipId">The membership ID</param>
        /// <returns>True if QR code exists, false otherwise</returns>
        public bool QrCodeExists(int membershipId)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "SELECT COUNT(*) FROM membership WHERE membership_id = @membership_id AND qrCode IS NOT NULL";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", membershipId);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
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

        /// <summary>
        /// Updates existing QR code (useful for regeneration)
        /// </summary>
        /// <param name="membershipId">The membership ID</param>
        /// <param name="qrCode">New QR code bytes</param>
        public void UpdateQrCode(int membershipId, byte[] qrCode)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"UPDATE membership 
                            SET qrCode = @qrCode, 
                                updated_at = GETDATE() 
                            WHERE membership_id = @membership_id";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", membershipId);
                        cmd.Parameters.AddWithValue("@qrCode", qrCode);

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

        /// <summary>
        /// Validates membership status and expiry before check-in
        /// </summary>
        /// <param name="membershipId">The membership ID from QR code</param>
        /// <returns>Tuple with (isValid, message, membership)</returns>
        public (bool isValid, string message, Membership membership) ValidateMembershipForCheckIn(int membershipId)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"SELECT ms.*, 
                            CONCAT(m.fname, ' ', m.middle, ' ', m.lname) AS MemberName,
                            mt.membership_type AS MembershipType,
                            CONCAT(s.fname, ' ', s.lname) AS staffName
                            FROM membership ms
                            INNER JOIN members m ON ms.member_id = m.member_id
                            INNER JOIN membership_type mt ON ms.mem_type_id = mt.mem_type_id
                            LEFT JOIN staff_account s ON ms.staff_account_id = s.staff_account_id
                            WHERE ms.membership_id = @membership_id";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@membership_id", membershipId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var membership = new Membership
                                {
                                    memberID = Convert.ToInt32(reader["member_id"]),
                                    membershipID = Convert.ToInt32(reader["membership_id"]),
                                    memberName = reader["MemberName"].ToString(),
                                    startDate = Convert.ToDateTime(reader["date_start"]),
                                    endDate = Convert.ToDateTime(reader["date_end"]),
                                    membershipType = reader["MembershipType"].ToString(),
                                    staffInCharge = reader["staffName"].ToString(),
                                    status = reader["status"].ToString()
                                };

                                // Check if membership is expired
                                if (membership.endDate < DateTime.Now)
                                {
                                    return (false, "Membership has expired. Please renew.", membership);
                                }

                                // Check if membership is active
                                if (membership.status.ToLower() != "active")
                                {
                                    return (false, $"Membership is {membership.status}. Cannot check in.", membership);
                                }

                                return (true, "Membership is valid.", membership);
                            }
                            else
                            {
                                return (false, "Membership not found.", null);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error validating membership: {ex.Message}", ex);
            }
            finally
            {
                _connection.closeConnection();
            }
        }
    }
}
