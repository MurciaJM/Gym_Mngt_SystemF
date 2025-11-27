using Gym_Mngt_System.Backend.Singleton;
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

namespace Gym_Mngt_System.AdminManagement.Inventory_Management
{
    public partial class EquipmentsFrm : Form
    {
        private List<Equipment> liftingEquipmentList = new List<Equipment>();

        private readonly Dictionary<Control, Point> originalLocations = new Dictionary<Control, Point>();
        private readonly Dictionary<Control, int> currentOffsets = new Dictionary<Control, int>();
        private readonly Dictionary<Control, Control> linkedControls = new Dictionary<Control, Control>();
        private Timer hoverTimer;

        private const int HoverAmount = -6;
        private const int Step = 1;

        public EquipmentsFrm()
        {
            InitializeComponent();
            LoadLiftingEquipment();
            RefreshLiftingEquipmentDisplay();

            originalLocations[btnLiftingTotal] = btnLiftingTotal.Location;
            originalLocations[btnLiftingWorking] = btnLiftingWorking.Location;
            originalLocations[btnLiftingMaintenance] = btnLiftingMaintenance.Location;
            originalLocations[btnLiftingBroken] = btnLiftingBroken.Location;
            originalLocations[lblTotalLifting] = lblTotalLifting.Location;
            originalLocations[lblLiftingWorking] = lblLiftingWorking.Location;
            originalLocations[lblLiftingMaintenance] = lblLiftingMaintenance.Location;
            originalLocations[lblLiftingBroken] = lblLiftingBroken.Location;

            foreach (var ctrl in originalLocations.Keys)
                currentOffsets[ctrl] = 0;

            linkedControls[btnLiftingTotal] = lblTotalLifting;
            linkedControls[btnLiftingWorking] = lblLiftingWorking;
            linkedControls[btnLiftingMaintenance] = lblLiftingMaintenance;
            linkedControls[btnLiftingBroken] = lblLiftingBroken;

            RegisterHover(btnLiftingTotal);
            RegisterHover(btnLiftingWorking);
            RegisterHover(btnLiftingMaintenance);
            RegisterHover(btnLiftingBroken);

            hoverTimer = new Timer { Interval = 15 };
            hoverTimer.Tick += HoverTimer_Tick;

            RefreshLiftingEquipmentDisplay();
        }

        private void RegisterHover(Control ctrl)
        {
            ctrl.MouseEnter += (s, e) =>
            {
                ctrl.Tag = HoverAmount;
                if (linkedControls.ContainsKey(ctrl))
                    linkedControls[ctrl].Tag = HoverAmount;

                hoverTimer.Start();
            };

            ctrl.MouseLeave += (s, e) =>
            {
                ctrl.Tag = 0;
                if (linkedControls.ContainsKey(ctrl))
                    linkedControls[ctrl].Tag = 0;

                hoverTimer.Start();
            };
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            bool anyAnimating = false;

            foreach (var ctrl in originalLocations.Keys)
            {
                if (!(ctrl.Tag is int targetOffset)) targetOffset = 0;
                int currentOffset = currentOffsets[ctrl];

                if (currentOffset < targetOffset) currentOffset += Step;
                else if (currentOffset > targetOffset) currentOffset -= Step;

                currentOffsets[ctrl] = currentOffset;

                var orig = originalLocations[ctrl];
                ctrl.Location = new Point(orig.X, orig.Y + currentOffset);

                if (currentOffset != targetOffset)
                    anyAnimating = true;
            }

            if (!anyAnimating)
                hoverTimer.Stop();
        }

        private void UpdateLiftingEquipmentStats()
        {
            lblTotalLifting.Text = liftingEquipmentList.Count.ToString();
            lblLiftingWorking.Text = liftingEquipmentList.Count(e => e.Status == EquipmentStatus.Operating).ToString();
            lblLiftingMaintenance.Text = liftingEquipmentList.Count(e => e.Status == EquipmentStatus.Maintenance).ToString();
            lblLiftingBroken.Text = liftingEquipmentList.Count(e => e.Status == EquipmentStatus.OutOfService).ToString();
        }

        private FlowLayoutPanel FindFlowPanel(Control parent)
        {

            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is FlowLayoutPanel)
                    return ctrl as FlowLayoutPanel;

