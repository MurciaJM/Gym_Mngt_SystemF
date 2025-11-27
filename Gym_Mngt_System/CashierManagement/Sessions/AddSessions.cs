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
using Gym_Mngt_System.Backend.Service.Session_Service;
using System.Net.NetworkInformation;
using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Session;

namespace Gym_Mngt_System
{
    public partial class AddSessions : Form
    {
        private readonly SessionService _sessionService = new SessionService();
        private List<Sessions> sessions = new List<Sessions>();
        public AddSessions()
        {
            InitializeComponent();
            RoundFormCorners(50);
            LoadSessions();
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
        private void LoadSessions()
        {
            sessions = _sessionService.GetAllSessions().ToList();

            cbReturnee.Items.Clear();
            foreach (var s in sessions)
                cbReturnee.Items.Add(s.fullName);

            cbReturnee.SelectedIndex = -1;
            cbReturnee.Text = "";

            cbPlaceHolder();
        }
        private void cbPlaceHolder()
        {
            if (string.IsNullOrWhiteSpace(cbReturnee.Text))
            {
                cbReturnee.ForeColor = Color.Gray;
                cbReturnee.Text = "Type to search session";
                cbReturnee.SelectionStart = 0;
            }
        }
        private void AddSessions_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string name = tbFname.Text.Trim();
            string amount = txtboxAmount.Text.Trim();
       //     DateTime date = dtpBirthdate.Value;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(amount))
              //  string.IsNullOrWhiteSpace(date.ToString()))
            {
                MessageBox.Show("⚠️ Please fill in all fields before adding.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newSession = new Sessions()
            {
                fname = tbFname.Text,
                middle = tbMname.Text,
                lname = tbLname.Text,
                staffName = StaffSession.LoggedInStaff.getFullname()
            };

            _sessionService.AddSession(newSession);


            MessageBox.Show("✅ Session has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbReturnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = cbReturnee.Text;

            var selectedSession = sessions
                .FirstOrDefault(s => s.fullName == selectedName);

            if (selectedSession != null)
            {
                tbFname.Text = selectedSession.fname;
                tbMname.Text = selectedSession.middle;
                tbLname.Text = selectedSession.lname;
            }
        }

        private void cbReturnee_Enter(object sender, EventArgs e)
        {
            if (cbReturnee.Text == "Type to search session")
            {
                cbReturnee.Text = "";
                cbReturnee.ForeColor = Color.Black;
            }
        }

        private void cbReturnee_TextChanged(object sender, EventArgs e)
        {
            // Stop if placeholder text
            if (cbReturnee.Text == "Type to search session")
                return;

            string typed = cbReturnee.Text.ToLower();

            // Filter list
            var filtered = sessions
                .Where(s => s.fullName.ToLower().Contains(typed))
                .Select(s => s.fullName)
                .ToList();

            // Don't block normal typing
            cbReturnee.DroppedDown = false;

            // Clear items before refill
            cbReturnee.Items.Clear();

            // Refill with filtered results
            foreach (var name in filtered)
                cbReturnee.Items.Add(name);

            // Re-open dropdown
            if (filtered.Count > 0)
            {
                cbReturnee.DroppedDown = true;
                cbReturnee.SelectionStart = cbReturnee.Text.Length;
            }
        }

        private void cbReturnee_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbReturnee.Text))
                cbPlaceHolder();
        }
    }
}