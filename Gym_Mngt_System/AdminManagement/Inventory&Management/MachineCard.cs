using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using static Gym_Mngt_System.EquipmentCard;

namespace Gym_Mngt_System.AdminManagement.Inventory_Management
{
    public partial class MachineCard : UserControl
    {
        private readonly Dictionary<Guna2Button, Point> originalLocations = new Dictionary<Guna2Button, Point>();
        private readonly Timer hoverTimer = new Timer();
        private Guna2Button hoveredButton = null;

        private int targetOffset = 0;
        private int currentOffset = 0;

        public delegate void MachineEventHandler(object sender, Machine machine);

        public event MachineEventHandler EditClicked;
        public event MachineEventHandler CheckClicked;

        private Machine _machine;

        public Machine machine
        {

            get => _machine;
            set
            {
                _machine = value;
                UpdateDisplay();
            }
        }


        public MachineCard()
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
            if (_machine == null) return;

            lblName.Text = $"{_machine.Type ?? "Unknown Machine"}";
            lblCategory.Text = $"Category: {_machine.Category ?? "N/A"}";
            lblId.Text = $"Machine ID:  {_machine.Id.ToString() ?? "N/A"}";

            switch (_machine.Status)
            {
                case MachineStatus.Operating:
                    lblStatus.Text = "Operating";
                    lblStatus.BackColor = Color.FromArgb(220, 252, 231);
                    lblStatus.ForeColor = Color.FromArgb(21, 128, 61);
                    break;

                case MachineStatus.Maintenance:
                    lblStatus.Text = "Maintenance";
                    lblStatus.BackColor = Color.FromArgb(254, 249, 195);
                    lblStatus.ForeColor = Color.FromArgb(161, 98, 7);
                    break;

                case MachineStatus.OutOfService:
                    lblStatus.Text = "Out of Service";
                    lblStatus.BackColor = Color.FromArgb(254, 226, 226);
                    lblStatus.ForeColor = Color.FromArgb(185, 28, 28);
                    break;

            }
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            var checkMachineFrm = new CheckMachineFrm();

            checkMachineFrm.SetMachine(_machine.Id, _machine.Type);

            checkMachineFrm.CheckLogged += () =>
            {
                if (this.ParentForm is Inventory mainForm)
                {
                    mainForm.LoadMachineChecks();
                    mainForm.RefreshMachineChecksDisplay();
                }
            };

            checkMachineFrm.ShowDialog();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            EditMachineFrm editMachineFrm = new EditMachineFrm();
            editMachineFrm.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}