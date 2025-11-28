using System;
using System.Drawing;
using System.Windows.Forms;
using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Service;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Gym_Mngt_System.AdminManagement.Staffs
{
    public partial class AddStaffFrm : Form
    {
        public event EventHandler StaffAdded;

        private AdminFrm adminFrm;
        private StaffService staffService;
        private Staff newStaff;
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
                FadeStep = 255;
                FadingIn = false;
                Timer.Start();
            }
        }

        public AddStaffFrm(AdminFrm adminFrm)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.staffService = new StaffService();
            SetupHoverEffects();
        }

        private void SetupHoverEffects()
        {
            SetupButtonHover(btnUploadImage, lblUploadImage, "Upload Image");
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
                    button.Right + 5,
                    button.Top + (button.Height - label.Height) / 2
                );

                fadeController.StartFadeIn();
            };

            button.MouseLeave += (s, e) => fadeController.StartFadeOut();
        }

        private void AddStaffFrm_Load(object sender, EventArgs e)
        {
            dtpBirthdate.Value = DateTime.Now.AddYears(-20);    

            tbLname.TextChanged += (s, ev) => UpdateCheckboxState();
            tbFname.TextChanged += (s, ev) => UpdateCheckboxState();
            tbContact.TextChanged += (s, ev) => UpdateCheckboxState();
            cbPosition.SelectedIndexChanged += (s, ev) => UpdateCheckboxState();
            dtpBirthdate.ValueChanged += (s, ev) => UpdateCheckboxState();
            rbMale.CheckedChanged += (s, ev) => UpdateCheckboxState();
            rbFemale.CheckedChanged += (s, ev) => UpdateCheckboxState();

            CheckBox.Enabled = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (adminFrm != null)
            {
                adminFrm.MainLabel.Text = "Staff Management";
                adminFrm.frmLoaderAdmin.Controls.Clear();

                FrmStaff frmStaff = new FrmStaff(adminFrm);
                frmStaff.TopLevel = false;
                frmStaff.FormBorderStyle = FormBorderStyle.None;
                frmStaff.Dock = DockStyle.Fill;

                adminFrm.frmLoaderAdmin.Controls.Add(frmStaff);
                frmStaff.Show();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation checks
                if (string.IsNullOrWhiteSpace(tbLname.Text))
                {
                    MessageBox.Show("Please enter staff last name.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbLname.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbFname.Text))
                {
                    MessageBox.Show("Please enter staff first name.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbFname.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbPosition.Text))
                {
                    MessageBox.Show("Please enter staff position.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbPosition.Focus();
                    return;
                }

                if (!rbMale.Checked && !rbFemale.Checked)
                {
                    MessageBox.Show("Please select a gender.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if checkbox is checked (create account scenario)
                if (CheckBox.Checked)
                {
                    // Staff with account should already be created in UsernameFrm
                    if (newStaff != null && newStaff.account != null)
                    {
                        StaffAdded?.Invoke(this, EventArgs.Empty);

                        MessageBox.Show("Staff with account successfully added!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please complete the account creation process.", "Incomplete",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Add staff without account
                    newStaff = Staff.Builder()
                            .withFname(tbFname.Text.Trim())
                            .withMiddleName(tbMiddleName.Text.Trim())
                            .withLname(tbLname.Text.Trim())
                            .withBirthdate(dtpBirthdate.Value)
                            .withGender(rbMale.Checked ? "Male" : "Female")
                            .withPhoneNumber(tbContact.Text.Trim())
                            .withScheduleDate(cbDays.Text.Trim())
                            .withStartTime(DateTime.Parse(tbTimeIn.Text.Trim()))
                            .withEndTime(DateTime.Parse(tbTimeOut.Text.Trim()))
                            .withPosition(cbPosition.Text.Trim())
                            .withStatus("Active")
                            .Build();

                    staffService.AddStaff(newStaff, false, null, null);

                    StaffAdded?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Staff successfully added!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving staff: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private bool AreAllFieldsFilled()
        {
            return
                !string.IsNullOrWhiteSpace(tbLname.Text) &&
                !string.IsNullOrWhiteSpace(tbFname.Text) &&
                !string.IsNullOrWhiteSpace(cbPosition.Text) &&
                (rbMale.Checked || rbFemale.Checked);
        }

        private void UpdateCheckboxState()
        {
            CheckBox.Enabled = AreAllFieldsFilled();
            if (!CheckBox.Enabled)
                CheckBox.Checked = false;
        }
        private void tbLname_TextChanged(object sender, EventArgs e) => UpdateCheckboxState();
        private void tbFname_TextChanged(object sender, EventArgs e) => UpdateCheckboxState();
        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e) => UpdateCheckboxState();
        private void dtpBirthdate_ValueChanged(object sender, EventArgs e) => UpdateCheckboxState();
        private void rbMale_CheckedChanged(object sender, EventArgs e) => UpdateCheckboxState();
        private void rbFemale_CheckedChanged(object sender, EventArgs e) => UpdateCheckboxState();
        public void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox.Checked)
            {
                newStaff = Staff.Builder()
                            .withFname(tbFname.Text.Trim())
                            .withMiddleName(tbMiddleName.Text.Trim())
                            .withLname(tbLname.Text.Trim())
                            .withBirthdate(dtpBirthdate.Value)
                            .withGender(rbMale.Checked ? "Male" : "Female")
                            .withPhoneNumber(tbContact.Text.Trim())
                            .withScheduleDate(cbDays.Text.Trim())
                            .withStartTime(DateTime.Parse(tbTimeIn.Text.Trim()))
                            .withEndTime(DateTime.Parse(tbTimeOut.Text.Trim()))
                            .withPosition(cbPosition.Text.Trim())
                            .Build();

                UsernameFrm usernameFrm = new UsernameFrm();
                usernameFrm.StaffData = newStaff;  // IMPORTANT: newStaff must already be created
                usernameFrm.ShowDialog();
            }
        }

    }
}