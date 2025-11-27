using Guna.UI2.WinForms;
using Gym_Mngt_System.Backend.Singleton;
using Gym_Mngt_System.CashierManagement.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mngt_System
{
    public partial class Inventory : Form
    {
        private int navAnimationSpeed = 8;
        private List<EquipmentCheckData> equipmentCheckList = new List<EquipmentCheckData>();
        private List<MachineCheckData> machineCheckList = new List<MachineCheckData>();

        public Inventory()
        {
            InitializeComponent();
            LoadMachineChecks();
            LoadEquipmentChecks();
            RefreshMachineChecksDisplay();
            RefreshEquipmentChecksDisplay();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
        }

        private FlowLayoutPanel FindFlowPanel(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is FlowLayoutPanel)
                    return (FlowLayoutPanel)ctrl;

                var result = FindFlowPanel(ctrl);
                if (result != null)
                    return result;
            }
            return null;
        }

        public class InventoryCheck
        {
            public string MachineName { get; set; }
            public string Staff { get; set; }
            public DateTime Date { get; set; }
        }

        public class EquipmentCheckData
        {
            public string EquipmentName { get; set; }
            public string CheckedBy { get; set; }
            public string Quantity { get; set; }
            public string TotalQuanti { get; set; }
            public DateTime CheckDate { get; set; }
            public Padding Margin { get; internal set; }

            public void SetData(string equipmentName, string checkedBy, string quantity, string totalQuanti, DateTime checkDate)
            {
                EquipmentName = equipmentName;
                CheckedBy = checkedBy;
                Quantity = quantity;
                TotalQuanti = totalQuanti;
                CheckDate = checkDate;
            }
        }

        public class MachineCheckData
        {
            public string MachineType { get; set; }
            public string CheckedBy { get; set; }
            public string Category { get; set; }
            public string Status { get; set; }
            public DateTime CheckDate { get; set; }
            public Padding Margin { get; internal set; }

            public void SetData(string machineType, string checkedBy, string status, string category, DateTime checkDate)
            {
                MachineType = machineType;
                CheckedBy = checkedBy;
                Status = status;
                Category = category;
                CheckDate = checkDate;
            }
        }

        public void LoadMachineChecks()
        {
            machineCheckList.Clear();

            string query = @"
                SELECT 
                    i.inventory_id,
                    i.date_checked,
                    CONCAT(s.fname, ' ', ISNULL(s.middle, ''), ' ', s.lname) AS staff_name,
                    m.machine_type,
                    m.category,
                    m.status AS machine_status
                FROM inventory i
                LEFT JOIN staff s ON i.staff_id = s.staff_id
                LEFT JOIN machineEquipmentLog mel ON mel.inventory_id = i.inventory_id
                LEFT JOIN machines m ON m.machine_id = mel.machine_id
                WHERE m.machine_id IS NOT NULL
                ORDER BY i.date_checked DESC;
            ";

            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var machineCard = new MachineCheckData
                            {
                                MachineType = reader["machine_type"] != DBNull.Value ? reader["machine_type"].ToString() : "Unknown",
                                CheckedBy = reader["staff_name"] != DBNull.Value ? reader["staff_name"].ToString() : "Unknown",
                                Category = reader["category"] != DBNull.Value ? reader["category"].ToString() : "Unknown",
                                Status = reader["machine_status"] != DBNull.Value ? reader["machine_status"].ToString() : "Unknown",
                                CheckDate = Convert.ToDateTime(reader["date_checked"])
                            };

                            machineCheckList.Add(machineCard);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading machine checks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadEquipmentChecks()
        {
            equipmentCheckList.Clear();

            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"
                        SELECT 
                            i.inventory_id,
                            i.date_checked,
                            CONCAT(s.fname, ' ', ISNULL(s.middle, ''), ' ', s.lname) AS staff_name,
                            le.equipment_name,
                            le.quantity,
                            le.total_quantity
                        FROM inventory i
                        LEFT JOIN staff s ON i.staff_id = s.staff_id
                        LEFT JOIN liftingEquipmentLog lel ON lel.inventory_id = i.inventory_id
                        LEFT JOIN lifting_equipments le ON le.equipment_id = lel.equipment_id
                        WHERE le.equipment_id IS NOT NULL
                        ORDER BY i.date_checked DESC;
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var equipmentCard = new EquipmentCheckData
                            {
                                EquipmentName = reader["equipment_name"] != DBNull.Value ? reader["equipment_name"].ToString() : "Unknown",
                                CheckedBy = reader["staff_name"] != DBNull.Value ? reader["staff_name"].ToString() : "Unknown",
                                Quantity = reader["quantity"] != DBNull.Value ? reader["quantity"].ToString() : "0",
                                TotalQuanti = reader["total_quantity"] != DBNull.Value ? reader["total_quantity"].ToString() : "0",
                                CheckDate = Convert.ToDateTime(reader["date_checked"])
                            };

                            equipmentCheckList.Add(equipmentCard);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading equipment checks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshMachineChecksDisplay()
        {
            if (flpMachineRecentChecks == null)
            {
                MessageBox.Show("Machine checks panel not found!", "Error");
                return;
            }

            flpMachineRecentChecks.Controls.Clear();

            if (machineCheckList.Count == 0)
            {
                Label noDataLabel = new Label
                {
                    Text = "No machine checks recorded yet.",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 10),
                    Padding = new Padding(10)
                };
                flpMachineRecentChecks.Controls.Add(noDataLabel);
                return;
            }

            foreach (var card in machineCheckList)
            {
                var machineCard = new MachineCheckCard();
                machineCard.SetData(card.MachineType, card.CheckedBy, card.Status, card.Category, card.CheckDate);
                flpMachineRecentChecks.Controls.Add(machineCard);
            }

            flpMachineRecentChecks.AutoScrollPosition = new Point(0, 0);
        }

        public void RefreshEquipmentChecksDisplay()
        {
            if (flpEquipmentRecentChecks == null)
            {
                MessageBox.Show("Equipment checks panel not found!", "Error");
                return;
            }

            flpEquipmentRecentChecks.Controls.Clear();

            if (equipmentCheckList.Count == 0)
            {
                Label noDataLabel = new Label
                {
                    Text = "No equipment checks recorded yet.",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 10),
                    Padding = new Padding(10)
                };
                flpEquipmentRecentChecks.Controls.Add(noDataLabel);
                return;
            }

            foreach (var card in equipmentCheckList)
            {
                var CheckCard = new EquipmentCheckCard();
                CheckCard.SetData(card.EquipmentName, card.CheckedBy, card.Quantity, card.TotalQuanti, card.CheckDate);
                flpEquipmentRecentChecks.Controls.Add(CheckCard);
            }

            flpEquipmentRecentChecks.AutoScrollPosition = new Point(0, 0);
        }

        public void InsertRecentCheck(long staffId, long? machineEquipmentId = null, long? liftingEquipmentId = null)
        {
            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    long inventoryId;

                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO inventory (date_checked, staff_id) OUTPUT INSERTED.inventory_id VALUES (@date_checked, @staff_id)", _conn))
                    {
                        cmd.Parameters.AddWithValue("@date_checked", DateTime.Now);
                        cmd.Parameters.AddWithValue("@staff_id", staffId);

                        inventoryId = (long)cmd.ExecuteScalar();
                    }

                    if (machineEquipmentId.HasValue)
                    {
                        using (SqlCommand cmd = new SqlCommand(
                            "INSERT INTO machineEquipmentLog (inventory_id, machine_id) VALUES (@inventory_id, @machine_id)", _conn))
                        {
                            cmd.Parameters.AddWithValue("@inventory_id", inventoryId);
                            cmd.Parameters.AddWithValue("@machine_id", machineEquipmentId.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    if (liftingEquipmentId.HasValue)
                    {
                        using (SqlCommand cmd = new SqlCommand(
                            "INSERT INTO liftingEquipmentLog (inventory_id, equipment_id) VALUES (@inventory_id, @equipment_id)", _conn))
                        {
                            cmd.Parameters.AddWithValue("@inventory_id", inventoryId);
                            cmd.Parameters.AddWithValue("@equipment_id", liftingEquipmentId.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Inventory check logged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging inventory check: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flpMachineRecentChecks_Paint(object sender, PaintEventArgs e)
        {
        }

        private void flpEquipmentRecentChecks_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpEquipmentRecentChecks.Visible = false;
            flpMachineRecentChecks.Visible = false;

            string selected = cbFiltering.SelectedItem?.ToString();

            if (selected == "Machine Inventory")
            {
                flpMachineRecentChecks.Visible = true;
                RefreshMachineChecksDisplay();
            }
            else if (selected == "Lifting Inventory")
            {
                flpEquipmentRecentChecks.Visible = true;
                RefreshEquipmentChecksDisplay();
            }
        }
    }
}