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
using Gym_Mngt_System.Memberships;
using Gym_Mngt_System.Backend.Session;
using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Service.Member_Service;
using Gym_Mngt_System.Backend.Exceptions;
using Gym_Mngt_System.Backend.Qrcode;
using Gym_Mngt_System.CashierManagement.Memberships;

namespace Gym_Mngt_System
{
    public partial class AddPaymentFrm : Form
    {

        
        private Timer popupTimer;
        private int targetOpacity = 100;

        private readonly Member _member;
        private readonly MembershipType _membershipType;
        private readonly Staff _trainer;
        private readonly MembershipService _membershipService;
        private readonly bool _hasTrainer;
        private readonly bool _isRenewal;
        private readonly WelcomeFrm _welcomeFrm;

        public AddPaymentFrm(
             Member member,
             MembershipType membershipType,
             Staff trainer = null,
             bool isRenewal = false,
             WelcomeFrm welcomeFrm = null)
        {
            InitializeComponent();

            _welcomeFrm = welcomeFrm;
            _member = member;
            _membershipType = membershipType;
            _trainer = trainer;
            _membershipService = new MembershipService();
            _isRenewal = isRenewal;
            _hasTrainer = _trainer != null;

            InitializeFormData();
            RoundFormCorners(50);
            InitializePopup();
        }

        private void InitializePopup()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(750, 705);


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

        private void InitializeFormData()
        {
            cbPaymentMethod.Items.AddRange(new object[] { "Cash"  });
            cbStaff.DataSource = new List<string> { StaffSession.LoggedInStaff.getFullname()};

            decimal totalAmount = _membershipType.price;

            if (_member != null)
            {
                lblmemberName.Text = _member.getFullname();
            }

            if (_membershipType != null)
            {
                if (_member.planName != null)
                {
                    totalAmount += _member.planName.price;
                }

                if (_member.planName != null)
                {
                    lblTrainer.Text = $"{_member.planName.planName} - ₱{_member.planName.price:N2}";
                }
                else
                {
                    lblTrainer.Text = "No Trainer Plan";
                }

                lblPlan.Text = _membershipType.typeName + " - ₱" + _membershipType.price.ToString("N2");
                lblAmount.Text = "₱" + totalAmount.ToString("N2");
                lblTrainer.Text = _member.planName != null ? _member.planName.planName + " - ₱" + _member.planName.price.ToString("N2") : "No Trainer Plan";
            }
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbPaymentMethod.Text))
                {
                    MessageBox.Show("Please select a payment method.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                btnConfirmPayment.Enabled = false;

                decimal totalAmount = _membershipType.price;
                if (_member?.planName != null)
                {
                    totalAmount += _member.planName.price;
                }

                var confirmResult = MessageBox.Show(
                    $"Confirm payment of ₱{totalAmount:N2} for {_member.getFullname()}?\n\n" +
                    $"Plan: {_membershipType.typeName}\n" +
                    $"Payment Method: {cbPaymentMethod.Text}",
                    "Confirm Payment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                var qrGenerator = new qrCode();
                byte[] qrBytes;
                int qrMembershipId;

                if (confirmResult == DialogResult.Yes)
                {
                    if (_isRenewal)
                    {
                     
                        _membershipService.updateMembership(_member);
                    }
                    else
                    {
                   
                        if (_hasTrainer)
                        {
                            qrMembershipId = _membershipService.addMemberWithTrainer(_member, _trainer);
                        }
                        else
                        {
                            qrMembershipId = _membershipService.addMembership(_member);
                        }

                        string pdfPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                            $@"\{_member.getFullname().Replace(" ", "_")}_IDCard.pdf";

                        MemberIdCardPdf.GenerateIdCard(
                            memberName: _member.getFullname(),
                            memberId: qrMembershipId.ToString(),
                            qrValue: qrMembershipId.ToString(),
                            outputPath: pdfPath
                        );

                        System.Diagnostics.Process.Start(pdfPath);

                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = pdfPath,
                            UseShellExecute = true
                        });
                    }


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    btnConfirmPayment.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                btnConfirmPayment.Enabled = true;
                MessageBox.Show($"Error processing payment: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblmemberID_Click(object sender, EventArgs e)
        {
        }

        private void lblPlan_Click(object sender, EventArgs e)
        {
        }

        private void lblAmountDue_Click(object sender, EventArgs e)
        {
        }

        private void AddPaymentFrm_Load(object sender, EventArgs e)
        {
        }

        private void cbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}