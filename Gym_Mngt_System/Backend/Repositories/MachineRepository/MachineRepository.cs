using Gym_Mngt_System.AdminManagement.Inventory_Management;
using Gym_Mngt_System.Backend.Singleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Repositories.MachineRepository
{
    class MachineRepository : IMachineRepository
    {
        public void AddMachine(Machine machine)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"INSERT INTO machines (machine_type, category, status) 
                                     VALUES (@Type, @Category, 'Working'";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@Type", machine.Type);
                        cmd.Parameters.AddWithValue("@Category", machine.Category);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.closeConnection();
            }
        }

        public IEnumerable<Machine> GetAll()
        {
            var machineList = new List<Machine>();
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"SELECT machine_id, machine_type, category, status 
                                     FROM machines";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var machine = new Machine
                                {
                                    Id = reader.GetInt32(0),
                                    Type = reader.GetString(1),
                                    Category = reader.GetString(2),
                                    Status = (MachineStatus)Enum.Parse(typeof(MachineStatus), reader.GetString(3))
                                };
                                machineList.Add(machine);
                            }
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.closeConnection();
            }
            return machineList;
        }

        public void UpdateMachine(Machine machine)
        {
            var _connection = SingletonDB.getInstance();
            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"UPDATE machines 
                                     SET machine_type = @Type, 
                                         category = @Category, 
                                         status = @Status 
                                     WHERE machine_id = @Id";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@Type", machine.Type);
                        cmd.Parameters.AddWithValue("@Category", machine.Category);
                        cmd.Parameters.AddWithValue("@Status", machine.Status.ToString());

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
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
