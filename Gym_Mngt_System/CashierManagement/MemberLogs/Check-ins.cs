using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;
using Gym_Mngt_System.Backend.Service.Member_Service;
using Gym_Mngt_System.CashierManagement.MemberLogs;
using Gym_Mngt_System.Staffs;

namespace Gym_Mngt_System
{
    public partial class MemberLogs : Form
    {
        private readonly MembershipService _membershipService = new MembershipService();
        public MemberLogs()
        {
            InitializeComponent();


            flpMemberLogs.Padding = new Padding(8);
            flpMemberLogs.AutoScroll = true;

            SetupHoverEffects();
        }


        private void SetupHoverEffects()
        {
            SetupButtonHover(btnScanQR, lblScanQr);

        }

        private void SetupButtonHover(Control button, Label label)
        {
            if (button == null || label == null) return;

            label.Visible = false;

            button.MouseEnter += (s, e) => label.Visible = true;
            button.MouseLeave += (s, e) => label.Visible = false;
        }
        private void Check_insFrm_Load(object sender, EventArgs e)
        {
            SetCheckInData();
        }


        //SAMPLES
        private void SetCheckInData()
        {
            var memberLogsData = _membershipService.MemberLogs().ToList();

            //EVERYTIME MAG ADD UG CHECK-IN MAG NEW CARD NAPUD
            foreach (var data in memberLogsData)
            {
                var card = new MemberLogCard();
                card.SetData(data.logId, data.getFullname(), data.FormattedTime(), data.FormattedDate());

                card.Margin = new Padding(8);

                flpMemberLogs.Controls.Add(card);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void lblQR_Click(object sender, EventArgs e)
        {

        }

        private void flpCheck_ins_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnScanQR_Click(object sender, EventArgs e)
        {
            using (var scanner = new qrScanner())
            {
                if (scanner.ShowDialog() == DialogResult.OK)
                {
                    string qrText = scanner.ScannedText;

                    // EXAMPLE: your QR contains only membership_id
                    if (!long.TryParse(qrText, out long membershipId))
                    {
                        MessageBox.Show("Invalid QR code.");
                        return;
                    }

                    // Insert attendance
                    bool success = _membershipService.qrCodeScanned(membershipId);

                    if (success)
                    {
                        MessageBox.Show("Check-in recorded!");

                        // Refresh the list
                        flpMemberLogs.Controls.Clear();
                        SetCheckInData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to record check-in.");
                    }
                }
            }
        }
    }
}