using Gym_Mngt_System.Backend.Singleton;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym_Mngt_System.AdminManagement.Inventory_Management
{
    public partial class MachinesFrm : Form
    {
        private List<Machine> machineList = new List<Machine>();

        private readonly Dictionary<Control, Point> originalLocations = new Dictionary<Control, Point>();
        private readonly Dictionary<Control, int> currentOffsets = new Dictionary<Control, int>();
        private readonly Dictionary<Control, Control> linkedControls = new Dictionary<Control, Control>();
        private Timer hoverTimer;

        private const int HoverAmount = -6;
        private const int Step = 1;

        public MachinesFrm()
        {
            InitializeComponent();
            LoadMachines();
            RefreshMachineDisplay();

            // Store original locations
            originalLocations[btnMachineTotal] = btnMachineTotal.Location;
            originalLocations[btnMachineWorking] = btnMachineWorking.Location;
            originalLocations[btnMachineMaintenance] = btnMachineMaintenance.Location;
            originalLocations[btnMachineBroken] = btnMachineBroken.Location;
            originalLocations[lblTotalMachine] = lblTotalMachine.Location;
            originalLocations[lblMachineWorking] = lblMachineWorking.Location;
            originalLocations[lblMachineMaintenance] = lblMachineMaintenance.Location;
            originalLocations[lblMachineBroken] = lblMachineBroken.Location;

            // Link controls
            linkedControls[btnMachineTotal] = lblTotalMachine;
            linkedControls[btnMachineWorking] = lblMachineWorking;
            linkedControls[btnMachineMaintenance] = lblMachineMaintenance;
            linkedControls[btnMachineBroken] = lblMachineBroken;

            // Register hover effects
            RegisterHover(btnMachineTotal);
            RegisterHover(btnMachineWorking);
            RegisterHover(btnMachineMaintenance);
            RegisterHover(btnMachineBroken);

            // Initialize offsets
            foreach (var ctrl in originalLocations.Keys)
                currentOffsets[ctrl] = 0;

            // Setup timer
            hoverTimer = new Timer { Interval = 15 };
            hoverTimer.Tick += HoverTimer_Tick;

            UpdateMachineStats();
        }

        private void pnlMachines_Paint(object sender, PaintEventArgs e)
        {
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
                int targetOffset = (ctrl.Tag is int offset) ? offset : 0;
                int currentOffset = currentOffsets[ctrl];

                if (currentOffset < targetOffset)
                    currentOffset += Step;
                else if (currentOffset > targetOffset)
                    currentOffset -= Step;

                currentOffsets[ctrl] = currentOffset;

                var orig = originalLocations[ctrl];
                ctrl.Location = new Point(orig.X, orig.Y + currentOffset);

                if (currentOffset != targetOffset)
                    anyAnimating = true;
            }

            if (!anyAnimating)
                hoverTimer.Stop();
        }

        private void LoadMachines()
        {
            machineList.Clear();

            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "SELECT machine_id, machine_type, category, status FROM machines";

                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string machineName = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1);
                            string category = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2);
                            string statusStr = reader.IsDBNull(3) ? "Operating" : reader.GetString(3);

                            var machine = new Machine
                            {
                                Id = (int)reader.GetInt64(0),
                                Type = machineName,
                                Category = category,
                                Status = ConvertToMachineStatus(statusStr)
                            };

                            machineList.Add(machine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading machines: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private MachineStatus ConvertToMachineStatus(string statusString)
        {
            switch (statusString.ToLower())
            {
                case "operating":
                case "working":
                    return MachineStatus.Operating;
                case "maintenance":
                    return MachineStatus.Maintenance;
                case "out of service":
                case "broken":
                    return MachineStatus.OutOfService;
                default:
                    return MachineStatus.Operating;
            }
        }


        private string GetBrandMachine(string equipmentName)
        {
            if (equipmentName.IndexOf("leg press", StringComparison.OrdinalIgnoreCase) >= 0) return "Hammer Strength";
            if (equipmentName.IndexOf("chest press", StringComparison.OrdinalIgnoreCase) >= 0) return "Cybex";
            if (equipmentName.IndexOf("rowing", StringComparison.OrdinalIgnoreCase) >= 0) return "Concept 2";
            if (equipmentName.IndexOf("treadmill", StringComparison.OrdinalIgnoreCase) >= 0) return "Life Fitness";
            if (equipmentName.IndexOf("elliptical", StringComparison.OrdinalIgnoreCase) >= 0) return "Precor";
            if (equipmentName.IndexOf("smith machine", StringComparison.OrdinalIgnoreCase) >= 0) return "Hammer Strength";

            return "Hammer Strength";
        }

        private string GetModelMachine(string equipmentName)
        {
            if (equipmentName.IndexOf("leg press", StringComparison.OrdinalIgnoreCase) >= 0) return "LP-500";
            if (equipmentName.IndexOf("chest press", StringComparison.OrdinalIgnoreCase) >= 0) return "VR3";
            if (equipmentName.IndexOf("rowing", StringComparison.OrdinalIgnoreCase) >= 0) return "Model D";
            if (equipmentName.IndexOf("treadmill", StringComparison.OrdinalIgnoreCase) >= 0) return "T5";
            if (equipmentName.IndexOf("elliptical", StringComparison.OrdinalIgnoreCase) >= 0) return "EFX 835";
            if (equipmentName.IndexOf("smith machine", StringComparison.OrdinalIgnoreCase) >= 0) return "X5";
            return "Adjustable";
        }

        private void UpdateMachineStats()
        {
            lblTotalMachine.Text = machineList.Count.ToString();
            lblMachineWorking.Text = machineList.Count(e => e.Status == MachineStatus.Operating).ToString();
            lblMachineMaintenance.Text = machineList.Count(e => e.Status == MachineStatus.Maintenance).ToString();
            lblMachineBroken.Text = machineList.Count(e => e.Status == MachineStatus.OutOfService).ToString();
        }

        private long InsertMachine(string type, string category, string status)
        {

            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = @"
                    INSERT INTO machines (machine_type, category, status)
                    OUTPUT INSERTED.machine_id
                    VALUES (@type, @category, @status)";

                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@status", status);

                        return (long)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting machine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void RefreshMachineDisplay()
        {
            if (flowLayoutPanelMachines == null)
            {
                MessageBox.Show("Machine FlowLayoutPanel not assigned!", "Error");
                return;
            }

            flowLayoutPanelMachines.Controls.Clear();

            if (machineList.Count == 0)
            {
                Label noDataLabel = new Label
                {
                    Text = "No machines found.",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 10),
                    Padding = new Padding(10)
                };
                flowLayoutPanelMachines.Controls.Add(noDataLabel);
            }
            else
            {
                foreach (var machine in machineList)
                {
                    var card = new MachineCard { machine = machine };
                    card.Margin = new Padding(8);
                    flowLayoutPanelMachines.Controls.Add(card);
                }
            }

            UpdateMachineStats();
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            using (var addMachineFrm = new AddMachineFrm())
            {
                if (addMachineFrm.ShowDialog() == DialogResult.OK)
                {
                    LoadMachines();
                    RefreshMachineDisplay();

                    MessageBox.Show($"Machine added successfully! Total: {machineList.Count}", "Success");
                }
            }
        }

        private void flowLayoutPanelMachines_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnMachineTotal_Click(object sender, EventArgs e)
        {
            RefreshMachineDisplay();
        }
    }
}