using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Service;
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

namespace Gym_Mngt_System.Staffs
{
    public partial class EditStaff : Form
    {
        private ToolTip statusToolTip;
        private Timer popupTimer;
        private int targetOpacity = 100;
        public string StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffPosition { get; set; }
        public string StaffStatus { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }

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
                    Label.ForeColor = Color.FromArgb(FadeStep, Color.White);
                }
                else
                {
                    FadeStep -= 25;
                    if (FadeStep <= 0)
                    {
                        FadeStep = 0;
                        Label.ForeColor = Color.FromArgb(FadeStep, Color.White);
                        Timer.Stop();
                        Label.Visible = false;
                    }
                    else
                    {
                        Label.ForeColor = Color.FromArgb(FadeStep, Color.White);
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
        public event EventHandler StaffUpdated;
        public EditStaff()
        {
            InitializeComponent();
            RoundFormCorners(50);
            InitializePopup();
            SetupHoverEffects();

            this.Load += EditStaffFrm_Load;
         
        }

        private void InitializePopup()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(710, 849);


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
        private void EditStaff_Load(object sender, EventArgs e)
        {
         
        }

        private void SetupHoverEffects()
        {
            SetupButtonHover(btnUploadImage, lblUploadImage, "Edit Image");
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


        private void EditStaffFrm_Load(object sender, EventArgs e)
        {

            tbFname.Enabled = false;
            dtpBirthdate.Enabled = false;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
            cbPosition.Enabled = true;


            cbStatus.Items.Clear();
            cbStatus.Items.AddRange(new object[]
            {
                "Active",
                "Inactive"
            });


            lblStaffid.Text = StaffId;
            tbFname.Text = StaffName;

            if (DateTime.TryParse(BirthDate, out var dob))
                dtpBirthdate.Value = dob;

            if (Gender?.ToLower() == "male")
                rbMale.Checked = true;
            else if (Gender?.ToLower() == "female")
                rbFemale.Checked = true;


            cbPosition.Items.Clear();
            cbPosition.Items.AddRange(new object[]
            {
                "Manager",
                "Receptionist",
                "Trainer",
                "Nutritionist"
            });

            if (cbPosition.Items.Contains(StaffPosition))
                cbPosition.SelectedItem = StaffPosition;
            else
                cbPosition.Text = StaffPosition;


            if (cbStatus.Items.Contains(StaffStatus))
                cbStatus.SelectedItem = StaffStatus;
            else
                cbStatus.Text = StaffStatus;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var _staffService = new StaffService();

            try
            {
                var staff = Staff.Builder().
                   withStaffID(int.Parse(StaffId)).
                   //withFname(tbFname.Text).
                   //withMiddleName(tbMname.Text).
                   //withLname(tbLname.Text).
                   //withBirthdate(dtpBirthdate.Value).
                   //withGender(rbMale.Checked ? "Male" : "Female").
                   withPosition(cbPosition.Text).
                   withStatus(cbStatus.Text).
                   Build();

                _staffService.updateStaff(staff);


                MessageBox.Show("Staff updated successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StaffUpdated?.Invoke(this, EventArgs.Empty);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //StaffStatus = cbStatus.Text;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void lblUploadImage_Click(object sender, EventArgs e)
        {

        }
    }
}