                if (ctrl.Controls.Count > 0)
                {
                    var found = FindFlowPanel(ctrl);
                    if (found != null)
                        return found;
                }
            }
            return null;
        }

        private void RefreshLiftingEquipmentDisplay()
        {
            FlowLayoutPanel liftingFlowPanel = this.Controls.Find("flowLayoutPanel2", true).FirstOrDefault() as FlowLayoutPanel;

            if (liftingFlowPanel == null)
            {
                liftingFlowPanel = FindFlowPanel(pnlLiftingEquipment);
            }

            if (liftingFlowPanel == null)
            {
                MessageBox.Show("Lifting Equipment FlowLayoutPanel not found!\nPlease check the control name in your designer.", "Error");
                Debug.WriteLine("=== DEBUGGING INFO ===");
                Debug.WriteLine($"pnlLiftingEquipment controls: {pnlLiftingEquipment.Controls.Count}");
                foreach (Control c in pnlLiftingEquipment.Controls)
                {
                    Debug.WriteLine($"  - {c.Name} ({c.GetType().Name})");
                }
                return;
            }

            liftingFlowPanel.Controls.Clear();

            if (liftingEquipmentList.Count == 0)
            {
                Label noDataLabel = new Label
                {
                    Text = "No lifting equipment found.",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 10),
                    Padding = new Padding(10)
                };
                liftingFlowPanel.Controls.Add(noDataLabel);
            }
            else
            {
                foreach (var equipment in liftingEquipmentList)
                {
                    var card = new EquipmentCard { Equipment = equipment };
                    card.EditClicked += Card_EditClicked;
                    card.CheckClicked += Card_CheckClicked;
                    card.Margin = new Padding(8);
                    liftingFlowPanel.Controls.Add(card);
                }
            }

            UpdateLiftingEquipmentStats();
        }

        private void Card_EditClicked(object sender, Equipment e)
        {
            MessageBox.Show($"Editing {e.Name}", "Edit Equipment");

        }

        private void Card_CheckClicked(object sender, Equipment e)
        {
            MessageBox.Show($"Checking {e.Name}", "Check Equipment");

        }

        private void lblTotalLifting_Click(object sender, EventArgs e)
        {

            RefreshLiftingEquipmentDisplay();
        }

        private void lblLiftingMaintenance_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Search/filter logic
            string keyword = guna2TextBox1.Text.ToLower();

            FlowLayoutPanel liftingFlowPanel = this.Controls.Find("flowLayoutPanel2", true).FirstOrDefault() as FlowLayoutPanel;
            if (liftingFlowPanel == null)
                liftingFlowPanel = FindFlowPanel(pnlLiftingEquipment);

            if (liftingFlowPanel == null) return;

            liftingFlowPanel.Controls.Clear();

            var filtered = liftingEquipmentList.Where(eq =>
                eq.Name.ToLower().Contains(keyword) ||
                (eq.Brand != null && eq.Brand.ToLower().Contains(keyword)) ||
                eq.Quantity.ToString().Contains(keyword)
            ).ToList();

            if (filtered.Count == 0)
            {
                Label noDataLabel = new Label
                {
                    Text = "No matching equipment found.",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 10),
                    Padding = new Padding(10)
                };
                liftingFlowPanel.Controls.Add(noDataLabel);
            }
            else
            {
                foreach (var equipment in filtered)
                {
                    var card = new EquipmentCard { Equipment = equipment };
                    card.EditClicked += Card_EditClicked;
                    card.CheckClicked += Card_CheckClicked;
                    card.Margin = new Padding(8);
                    liftingFlowPanel.Controls.Add(card);
                }
            }

            UpdateLiftingEquipmentStats();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            using (var addEquipmentForm = new AddEquipmentFrm())
            {
                if (addEquipmentForm.ShowDialog() == DialogResult.OK)
                {
                    LoadLiftingEquipment();
                    RefreshLiftingEquipmentDisplay();

                    MessageBox.Show($"Equipment added successfully! Total: {liftingEquipmentList.Count}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void LoadLiftingEquipment()
        {
            liftingEquipmentList.Clear();

            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "SELECT equipment_id, equipment_name, quantity, total_quantity FROM lifting_equipments";

                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string equipmentName = reader.GetString(1);
                            liftingEquipmentList.Add(new Equipment
                            {
                                Id = Convert.ToInt32(reader[0]),
                                Name = reader.GetString(1),
                                Brand = GetBrandLift(equipmentName),
                                Model = GetModelLift(equipmentName),
                                Quantity = reader.IsDBNull(2) ? 0 : reader.GetInt64(2),
                                TotalQuantity = reader.IsDBNull(3) ? 0 : reader.GetInt64(3),
                                Status = EquipmentStatus.Operating,
                                IsLifting = true,
                                Type = EquipmentType.Lifting
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading lifting equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class LiftingEquipment
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public long Quantity { get; set; }
            public long TotalQuantity { get; set; }
        }

        private string GetBrandLift(string equipmentName)
        {
            if (equipmentName.IndexOf("dumbbells", StringComparison.OrdinalIgnoreCase) >= 0) return "Rogue";
            if (equipmentName.IndexOf("weight plates", StringComparison.OrdinalIgnoreCase) >= 0) return "Rogue";
            if (equipmentName.IndexOf("barbell", StringComparison.OrdinalIgnoreCase) >= 0) return "Rogue";
            if (equipmentName.IndexOf("kettle bell", StringComparison.OrdinalIgnoreCase) >= 0) return "Rep";
            if (equipmentName.IndexOf("medicine ball", StringComparison.OrdinalIgnoreCase) >= 0) return "Rep";

            return "Rogue";
        }

        private string GetModelLift(string equipmentName)
        {
            if (equipmentName.IndexOf("dumbbells", StringComparison.OrdinalIgnoreCase) >= 0) return "Standard";
            if (equipmentName.IndexOf("weight plates", StringComparison.OrdinalIgnoreCase) >= 0) return "Training Bar";
            if (equipmentName.IndexOf("barbell", StringComparison.OrdinalIgnoreCase) >= 0) return "Standard";
            if (equipmentName.IndexOf("kettle bell", StringComparison.OrdinalIgnoreCase) >= 0) return "Standard";
            if (equipmentName.IndexOf("medicine ball", StringComparison.OrdinalIgnoreCase) >= 0) return "Standard";

            return "Standard";
        }

        private long InsertLiftingEquipment(string name, int qty, int totalQty)
        {
            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"
                    INSERT INTO lifting_equipments (equipment_name, quantity, total_quantity)
                    OUTPUT INSERTED.equipment_id
                    VALUES (@name, @qty, @totalQty)";

                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@totalQty", totalQty);

                        return (long)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting lifting equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }




        private void pnlLiftingEquipment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLiftingTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnLiftingWorking_Click(object sender, EventArgs e)
        {

        }

        private void btnLiftingMaintenance_Click(object sender, EventArgs e)
        {

        }
    }
}