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
    public partial class AddEquipmentFrm : Form
    {

        private ToolTip statusToolTip;
        private Timer popupTimer;
        private int targetOpacity = 100;

        public string EquipmentName => tbEquipmentName.Text;
        public string Model => tbEquipmentModel.Text;
        public string Brand => tbBrand.Text;
        public int Quantity => (int)nupQuantity.Value;
        public string Condition => cbEquipmentCondition.SelectedItem?.ToString() ?? "";


        public AddEquipmentFrm()
        {
            InitializeComponent();
            RoundFormCorners(50);
            InitializePopup();

        }


        private void InitializePopup()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(670, 675);


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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEquipmentFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelEquipment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateEquipment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEquipmentName.Text) ||
        string.IsNullOrWhiteSpace(tbEquipmentModel.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveLiftingEquipment()
        {
            var _connection = SingletonDB.getInstance();

            using (var _conn = _connection.getConnection())
            {


                string query = "INSERT INTO lifting_equipments (equipment_name, quantity, total_quantity) " +
                               "VALUES (@equipmentName, @quantity, @totalQuantity)";

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@equipmentName", EquipmentName);
                    cmd.Parameters.AddWithValue("@quantity", Quantity);
                    cmd.Parameters.AddWithValue("@totalQuantity", Quantity);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Lifting equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbEquipmentModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbEquipmentCondition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nupQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbEquipmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}