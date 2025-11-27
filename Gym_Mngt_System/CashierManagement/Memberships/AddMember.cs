using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Exceptions;
using Gym_Mngt_System.Backend.Service;
using Gym_Mngt_System.Backend.Service.Member_Service;

namespace Gym_Mngt_System.CashierManagement.Memberships
{
    public partial class AddMember : Form
    {
        private readonly StaffService _staffService = new StaffService();
        private readonly MembershipService _membershipService = new MembershipService();
        private List<MembershipType> _membershipTypes;
        private List<TrainerPlan> _trainerPlans;
        private List<Staff> _trainers;
        private WelcomeFrm _welcomeFrm;

        // Event to notify when a member is added
        public event EventHandler<MemberAddedEventArgs> MemberAdded;

        public AddMember(WelcomeFrm welcomeFrm)
        {
            InitializeComponent();

            LoadMembershipTypes();
            LoadTrainerPlans();
            LoadTrainers();
            _welcomeFrm = welcomeFrm ?? throw new ArgumentNullException(nameof(welcomeFrm));
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
            cbTrainer.DataSource = _trainers;
            cbTrainer.DisplayMember = "FullName";
            cbTrainer.ValueMember = "staffID";
            cbTrainer.SelectedIndex = -1;
        }

        public void LoadMembershipTypes()
        {
            _membershipTypes = _membershipService.GetMembershipType().ToList();
            cbPlans.DataSource = _membershipTypes;
            cbPlans.DisplayMember = "typeName";
            cbPlans.ValueMember = "membershipTypeID";
            cbPlans.SelectedIndex = -1;
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            // Form load logic here
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if (_welcomeFrm != null)
            {
                _welcomeFrm.frmLoader.Controls.Clear();
                MembershipFrm membershipForm = new MembershipFrm(_welcomeFrm)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                _welcomeFrm.frmLoader.Controls.Add(membershipForm);
                membershipForm.Show();

                if (_welcomeFrm.MainLabel != null)
                {
                    _welcomeFrm.MainLabel.Text = "Membership";
                }
            }
            else
            {
                this.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            var selectedType = (MembershipType)cbPlans.SelectedItem;
            var getGender = rbMale.Checked ? "Male" : "Female";
            var selectedTrainer = cbTrainer.SelectedIndex >= 0 ? (Staff)cbTrainer.SelectedItem : null;
            var selectedTrainerPlan = cbTrainerPlan.SelectedIndex >= 0 ? (TrainerPlan)cbTrainerPlan.SelectedItem : null;
 
            Member member = Member.Builder()
                        .withFname(tbFname.Text)
                        .withMiddleName(tbMname.Text)
                        .withLname(tbLname.Text)
                        .withGender(getGender)
                        .withPhonenum(tbContact.Text)
                        .withMembershipType(selectedType.membershipTypeID)
                        .Build();

          
            if (selectedTrainer != null && selectedTrainerPlan != null)
            {
                member.planName = selectedTrainerPlan;
            }

            decimal totalPrice = selectedType.price;
            if (selectedTrainerPlan != null)
                totalPrice += selectedTrainerPlan.price;

            var result = MessageBox.Show(
                $"Proceed payment for {tbFname.Text} {tbMname.Text} {tbLname.Text}?\n\nPlan: {cbPlans.Text}\n\nPayment: ₱{totalPrice:N2}",
                "Confirm Add Member",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes) return;

         
            var paymentForm = new AddPaymentFrm(member, selectedType, selectedTrainer, false, _welcomeFrm);
            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(
                    "Payment successful! Member has been added.\n\n" +
                    $"Name: {tbFname.Text} {tbMname.Text} {tbLname.Text}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                
                var eventArgs = new MemberAddedEventArgs(
                    member.memberID.ToString(),
                    tbFname.Text + tbMname.Text + tbLname.Text,
                    cbPlans.Text,
                    getGender,
                    selectedTrainer?.getFullname() ?? "No Trainer",
                    tbContact.Text
                );
                MemberAdded?.Invoke(this, eventArgs);

                if (_welcomeFrm != null)
                {
                    _welcomeFrm.frmLoader.Controls.Clear();
                    MembershipFrm membershipForm = new MembershipFrm(_welcomeFrm)
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill
                    };
                    _welcomeFrm.frmLoader.Controls.Add(membershipForm);
                    membershipForm.Show();

                    if (_welcomeFrm.MainLabel != null)
                    {
                        _welcomeFrm.MainLabel.Text = "Membership";
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool ValidateFields()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbLname.Text))
                {
                    throw new MissingInputs("Please enter the member's full name.");
                }
                if (string.IsNullOrWhiteSpace(tbContact.Text))
                {
                    throw new MissingInputs("Please enter the member's contact number.");
                }
                if (cbPlans.SelectedIndex < 0)
                {
                    throw new MissingInputs("Please select a membership plan.");
                }
                if (!rbMale.Checked && !rbFemale.Checked)
                {
                    throw new MissingInputs("Please select a gender.");
                }

                return true;
            }
            catch (MissingInputs ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
 
        private void cbTrainerPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrainer.SelectedIndex >= 0)
            {
                cbTrainerPlan.Enabled = true;
            }
            else
            {
                cbTrainerPlan.Enabled = false;
                cbTrainerPlan.SelectedIndex = -1;
            }
        }

        private void cbTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrainer.SelectedIndex >= 0)
            {
                cbTrainerPlan.Enabled = true;
            }
            else
            {
                cbTrainerPlan.Enabled = false;
                cbTrainerPlan.SelectedIndex = -1;
            }
        }
    }
}