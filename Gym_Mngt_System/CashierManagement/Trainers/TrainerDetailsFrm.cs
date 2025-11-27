using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mngt_System.CashierManagement.Trainers
{
    public partial class TrainerDetailsFrm : Form
    {
        private ToolTip statusToolTip;
        private Timer popupTimer;
        private const int FormRadius = 30;
        private const double OpacityIncrement = 0.1;
        private const int TimerInterval = 20;
        private Staff _trainers;

        // Store trainer information
        private string trainerStatus;



        public TrainerDetailsFrm(Staff trainer)
        {
            InitializeComponent();
            RoundFormCorners(FormRadius);
            InitializePopup();
            SetupTooltip();

            _trainers = trainer;

        }

        // Parameterless constructor for designer support
        public TrainerDetailsFrm()
        {
            InitializeComponent();
            RoundFormCorners(FormRadius);
            InitializePopup();
            SetupTooltip();
        }

        // Method to load trainer details after form creation
        public void LoadTrainerDetails()
        {
            System.Diagnostics.Debug.WriteLine("=== LoadTrainerDetails Called ===");

            if (_trainers == null)
            {
                System.Diagnostics.Debug.WriteLine("_trainers is NULL in LoadTrainerDetails!");
                MessageBox.Show("Trainer data is null");
                return;
            }

            System.Diagnostics.Debug.WriteLine($"Loading details for: {_trainers.getFullname()}");

            lblMemberName.Text = _trainers.getFullname() ?? "N/A";
            lblGender.Text = _trainers.gender ?? "N/A";
            lblSched.Text = _trainers.scheduleDate ?? "No schedule available";
            trainerStatus = _trainers.status;

            System.Diagnostics.Debug.WriteLine($"Schedule: {lblSched.Text}");
            System.Diagnostics.Debug.WriteLine($"Status: {trainerStatus}");

            UpdateStatusColor(trainerStatus);
            LoadTrainees();
        }

        public string TrainerName
        {
            get => lblMemberName.Text;
            set => lblMemberName.Text = value ?? "N/A";
        }

        //public string TrainerPosition
        //{
        //    get => lblPosition.Text;
        //    set => lblPosition.Text = value ?? "N/A";
        //}

        public string TrainerGender
        {
            get => lblGender.Text;
            set => lblGender.Text = value ?? "N/A";
        }

        public string TrainerStatus
        {
            get => trainerStatus;
            set
            {
                trainerStatus = value;
                UpdateStatusColor(trainerStatus);
            }
        }


        private void InitializePopup()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);
            this.Size = new Size(651, 713);
            this.Opacity = 0;

            ApplyShadow();
            InitializeTimer();
        }

        private void ApplyShadow()
        {
            try
            {
                var shadow = new Guna.UI2.WinForms.Guna2ShadowForm();
                shadow.SetShadowForm(this);
            }
            catch
            {

            }
        }

        private void InitializeTimer()
        {
            popupTimer = new Timer
            {
                Interval = TimerInterval
            };
            popupTimer.Tick += PopupTimer_Tick;
        }

        private void SetupTooltip()
        {
            statusToolTip = new ToolTip
            {
                InitialDelay = 100,
                AutoPopDelay = 3000
            };
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

        private void MakeIndicatorCircle()
        {
            int diameter = Math.Min(pnlStatusIndicator.Width, pnlStatusIndicator.Height);
            pnlStatusIndicator.Width = diameter;
            pnlStatusIndicator.Height = diameter;

            var circle = new GraphicsPath();
            circle.AddEllipse(0, 0, diameter, diameter);
            pnlStatusIndicator.Region = new Region(circle);
        }



        private void UpdateStatusColor(string status)
        {
            if (pnlStatusIndicator == null) return;

            switch (status?.ToLower())
            {
                case "active":
                    pnlStatusIndicator.BackColor = Color.FromArgb(144, 238, 144);
                    statusToolTip.SetToolTip(pnlStatusIndicator, "Active");
                    break;

                case "inactive":
                case "expired":
                    pnlStatusIndicator.BackColor = Color.FromArgb(139, 0, 0);
                    statusToolTip.SetToolTip(pnlStatusIndicator, status);
                    break;

                default:
                    pnlStatusIndicator.BackColor = Color.Gray;
                    statusToolTip.SetToolTip(pnlStatusIndicator, "Unknown");
                    break;
            }
            if (pnlStatusIndicator == null) return;

            switch (status?.ToLower())
            {
                case "active":
                    pnlStatusIndicator.BackColor = Color.FromArgb(144, 238, 144);
                    statusToolTip.SetToolTip(pnlStatusIndicator, "Active");
                    break;

                case "inactive":
                case "expired":
                    pnlStatusIndicator.BackColor = Color.FromArgb(139, 0, 0);
                    statusToolTip.SetToolTip(pnlStatusIndicator, status);
                    break;

                default:
                    pnlStatusIndicator.BackColor = Color.Gray;
                    statusToolTip.SetToolTip(pnlStatusIndicator, "Unknown");
                    break;
            }
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
                this.Opacity += OpacityIncrement;
            }
            else
            {
                this.Opacity = 1.0;
                popupTimer.Stop();
            }
        }
        private void LoadTrainees()
        {
            listBox1.Items.Clear();

            System.Diagnostics.Debug.WriteLine("=== LoadTrainees Called ===");

            if (_trainers == null)
            {
                System.Diagnostics.Debug.WriteLine("_trainers is NULL!");
                listBox1.Items.Add("Trainer data not loaded.");
                return;
            }

            System.Diagnostics.Debug.WriteLine($"Trainer: {_trainers.getFullname()}");
            System.Diagnostics.Debug.WriteLine($"memberWithTrainer is null? {(_trainers.memberWithTrainer == null ? "YES" : "NO")}");

            if (_trainers.memberWithTrainer != null)
            {
                System.Diagnostics.Debug.WriteLine($"memberWithTrainer count: {_trainers.memberWithTrainer.Count}");
            }

            if (_trainers.memberWithTrainer == null || !_trainers.memberWithTrainer.Any())
            {
                System.Diagnostics.Debug.WriteLine("No trainees found");
                listBox1.Items.Add("No assigned trainees."); // Changed this message
                return;
            }

            System.Diagnostics.Debug.WriteLine($"Processing {_trainers.memberWithTrainer.Count} trainees");

            foreach (var trainee in _trainers.memberWithTrainer)
            {
                // Construct full name
                string fullName = $"{trainee.fname} {(string.IsNullOrWhiteSpace(trainee.middle) ? "" : trainee.middle + " ")}{trainee.lname}".Trim();

                System.Diagnostics.Debug.WriteLine($"Trainee: {fullName}");
                System.Diagnostics.Debug.WriteLine($"  planName object is null? {(trainee.planName == null ? "YES" : "NO")}");

                if (trainee.planName != null)
                {
                    System.Diagnostics.Debug.WriteLine($"  plan name value: '{trainee.planName.planName}'");
                }

                // Get plan name safely
                string plan = trainee.planName?.planName ?? "No plan";

                string displayText = $"{fullName} ({plan})";
                System.Diagnostics.Debug.WriteLine($"Adding to listbox: {displayText}");

                listBox1.Items.Add(displayText);
            }

            System.Diagnostics.Debug.WriteLine($"Final listBox1.Items.Count: {listBox1.Items.Count}");
        }
        
        private void TrainerDetailsFrm_Load(object sender, EventArgs e)
        {
            MakeIndicatorCircle();
            LoadTrainerDetails();
        }

        private void lbAssignedTrainee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSched_Click(object sender, EventArgs e)
        {

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }


        private void lblMemberName_Click(object sender, EventArgs e)
        {

        }

    }
}
