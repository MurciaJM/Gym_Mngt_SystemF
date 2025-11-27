using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Gym_Mngt_System
{
    public partial class EquipmentCard : UserControl
    {
        private readonly Dictionary<Guna2Button, Point> originalLocations = new Dictionary<Guna2Button, Point>();
        private readonly Timer hoverTimer = new Timer();


        private Guna2Button hoveredButton = null;

        private int targetOffset = 0;
        private int currentOffset = 0;

        public delegate void EquipmentEventHandler(object sender, Equipment equipment);

        public event EquipmentEventHandler EditClicked;
        public event EquipmentEventHandler CheckClicked;

        private Equipment _equipment;

        public Equipment Equipment
        {
            get => _equipment;
            set
            {
                _equipment = value;
                UpdateDisplay();
            }
        }

        public EquipmentCard()
        {
            InitializeComponent();


            if (btnEdit is Guna2Button gunaEdit) RegisterButtonForHover(gunaEdit);
            if (btnCheck is Guna2Button gunaCheck) RegisterButtonForHover(gunaCheck);

            hoverTimer.Interval = 15;
            hoverTimer.Tick += HoverTimer_Tick;
        }

        private void RegisterButtonForHover(Guna2Button btn)
        {
            if (btn == null) return;

            originalLocations.Add(btn, btn.Location);

            btn.MouseEnter += (s, ev) => StartHover(btn, -3);
            btn.MouseLeave += (s, ev) => StartHover(btn, 0);
        }

        private void StartHover(Guna2Button btn, int offset)
        {
            hoveredButton = btn;
            targetOffset = offset;


            currentOffset = btn.Location.Y - originalLocations[btn].Y;
            hoverTimer.Start();
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {

            if (currentOffset < targetOffset)
                currentOffset++;
            else if (currentOffset > targetOffset)
                currentOffset--;


            if (hoveredButton != null && originalLocations.ContainsKey(hoveredButton))
            {
                Point originalLocation = originalLocations[hoveredButton];
                hoveredButton.Location = new Point(originalLocation.X, originalLocation.Y + currentOffset);
            }

            if (currentOffset == targetOffset)
                hoverTimer.Stop();
        }
        private void UpdateDisplay()
        {
            if (_equipment == null) return;

            lblName.Text = $"{_equipment.Name}";
            lblBrand.Text = $"Brand: {_equipment.Brand ?? "N/A"}";
            lblModel.Text = $"Model:  {_equipment.Model ?? "N/A"}";
            lblQuantity.Text = $"Quantity:  {_equipment.Quantity}";


            switch (_equipment.Status)
            {
                case EquipmentStatus.Operating:
                    lblStatus.Text = "Operating";
                    lblStatus.BackColor = Color.FromArgb(220, 252, 231);
                    lblStatus.ForeColor = Color.FromArgb(21, 128, 61);
                    break;

                case EquipmentStatus.Maintenance:
                    lblStatus.Text = "Maintenance";
                    lblStatus.BackColor = Color.FromArgb(254, 249, 195);
                    lblStatus.ForeColor = Color.FromArgb(161, 98, 7);
                    break;

                case EquipmentStatus.OutOfService:
                    lblStatus.Text = "Out of Service";
                    lblStatus.BackColor = Color.FromArgb(254, 226, 226);
                    lblStatus.ForeColor = Color.FromArgb(185, 28, 28);
                    break;

            }
        }
        private void EquipmentCard_Load(object sender, EventArgs e)
        {

        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            using (var EditMachineFrm = new EditMachineFrm())
            {
                if (EditMachineFrm.ShowDialog() == DialogResult.OK)
                {

                    var newEquipment = new Equipment
                    {
                        Name = EditMachineFrm.MachineType,
                        Brand = EditMachineFrm.Brand,
                        Model = EditMachineFrm.Model,
                        Location = EditMachineFrm.Location,
                        Status = EditMachineFrm.Status,
                        LastMaintenanceDate = EditMachineFrm.LastMaintenanceDate
                    };


                    EditClicked?.Invoke(this, newEquipment);
                }

            }
        }
        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            var checkLiftingFrm = new CheckLiftingFrm();

            if (_equipment.IsLifting)
            {
                checkLiftingFrm.SetLiftingEquipment(_equipment.Id, _equipment.Name);
            }
            else
            {
                checkLiftingFrm.SetLiftingEquipment(_equipment.Id, _equipment.Name);
            }

            checkLiftingFrm.CheckLogged += () =>
            {
                if (this.ParentForm is Inventory mainForm)
                {
                    mainForm.LoadEquipmentChecks();
                    mainForm.RefreshEquipmentChecksDisplay();
                }
            };
            checkLiftingFrm.ShowDialog();
        }
    }
}