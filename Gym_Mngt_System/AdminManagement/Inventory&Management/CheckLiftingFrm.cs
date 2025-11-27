using Gym_Mngt_System.Backend.Entities;
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
using System.Web.UI;
using System.Windows.Forms;



namespace Gym_Mngt_System
{
    public partial class CheckLiftingFrm : Form
    {

        private ToolTip statusToolTip;
        private Timer popupTimer;
        private int targetOpacity = 100;
        private int? _machineId = null;
        private int? _equipmentId = null;
        private Equipment _machine;


        public string EquipmentName => lblCheckingLifting.Text;
        public string StaffMember => cbStaff.Text;
        public event Action CheckLogged;
        public DateTime CheckDate => DateTime.Now;

        public CheckLiftingFrm()
        {
            InitializeComponent();
            RoundFormCorners(30);
            InitializePopup();
            LoadStaffList();
        }



        private void InitializePopup()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(707, 716);


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

        private void CheckMachineFrm_Load(object sender, EventArgs e)
        {

            if (_machine != null)
            {
                lblCheckingLifting.Text = _machine.Name;
            }


            if (cbStaff.Items.Count > 0 && cbStaff.SelectedIndex == -1)
            {
                cbStaff.SelectedIndex = 0;
            }

        }

        public void SetLiftingEquipment(int equipmentId, string name)
        {
            _equipmentId = equipmentId;
            _machineId = null;

            _machine = new Equipment { Id = equipmentId, Name = name };
            lblCheckingLifting.Text = name;
        }

        private void LoadStaffList()
        {
            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "SELECT staff_id, CONCAT(fname, ' ', ISNULL(middle, ''), ' ', lname) AS name FROM staff";

                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var staffList = new List<StaffItem>();
                        while (reader.Read())
                        {
                            staffList.Add(new StaffItem
                            {
                                Id = reader.GetInt64(0),
                                Name = reader.GetString(1)
                            });
                        }
                        cbStaff.DataSource = staffList;
                        cbStaff.DisplayMember = "Name";
                        cbStaff.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class StaffItem
        {
            public long Id { get; set; }
            public string Name { get; set; }
        }

        private void btnLogCheck_Click(object sender, EventArgs e)
        {
            if (cbStaff.SelectedIndex < 0 || string.IsNullOrWhiteSpace(StaffMember) || StaffMember.Contains("Select"))
            {
                MessageBox.Show("Please select a staff member.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStaff.Focus();
                return;
            }

            if (_equipmentId == null || _equipmentId <= 0)
            {
                MessageBox.Show("Invalid equipment selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long staffId = ((StaffItem)cbStaff.SelectedItem).Id;

            if (staffId == 0)
            {
                MessageBox.Show("The selected staff member does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                InsertLiftingEquipCheck(staffId, _equipmentId.Value);

                CheckLogged?.Invoke();

                MessageBox.Show(
                    $"Inventory check logged successfully!\n\n" +
                    $"Equipment: {EquipmentName}\n" +
                    $"Staff: {StaffMember}\n" +
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

        private void InsertLiftingEquipCheck(long staffId, int equipmentId)
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

                    bool equipmentExists = false;
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM lifting_equipments WHERE equipment_id = @equipmentId", _conn))
                    {
                        cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                        equipmentExists = (int)cmd.ExecuteScalar() > 0;
                    }

                    if (!equipmentExists)
                    {
                        MessageBox.Show("The lifting equipment does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO liftingEquipmentLog (inventory_id, equipment_id) VALUES (@inventory_id, @equipment_id)", _conn))
                    {
                        cmd.Parameters.AddWithValue("@inventory_id", inventoryId);
                        cmd.Parameters.AddWithValue("@equipment_id", equipmentId);
                        cmd.ExecuteNonQuery();
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


        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
