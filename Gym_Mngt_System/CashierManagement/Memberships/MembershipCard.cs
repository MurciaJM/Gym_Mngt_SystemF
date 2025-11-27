using Gym_Mngt_System.Backend.Exceptions;
using Gym_Mngt_System.Backend.Service.Member_Service;
using Gym_Mngt_System.Backend.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gym_Mngt_System.Memberships
{
    public partial class MembershipCard : UserControl
    {
        private int _memberId;
        public int MemberID
        {
            get => _memberId;
            set
            {
                _memberId = value;
                lblMemberID.Text = $"Member ID - {value}";
            }
        }

        public string MemberName
        {
            get => lblMemName.Text;
            set => lblMemName.Text = value;
        }
        public string Plan
        {
            get => labelPlan.Text;
            set => labelPlan.Text = value;
        }
        public string Status
        {
            get => lblStat.Text;
            set
            {
                lblStat.Text = value;
                switch (value)
                {
                    case "Active":
                        lblStat.ForeColor = Color.ForestGreen;
                        break;
                    case "Expired":
                        lblStat.ForeColor = Color.Red;
                        break;
                }
            }
        }
        public string DaysLeft
        {
            get => lblExpires.Text;
            set => lblExpires.Text = value;
        }
        public MembershipCard()
        {
            InitializeComponent();
        }

        private string GetPlanPrice(string plan)
        {
            var _membershipService = new MembershipService();
            var membershipType = _membershipService.GetMembershipType();

            var type = membershipType.FirstOrDefault(t => t.typeName.Equals(plan, StringComparison.OrdinalIgnoreCase));

            if(type != null)
                return $"{type.price:N0} / {type.durationInDays} days";

            return "N/A";

            ////EXAMPLES
            //switch (plan)
            //{
            //    case "Basic Plan": return "₱500 / 15 days";
            //    case "Premium Plan": return "₱1,500 / 45 days";
            //    case "Gold Plan": return "₱1,200 / 30 days";
            //    case "Elite Plan": return "₱2,000 / 60 days";
            //    default: return "N/A";
            //}
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

     
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            var _membershipService = new MembershipService();
            var membership = _membershipService.GetAll().FirstOrDefault(m => m.memberID == this.MemberID);

            if (membership == null)
            {
                throw new DetailsNotFound("Membership details not found.");
            }

            ViewMembershipFrm viewForm = new ViewMembershipFrm
            {
                MemberName = membership.memberName,
                Plan = membership.membershipType,
                Status = membership.status,
                StartDate = membership.startDate.ToString("MMMM dd, yyyy"),
                EndDate = membership.endDate.ToString("MMMM dd, yyyy"),
                Staff = membership.staffInCharge,
            };

            viewForm.ShowDialog();

        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            string memberName = this.MemberName;
            int memID = this.MemberID;

            RenewPlanFrm renewForm = new RenewPlanFrm(memID, memberName);
            renewForm.ShowDialog();
        }
        private void lblMemberID_Click(object sender, EventArgs e)
        {
        }

        private void MembershipCard_Load(object sender, EventArgs e)
        {

        }
    }
}