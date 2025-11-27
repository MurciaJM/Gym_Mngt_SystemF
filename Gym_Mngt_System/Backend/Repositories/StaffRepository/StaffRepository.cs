using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Repositories.Interface;
using Gym_Mngt_System.Backend.Singleton;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym_Mngt_System.Backend.Repositories
{
    class StaffRepository : IStaffRepository
    {
        public void AddStaffWithoutAccount(Staff staff)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    using (var cmd = new SqlCommand("sp_Staff", _conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@fname", staff.fname);
                        cmd.Parameters.AddWithValue("middle", staff.middle);
                        cmd.Parameters.AddWithValue("@lname", staff.lname);
                        cmd.Parameters.AddWithValue("@phoneNum", staff.phoneNumber);
                        cmd.Parameters.AddWithValue("@birthdate", staff.birthdate);
                        cmd.Parameters.AddWithValue("@gender", staff.gender);
                        cmd.Parameters.AddWithValue("@position", staff.position);
                        cmd.Parameters.AddWithValue("@schedule_date", staff.scheduleDate);
                        cmd.Parameters.AddWithValue("@start_time", staff.startTime);
                        cmd.Parameters.AddWithValue("@end_time", staff.endTime); //add endtime and starttime to stored procedure.

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
        public void AddStaffWithAccount(Staff staff)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    using (var cmd = new SqlCommand("sp_StaffwithAccount", _conn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@fname", staff.fname);
                        cmd.Parameters.AddWithValue("middle", staff.middle);
                        cmd.Parameters.AddWithValue("@lname", staff.lname);
                        cmd.Parameters.AddWithValue("@birthdate", staff.birthdate);
                        cmd.Parameters.AddWithValue("@gender", staff.gender);
                        cmd.Parameters.AddWithValue("@phoneNum", staff.phoneNumber);
                        cmd.Parameters.AddWithValue("@position", staff.position);
                        cmd.Parameters.AddWithValue("@schedule_date", staff.scheduleDate);
                        cmd.Parameters.AddWithValue("@start_time", staff.startTime); 
                        cmd.Parameters.AddWithValue("@end_time", staff.endTime); //add endtime and starttime to stored procedure.
                        cmd.Parameters.AddWithValue("@username", staff.account.Username);
                        cmd.Parameters.AddWithValue("@password", staff.account.Password);

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

        public void updateStaff(Staff staff)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    using (var cmd = new SqlCommand("sp_UpdateStaff", _conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@staffID", staff.StaffID);
                        cmd.Parameters.AddWithValue("@fname", staff.fname);
                        cmd.Parameters.AddWithValue("middle", staff.middle);
                        cmd.Parameters.AddWithValue("@lname", staff.lname);
                        cmd.Parameters.AddWithValue("@birthdate", staff.birthdate);
                        cmd.Parameters.AddWithValue("@gender", staff.gender);
                        cmd.Parameters.AddWithValue("@phoneNum", staff.phoneNumber);
                        cmd.Parameters.AddWithValue("@position", staff.position);
                        cmd.Parameters.AddWithValue("@status", staff.status);

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
        public Staff GetTrainerWithMembers(Staff staff)
        {
            List<Member> TrainerWithMember = new List<Member>();
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "select mi.*, m.name from member_info mi INNER JOIN members m ON mi.member_id = m.member_id where staff_id = 2";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TrainerWithMember.Add(Member.Builder()
                                    .withFname(reader["m.fname"].ToString())
                                    .withMiddleName(reader["m.middle"].ToString().Trim())
                                    .withLname(reader["m.lname"].ToString())
                                    .Build());
                                    
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
            return Staff.Builder().
                withStaffID(staff.StaffID).
                withFname(staff.fname).
                withMiddleName(staff.middle).
                withLname(staff.lname).
                withBirthdate(staff.birthdate).
                withGender(staff.gender).
                withPhoneNumber(staff.phoneNumber).
                withPosition(staff.position).
                withHiredDate(staff.hiredDate).
                withScheduleDate(staff.scheduleDate).
                withStatus(staff.status).
                withMemberTrainer(TrainerWithMember).
                Build();

        }
        public IEnumerable<Staff> GetAllTrainer()
        {
            List<Staff> staffs = new List<Staff>();
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"SELECT s.*, 
                                CONCAT(sc.days, ', ', FORMAT(CAST(sc.start_time AS datetime), 'hh:mm tt'), ' - ', FORMAT(CAST(sc.end_time AS datetime), 'hh:mm tt') ) AS scheduleDate
                                FROM Staff s INNER JOIN schedule sc ON s.staff_id = sc.staff_id WHERE position = 'Trainer'";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                staffs.Add(Staff.Builder().
                                    withStaffID(Convert.ToInt32(reader["staff_id"])).
                                    withFname(reader["fname"].ToString()).
                                    withMiddleName(reader["middle"].ToString().Trim()).
                                    withLname(reader["lname"].ToString()).
                                    withBirthdate(Convert.ToDateTime(reader["birth_date"])).
                                    withGender(reader["gender"].ToString()).
                                    withPhoneNumber(reader["phoneNum"].ToString()).
                                    withScheduleDate(reader["scheduleDate"].ToString()).
                                    withPosition(reader["position"].ToString()).
                                    withHiredDate(Convert.ToDateTime(reader["hiredDate"])).
                                    withStatus(reader["status"].ToString()).
                                    Build());
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
            return staffs;
        }

        public IEnumerable<TrainerPlan> GetTrainerPlans()
        {
            List<TrainerPlan> trainerPlans = new List<TrainerPlan>();
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "SELECT *, price - (price * 0.10) AS discountedprice FROM trainer_plan";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                trainerPlans.Add(new TrainerPlan
                                {
                                    trainerPlanID = Convert.ToInt32(reader["trainer_plan_id"]),
                                    planName = reader["trainer_plan"].ToString(),
                                    durationInDays = Convert.ToInt32(reader["duration"]),
                                    price = Convert.ToDecimal(reader["discountedprice"])
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
            return trainerPlans;
        }
        public Staff GetTrainerWithTrainees(int staffId)
        {
            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"
        SELECT 
            st.staff_id,
            st.fname AS staff_fname,
            st.middle AS staff_middle,
            st.lname AS staff_lname,
            st.birth_date,
            st.gender,
            st.phoneNum,
            st.position,
            st.hiredDate,
            st.status,
            CONCAT(s.days, ', ', FORMAT(CAST(s.start_time AS datetime), 'hh:mm tt'), ' - ', FORMAT(CAST(s.end_time AS datetime), 'hh:mm tt') ) AS scheduleDate,
            mi.member_id,
            mi.staff_id as member_info_staff_id,  -- ADD THIS
            m.fname AS member_fname,
            m.middle AS member_middle,
            m.lname AS member_lname,
            tp.trainer_plan_id,
            tp.trainer_plan
        FROM staff st
        INNER JOIN schedule s ON st.staff_id = s.staff_id
        LEFT JOIN member_info mi ON mi.staff_id = st.staff_id
        LEFT JOIN members m ON mi.member_id = m.member_id
        LEFT JOIN trainer_plan tp ON mi.trainer_plan_id = tp.trainer_plan_id
        WHERE st.position = 'Trainer' AND st.staff_id = @staffId
        ORDER BY st.staff_id";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@staffId", staffId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            Staff trainer = null;
                            int rowCount = 0;

                            // ADD THIS - Check if query returns any rows at all
                            if (!reader.HasRows)
                            {
                                System.Diagnostics.Debug.WriteLine("Query returned NO ROWS!");
                                return null;
                            }

                            while (reader.Read())
                            {
                                rowCount++;

                                // ADD THIS DEBUG
                                System.Diagnostics.Debug.WriteLine($"Row {rowCount}:");
                                System.Diagnostics.Debug.WriteLine($"  member_id: {reader["member_id"]}");
                                System.Diagnostics.Debug.WriteLine($"  member_info_staff_id: {reader["member_info_staff_id"]}");
                                System.Diagnostics.Debug.WriteLine($"  Is member_id DBNull? {reader["member_id"] == DBNull.Value}");

                                if (trainer == null)
                                {
                                    trainer = Staff.Builder()
                                        .withStaffID(Convert.ToInt32(reader["staff_id"]))
                                        .withFname(reader["staff_fname"].ToString())
                                        .withMiddleName(reader["staff_middle"].ToString())
                                        .withLname(reader["staff_lname"].ToString())
                                        .withBirthdate(Convert.ToDateTime(reader["birth_date"]))
                                        .withGender(reader["gender"].ToString())
                                        .withPhoneNumber(reader["phoneNum"].ToString())
                                        .withPosition(reader["position"].ToString())
                                        .withHiredDate(Convert.ToDateTime(reader["hiredDate"]))
                                        .withStatus(reader["status"].ToString())
                                        .withScheduleDate(reader["scheduleDate"].ToString())
                                        .withMemberTrainer(new List<Member>())
                                        .Build();

                                    System.Diagnostics.Debug.WriteLine($"Trainer loaded: {trainer.getFullname()}");
                                }

                                // Check if member exists
                                if (reader["member_id"] != DBNull.Value)
                                {
                                    var memberFname = reader["member_fname"].ToString();
                                    var memberMiddle = reader["member_middle"].ToString();
                                    var memberLname = reader["member_lname"].ToString();

                                    System.Diagnostics.Debug.WriteLine($"Found member: {memberFname} {memberMiddle} {memberLname}");

                                    var trainerPlan = new TrainerPlan
                                    {
                                        trainerPlanID = reader["trainer_plan_id"] != DBNull.Value
                                            ? Convert.ToInt32(reader["trainer_plan_id"])
                                            : 0,
                                        planName = reader["trainer_plan"] != DBNull.Value
                                            ? reader["trainer_plan"].ToString()
                                            : ""
                                    };

                                    var member = Member.Builder()
                                        .withMemberID(Convert.ToInt32(reader["member_id"]))
                                        .withFname(memberFname)
                                        .withMiddleName(memberMiddle)
                                        .withLname(memberLname)
                                        .withTrainerPlan(trainerPlan)
                                        .Build();

                                    trainer.memberWithTrainer.Add(member);
                                    System.Diagnostics.Debug.WriteLine($"Added member. Total count: {trainer.memberWithTrainer.Count}");
                                }
                                else
                                {
                                    System.Diagnostics.Debug.WriteLine("member_id is NULL - no trainee in this row");
                                }
                            }

                            System.Diagnostics.Debug.WriteLine($"Total rows read: {rowCount}");
                            System.Diagnostics.Debug.WriteLine($"Final member count: {trainer?.memberWithTrainer?.Count ?? 0}");

                            return trainer;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in GetTrainerWithTrainees: {ex.Message}");
                throw;
            }
            finally
            {
                _connection.closeConnection();
            }
        }

        public IEnumerable<Staff> GetAll()
        {
            List<Staff> staffs = new List<Staff>();
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"SELECT 
                                s.*, 
                                CONCAT(
                                    sch.days, ', ', 
                                    FORMAT(CAST(sch.start_time AS datetime), 'hh:mm tt'), 
                                    ' - ', 
                                    FORMAT(CAST(sch.end_time AS datetime), 'hh:mm tt')
                                ) AS scheduleDate 
                            FROM Staff s 
                            INNER JOIN schedule sch ON s.staff_id = sch.staff_id 
                            WHERE position <> 'Admin'";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                staffs.Add(Staff.Builder().
                                    withStaffID(Convert.ToInt32(reader["staff_id"])).
                                    withFname(reader["fname"].ToString()).
                                    withMiddleName(reader["middle"].ToString().Trim()).
                                    withLname(reader["lname"].ToString()).
                                    withBirthdate(Convert.ToDateTime(reader["birth_date"])).
                                    withGender(reader["gender"].ToString()).
                                    withPhoneNumber(reader["phoneNum"].ToString()).
                                    withScheduleDate(reader["scheduleDate"].ToString()).
                                    withPosition(reader["position"].ToString()).
                                    withHiredDate(Convert.ToDateTime(reader["hiredDate"])).
                                    withStatus(reader["status"].ToString()).
                                    Build());
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
            return staffs;
        }

        public bool usernameExists(string username, int? staffid = null) 
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query;

                    if (staffid.HasValue)
                        query = "SELECT 1 FROM Accounts WHERE username = @username AND staff_id <> @staff_id";
                    else
                        query = "SELECT 1 FROM Accounts WHERE username = @username";
                    
                    using(var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        if (staffid.HasValue)
                            cmd.Parameters.AddWithValue("@staff_id", staffid);
                        
                        object result = cmd.ExecuteScalar();
                        return result != null;
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

        public Staff staffWithAccount(Staff staff)
        {
            MessageBox.Show("Attempting to validate login for user: " + staff.account.Username);
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    using (var cmd = new SqlCommand("sp_ValidateLogin", _conn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@username", staff.account.Username);
                        cmd.Parameters.AddWithValue("@password", staff.account.Password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("User found : " + reader["fname"].ToString());
                                return Staff.Builder().
                                    withStaffID(Convert.ToInt32(reader["staff_id"])).
                                    withFname(reader["fname"].ToString()).
                                    withMiddleName(reader["middle"].ToString().Trim()).
                                    withLname(reader["lname"].ToString()).
                                    withBirthdate(Convert.ToDateTime(reader["birth_date"])). 
                                    withGender(reader["gender"].ToString()).
                                    withPhoneNumber(reader["phoneNum"].ToString()).
                                    withScheduleDate(reader["days"].ToString()).
                                    withPosition(reader["position"].ToString()).
                                    withHiredDate(Convert.ToDateTime(reader["hiredDate"])).
                                    withStatus(reader["status"].ToString()).
                                    Build();
                            }
                            else
                            {
                                MessageBox.Show("No user found with the provided credentials.");
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
    }
}
