using Gym_Mngt_System.Backend.Session;
using Gym_Mngt_System.Backend.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static Gym_Mngt_System.CheckLiftingFrm;

namespace Gym_Mngt_System.AdminManagement.Inventory_Management
{
    public partial class CheckMachineFrm : Form
    {

        private ToolTip statusToolTip;
        private Timer popupTimer;
        private int targetOpacity = 100;
        private int? _machineId = null;
        private int? _equipmentId = null;
        private Equipment _machine;
        public event Action CheckLogged;
        public string EquipmentName => lblCheckingMachine.Text;
        public DateTime CheckDate => DateTime.Now;

        public CheckMachineFrm()
        {
            InitializeComponent();
            InitializePopup();
            RoundFormCorners(30);
        }



        private void InitializePopup()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(707, 668);


            this.Opacity = 0;


            RoundFormCorners(20);


            try
            {
                var shadow = new Guna.UI2.WinForms.Guna2ShadowForm();
                shadow.SetShadowForm(this);
            }
            catch
            {

            }

            popupTimer = new Timer();
            popupTimer.Interval = 20;
            popupTimer.Tick += PopupTimer_Tick;
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            popupTimer.Start();
        }

        private void PopupTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.1;
            }
            else
            {
                this.Opacity = 1.0;
                popupTimer.Stop();
            }
        }

        private void RoundFormCorners(int radius)
        {
            var path = new GraphicsPath();
            path.StartFigure();


            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);

            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);

            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);

            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);

            path.CloseFigure();
            Region = new Region(path);
        }

        public void SetMachine(int machineId, string name)
        {
            _machineId = machineId;
            _equipmentId = null;

            _machine = new Equipment { Id = machineId, Name = name };
            lblCheckingMachine.Text = name;
        }

        public class StaffItem
        {
            public long Id { get; set; }
            public string Name { get; set; }
        }

        private void cbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogCheck_Click(object sender, EventArgs e)
        {

            try
            {
                if (_machineId == null || _machineId <= 0)
                {
                    MessageBox.Show("Invalid machine selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                InsertMachineCheck(StaffSession.LoggedInStaff.StaffID, _machineId.Value);

                CheckLogged?.Invoke();

                MessageBox.Show(
                    $"Inventory check logged successfully!\n\n" +
                    $"Machine: {EquipmentName}\n" +
                    $"Time: {CheckDate:yyyy-MM-dd HH:mm:ss}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertMachineCheck(long staffId, int machineId)
        {
            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    long inventoryId;

                    // Insert into inventory table
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO inventory (date_checked, staff_id) OUTPUT INSERTED.inventory_id VALUES (@date_checked, @staff_id)", _conn))
                    {
                        cmd.Parameters.AddWithValue("@date_checked", DateTime.Now);
                        cmd.Parameters.AddWithValue("@staff_id", staffId);

                        inventoryId = (long)cmd.ExecuteScalar();
                    }

                    // Verify machine exists
                    bool machineExists = false;
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM machines WHERE machine_id = @machineId", _conn))
                    {
                        cmd.Parameters.AddWithValue("@machineId", machineId);
                        machineExists = (int)cmd.ExecuteScalar() > 0;
                    }

                    if (!machineExists)
                    {
                        MessageBox.Show("The machine does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert into machineEquipmentLog (NOT liftingEquipmentLog!)
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO machineEquipmentLog (inventory_id, machine_id) VALUES (@inventory_id, @machine_id)", _conn))
                    {
                        cmd.Parameters.AddWithValue("@inventory_id", inventoryId);
                        cmd.Parameters.AddWithValue("@machine_id", machineId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                        {
                            MessageBox.Show("Failed to log machine check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }



        private long StaffIdName(string staffName)
        {

            long staffId = 0;
            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "SELECT staff_id FROM staff WHERE CONCAT(fname, ' ', ISNULL(middle, ''), ' ', lname) = @staffName";
                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@staffName", staffName);
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            staffId = Convert.ToInt64(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting staff ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return staffId;
        }


        private void CheckMachineFrm_Load(object sender, EventArgs e)
        {
        }
    }
}
