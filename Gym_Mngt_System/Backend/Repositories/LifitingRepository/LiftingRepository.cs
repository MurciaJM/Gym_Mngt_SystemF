using Gym_Mngt_System.Backend.Singleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Repositories.MachineRepository
{
    class LiftingRepository : ILiftingRepository
    {
        public IEnumerable<Equipment> GetAllLiftingEquipments()
        {
            var equipmentList = new List<Equipment>();
            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"SELECT equipment_id, equipment_name, quantity, total_quantity FROM lifting_equipments";
                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                equipmentList.Add(new Equipment
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Quantity = reader.IsDBNull(2) ? 0 : reader.GetInt64(2),
                                    TotalQuantity = reader.IsDBNull(3) ? 0 : reader.GetInt64(3),
                                    Status = EquipmentStatus.Operating,
                                    IsLifting = true,
                                    Type = EquipmentType.Lifting,
                                    Brand = "N/A",
                                    Model = "N/A"
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading lifting equipment: {ex.Message}", ex);
            }
            finally
            {
                _connection.closeConnection();
            }

            return equipmentList;
        }

        public long AddLiftingEquipment(Equipment equipment)
        {
            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"INSERT INTO lifting_equipments(equipment_name, quantity, total_quantity) 
                                    OUTPUT INSERTED.equipment_id 
                                    VALUES(@name, @quantity, @totalQuantity)";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@name", equipment.Name);
                        cmd.Parameters.AddWithValue("@quantity", equipment.Quantity);
                        cmd.Parameters.AddWithValue("@totalQuantity", equipment.TotalQuantity);

                        return (long)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding lifting equipment: {ex.Message}", ex);
            }
            finally
            {
                _connection.closeConnection();
            }
        }

        public void UpdateLiftingEquipment(Equipment equipment)
        {
            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    // FIXED: Removed extra parenthesis and corrected syntax
                    string query = @"UPDATE lifting_equipments 
                                    SET equipment_name = @name, 
                                        quantity = @quantity, 
                                        total_quantity = @totalQuantity 
                                    WHERE equipment_id = @equipmentId";

                    using (var cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@equipmentId", equipment.Id);
                        cmd.Parameters.AddWithValue("@name", equipment.Name);
                        cmd.Parameters.AddWithValue("@quantity", equipment.Quantity);
                        cmd.Parameters.AddWithValue("@totalQuantity", equipment.TotalQuantity);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating lifting equipment: {ex.Message}", ex);
            }
            finally
            {
                _connection.closeConnection();
            }
        }
    }
}
