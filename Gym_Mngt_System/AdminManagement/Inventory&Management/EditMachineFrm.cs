using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Gym_Mngt_System
{
    public partial class EditMachineFrm : Form
    {
        private ToolTip statusToolTip;
        private Timer popupTimer;
        private int targetOpacity = 100;

        private Equipment _machine;

        public string MachineType => tbMachineType.Text;
        public string Brand => tbBrand.Text;
        public string Model => tbModel.Text;
        public new string Location => cbLocation.Text;
        public DateTime LastMaintenanceDate => dtpMachine.Value;
        public EquipmentStatus Status
        {
            get
            {
                switch (cbMachineStatus.Text)
                {
                    case "Operating": return EquipmentStatus.Operating;
                    case "Maintenance": return EquipmentStatus.Maintenance;
                    case "Out of Service": return EquipmentStatus.OutOfService;
                    default: return EquipmentStatus.Operating;
                }
            }
        }


        public EditMachineFrm()
        {
            InitializeComponent();
            RoundFormCorners(30);
            InitializePopup();
        }

        private void InitializePopup()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(1055, 616);


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


        public EditMachineFrm(Equipment machine) : this()
        {
            _machine = machine;
        }

        private void EditMachineFrm_Load(object sender, EventArgs e)
        {

            if (_machine != null)
            {
                tbMachineType.Text = _machine.Name;
                tbBrand.Text = _machine.Brand;
                tbModel.Text = _machine.Model;
                cbLocation.Text = _machine.Location;

                switch (_machine.Status)
                {
                    case EquipmentStatus.Operating:
                        cbMachineStatus.SelectedIndex = 0;
                        break;
                    case EquipmentStatus.Maintenance:
                        cbMachineStatus.SelectedIndex = 1;
                        break;
                    case EquipmentStatus.OutOfService:
                        cbMachineStatus.SelectedIndex = 2;
                        break;
                }

                if (_machine.Checks != null && _machine.Checks.Count > 0)
                {
                    dtpMachine.Value = _machine.Checks[_machine.Checks.Count - 1].CheckDate;
                }


                btnCreateMachine.Text = "Update Machine";
            }
            else
            {

                cbMachineStatus.SelectedIndex = 0;
                dtpMachine.Value = DateTime.Now;
            }
        }

        private void btnCreateMachine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMachineType.Text))
            {
                MessageBox.Show("Please enter a machine type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbBrand.Text))
            {
                MessageBox.Show("Please enter a brand.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbModel.Text))
            {
                MessageBox.Show("Please enter a model.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelMachine_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbMachineStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}