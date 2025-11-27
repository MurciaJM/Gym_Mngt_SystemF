using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using Gym_Mngt_System.Backend.Service;
using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Service.Member_Service;
using Gym_Mngt_System.Backend.Exceptions;


namespace Gym_Mngt_System
{
    public partial class RenewPlanFrm : Form
    {
        private Timer popupTimer;
        private int targetOpacity = 100;

        private readonly StaffService _staffService = new StaffService();
        private readonly MembershipService _membershipService = new MembershipService();
        private List<MembershipType> _membershipTypes;
        private MembershipType _selectedType;
        private List<TrainerPlan> _trainerPlans;
        private List<Staff> _trainers;
        private int _memberID;
        private string _memberName;

        public RenewPlanFrm(int memberID,string memberName)
        {
            InitializeComponent();
            RoundFormCorners(30);
            InitializePopup();
            LoadTrainerPlans();
            LoadTrainers();

            _memberID = memberID;
            _memberName = memberName;

            lblMemberName.Text = memberName;

            _membershipTypes = _membershipService.GetMembershipType().ToList();

            cbPlan.DataSource = _membershipTypes;
            cbPlan.DisplayMember = "typeName";
            cbPlan.ValueMember = "membershipTypeID";
            cbPlan.SelectedIndex = -1;

            cbPlan.SelectedText = "-- Select Plan --";
            cbPlan.SelectedIndexChanged += cbPlan_SelectedIndexChanged;
        }

        private void InitializePopup()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(651, 611);


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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate plan selection
                if (cbPlan.SelectedIndex == -1 || _selectedType == null)
                {
                    MessageBox.Show("Please select a membership plan to renew.", 
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var memberBuilder = Member.Builder()
                                .withMemberID(_memberID)
                                .withMembershipType(_selectedType.membershipTypeID);

                if (cbTrainers.SelectedIndex >= 0 && cbTrainerPlan.SelectedIndex >= 0)
                {
                    memberBuilder.withTrainerPlan((TrainerPlan)cbTrainerPlan.SelectedItem);
                }

                var member = memberBuilder.Build();

                AddPaymentFrm addPaymentFrm = new AddPaymentFrm(member, _selectedType, null, true);
                
                if (addPaymentFrm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Membership renewed successfully!", 
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (addPaymentFrm.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Membership renewal was cancelled.",
                        "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenewPlanFrm_Load(object sender, EventArgs e)
        {

        }
        public void LoadTrainerPlans()
        {
            _trainerPlans = _staffService.GetTrainerPlans().ToList();
            cbTrainerPlan.DataSource = _trainerPlans;
            cbTrainerPlan.DisplayMember = "planName";
            cbTrainerPlan.ValueMember = "trainerPlanID";
            cbTrainerPlan.SelectedIndex = -1;
            cbTrainerPlan.Enabled = false; // Initially disabled
        }

        public void LoadTrainers()
        {
            _trainers = _staffService.GetAllTrainer().ToList();
            cbTrainers.DataSource = _trainers;
            cbTrainers.DisplayMember = "FullName";
            cbTrainers.ValueMember = "staffID";
            cbTrainers.SelectedIndex = -1;
        }
        private void UpdateTotalPrice()
        {
            decimal total = 0;

            if (_selectedType != null)
                total += _selectedType.price;

            if (cbTrainers.SelectedIndex >= 0 && cbTrainerPlan.SelectedIndex >= 0)
            {
                var trainerPlan = (TrainerPlan)cbTrainerPlan.SelectedItem;
                total += trainerPlan.price;
            }

            lblPrice.Text = "₱" + total.ToString("N2");
        }
        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlan.SelectedIndex == -1)
            {
                lblPrice.Text = "";
            }
            else
            {
                _selectedType = (MembershipType)cbPlan.SelectedItem;
                lblPrice.Text = "₱" + _selectedType.price.ToString("N2");
            }

            UpdateTotalPrice();
        }

        private void cbTrainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrainers.SelectedIndex >= 0)
            {
                cbTrainerPlan.Enabled = true;
            }
            else
            {
                cbTrainerPlan.Enabled = false;
                cbTrainerPlan.SelectedIndex = -1;
            }
            UpdateTotalPrice();
        }

        private void cbTrainerPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrainers.SelectedIndex >= 0)
            {
                cbTrainerPlan.Enabled = true;
            }
            else
            {
                cbTrainerPlan.Enabled = false;
                cbTrainerPlan.SelectedIndex = -1;
            }
            UpdateTotalPrice();
        }
    }
}