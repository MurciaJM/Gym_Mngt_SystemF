using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Gym_Mngt_System.Backend.Service.Member_Service;
using Gym_Mngt_System.CashierManagement.Memberships;
using Gym_Mngt_System.Memberships;

namespace Gym_Mngt_System   
{
    public partial class MembershipFrm : Form
    {


        private List<MembershipCard> _allMemberships = new List<MembershipCard>();
        private MembershipService _membershipService = new MembershipService();

        private WelcomeFrm _welcomeFrm;
        private class FadeController
        {
            public Timer Timer { get; set; }
            public int FadeStep { get; set; }
            public bool FadingIn { get; set; }
            public Label Label { get; set; }

            public FadeController(Label label)
            {
                Label = label;
                Timer = new Timer { Interval = 30 };
                Timer.Tick += OnTick;
            }

            private void OnTick(object sender, EventArgs e)
            {
                if (FadingIn)
                {
                    FadeStep += 25;
                    if (FadeStep >= 255)
                    {
                        FadeStep = 255;
                        Timer.Stop();
                    }
                    Label.ForeColor = Color.FromArgb(FadeStep, Color.Black);
                }
                else
                {
                    FadeStep -= 25;
                    if (FadeStep <= 0)
                    {
                        FadeStep = 0;
                        Label.ForeColor = Color.FromArgb(FadeStep, Color.Black);
                        Timer.Stop();
                        Label.Visible = false;
                    }
                    else
                    {
                        Label.ForeColor = Color.FromArgb(FadeStep, Color.Black);
                    }
                }
            }

            public void StartFadeIn()
            {
                FadeStep = 0;
                FadingIn = true;
                Label.Visible = true;
                Timer.Start();
            }

            public void StartFadeOut()
            {
                FadeStep = 0;
                FadingIn = false;
                Timer.Start();
            }
        }

        public MembershipFrm(WelcomeFrm welcomeFrm)
        {
            InitializeComponent();
            loadAllMembership();
            SetupHoverEffects();
            _welcomeFrm = welcomeFrm ?? throw new ArgumentNullException(nameof(welcomeFrm));


        }

        private void SetupHoverEffects()
        {
            SetupButtonHover(btnAddMember, lblAddMember, "Add Member");
        }

        private void SetupButtonHover(Control button, Label label, string text)
        {
            var fadeController = new FadeController(label);


            label.Text = text;
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Visible = false;

            button.MouseEnter += (s, e) =>
            {

                label.Location = new Point(
                    button.Left + (button.Width - label.Width) / 2,
                    button.Top - label.Height - 5
                );
                fadeController.StartFadeIn();
            };

            button.MouseLeave += (s, e) => fadeController.StartFadeOut();
        }

        public void loadAllMembership()
        {
            _allMemberships.Clear();

            var memberships = _membershipService.GetAll();

            foreach (var membership in memberships)
            {
                var card = CreateCard(
                    membership.memberID.ToString(),
                    membership.memberName,
                    membership.membershipType,
                    membership.status,
                    CalculateDaysLeft(membership.endDate)
                );
                _allMemberships.Add(card);
            }
            DisplayMemberships(_allMemberships);
        }

        private string CalculateDaysLeft(DateTime endDate)
        {
            int daysLeft = (endDate - DateTime.Now).Days;
            if(daysLeft < 0)
                return "0 days left";
            return $"{daysLeft} days left";
        }

        private MembershipCard CreateCard(string memberID, string name, string plan, string status, string daysLeft)
        {
            return new MembershipCard
            {
                MemberID = int.Parse(memberID),
                MemberName = name,
                Plan = plan,
                Status = status,
                DaysLeft = daysLeft,
                Margin = new Padding(8)
            };
        }

        private void DisplayMemberships(List<MembershipCard> memberships)
        {
            flpMemberships.Controls.Clear();
            foreach (var card in memberships)
            {
                flpMemberships.Controls.Add(card);
            }
        }

        private void FilterMembershipsByStatus(string status)
        {
            var filtered = _allMemberships.Where(m => m.Status == status).ToList();
            DisplayMemberships(filtered);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text.ToLower();
            var filtered = _allMemberships.Where(m =>
                m.MemberName.ToLower().Contains(keyword) ||
                m.Plan.ToLower().Contains(keyword)
            ).ToList();

            DisplayMemberships(filtered);
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

            WelcomeFrm parentForm = _welcomeFrm;

            if (parentForm == null)
            {
                MessageBox.Show("Cannot find parent Dashboard. Make sure this form is hosted inside WelcomeFrm.frmLoader.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            parentForm.MainLabel.Text = "Add Member";
            parentForm.frmLoader.Controls.Clear();


            AddMember addMemberForm = new AddMember(parentForm);
            addMemberForm.TopLevel = false;
            addMemberForm.FormBorderStyle = FormBorderStyle.None;
            addMemberForm.Dock = DockStyle.Fill;


            addMemberForm.MemberAdded += (s, args) =>
            {

                loadAllMembership();

                MessageBox.Show("New member added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                parentForm.frmLoader.Controls.Clear();
                this.Dock = DockStyle.Fill;
                parentForm.frmLoader.Controls.Add(this);
                this.Show();

                parentForm.MainLabel.Text = "Membership";
            };


            parentForm.frmLoader.Controls.Add(addMemberForm);
            addMemberForm.Show();
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FilterMembershipsByStatus("Active");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FilterMembershipsByStatus("Expired");
        }

    

        private void btnTotalMem_Click(object sender, EventArgs e)
        {
            DisplayMemberships(_allMemberships);
        }

        private void MembershipFrm_Load(object sender, EventArgs e)
        {

        }

        private void flpMemberships_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            GenerateQrFrm generateQrFrm = new GenerateQrFrm();
            generateQrFrm.Show();
        }

        private void lblQR_Click(object sender, EventArgs e)
        {

        }
    }
}