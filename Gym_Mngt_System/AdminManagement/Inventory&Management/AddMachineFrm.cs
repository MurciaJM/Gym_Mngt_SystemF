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
using System.Windows.Forms;
using System.Xml.Linq;


namespace Gym_Mngt_System
{
    public partial class AddMachineFrm : Form
    {

        private ToolTip statusToolTip;
        private Timer popupTimer;
        private int targetOpacity = 100;

        public string MachineType => tbMachineType.Text;
        public string Brand => tbBrand.Text;
        public string Model => tbModel.Text;
        public new string Location => cbLocation.SelectedItem?.ToString() ?? "Strength Area";
        public string Status => cbMachineStatus.SelectedItem?.ToString() ?? "Operating";

        public AddMachineFrm()
        {
            InitializeComponent();
            RoundFormCorners(30);

            InitializePopup();
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


        private void InitializePopup()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(653, 713);


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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateMachine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMachineType.Text) ||
                string.IsNullOrWhiteSpace(tbBrand.Text) ||
                string.IsNullOrWhiteSpace(tbModel.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveMachineToDatabase();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving machine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelMachine_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SaveMachineToDatabase()
        {
            var _connection = SingletonDB.getInstance();

            try
            {
                using (var _conn = _connection.getConnection())
                {
                    string query = "INSERT INTO machines (machine_type, category, status) " +
                                   "VALUES (@machineType, @category, @status)";

                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@machineType", MachineType);
                        cmd.Parameters.AddWithValue("@category", Location);
                        cmd.Parameters.AddWithValue("@status", Status);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Machine added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        private void AddMachineFrm_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbMachineType_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMachineStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
