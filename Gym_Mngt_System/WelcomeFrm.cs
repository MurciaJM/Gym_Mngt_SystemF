using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Web.SessionState;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Gym_Mngt_System.Backend.Service;
using Gym_Mngt_System.Backend.Session;
using Gym_Mngt_System.CashierManagement.Trainers;

namespace Gym_Mngt_System
{
    public partial class WelcomeFrm : Form
    {
        private Dictionary<string, Form> formCache = new Dictionary<string, Form>();
        private readonly Dictionary<Control, Point> originalLocations = new Dictionary<Control, Point>();
        private Guna2Button activeButton;
        private readonly Color defaultButtonColor = Color.FromArgb(42, 71, 71);
        private readonly Color hoverButtonColor = Color.FromArgb(64, 96, 96);
        private readonly Color activeButtonColor = Color.WhiteSmoke;


        private double animationAngle = 0;
        private Timer floatTimer;
        private Point originalElevateLocation;
        private bool isFloating = true;

        private const double AnimationSpeed = 0.030;
        private const int FloatAmount = 8;

        public Label MainLabel => lbl1;

        public WelcomeFrm()
        {
            InitializeComponent();
            OptimizePerformance();
            InitializeButtonStates();
            InitializeButtonHoverEffects();
            LoadDashboard();
            RoundFormCorners(50);
            InitializeFloatingAnimation();
        }

        private void InitializeFloatingAnimation()
        {
            originalElevateLocation = btnElevate.Location;


            floatTimer = new Timer { Interval = 25 };

            floatTimer.Tick += FloatTimer_Tick;
            floatTimer.Start();
        }

        private void FloatTimer_Tick(object sender, EventArgs e)
        {
            if (!isFloating) return;

            animationAngle += AnimationSpeed;

            int offsetY = (int)(Math.Sin(animationAngle) * FloatAmount);
            btnElevate.Location = new Point(
                originalElevateLocation.X,
                originalElevateLocation.Y + offsetY
            );


            if (animationAngle > Math.PI * 2)
            {
                animationAngle -= Math.PI * 2;
            }
        }
        private void OptimizePerformance()
        {
             
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();

        
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, frmLoader, new object[] { true });
        }

        private void RoundFormCorners(int radius)
        {
            using (var path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseFigure();
                Region = new Region(path);
            }
        }

        private void InitializeButtonStates()
        {
            activeButton = btnMemberLogs;
            btnMemberLogs.FillColor = activeButtonColor;
            btnMemberLogs.ForeColor = Color.Black;
        }

        private void InitializeButtonHoverEffects()
        {
      
            HideAllLabels();

     
            SetupButtonHover(btnMemberLogs, labelLogs);
            SetupButtonHover(btnSession, labelSession);
            SetupButtonHover(btnPlans, labelPlans);
            SetupButtonHover(btnNotification, labelSms);
            SetupButtonHover(btnTrainer, lblTrainors);
        }

        private void HideAllLabels()
        {
            labelLogs?.Hide();
            labelSession?.Hide();
            labelPlans?.Hide();
            lblTrainors?.Hide();
            labelSms?.Hide();
        }

        private void UpdateNavigation(Guna2Button button, string title, string subtitle, string formKey, Func<Form> formFactory)
        {
           
            if (activeButton != null && activeButton != button)
            {
                activeButton.FillColor = defaultButtonColor;
                activeButton.ForeColor = Color.White;
            }

        
            activeButton = button;
            button.FillColor = activeButtonColor;
            button.ForeColor = Color.Black;

     
            HideAllLabels();
            GetLabelForButton(button)?.Show();
 
            lbl1.Text = title;
            lbl2.Text = subtitle;

         
            LoadForm(formKey, formFactory);
        }

        private Label GetLabelForButton(Guna2Button button)
        {
            if (button == btnMemberLogs) return labelLogs;
            if (button == btnSession) return labelSession;
            if (button == btnPlans) return labelPlans;
            if (button == btnNotification) return labelSms;
            if (button == btnTrainer) return lblTrainors;
            return null;
        }

        private void SetupButtonHover(Guna2Button button, Label label)
        {
            if (label == null || button == null) return;

            button.MouseEnter += (s, e) =>
            {
                if (activeButton == button) return;
                label.Visible = true;
                button.FillColor = hoverButtonColor;
                button.ForeColor = Color.White;
            };

            button.MouseLeave += (s, e) =>
            {
                if (activeButton == button) return;
                label.Visible = false;
                button.FillColor = defaultButtonColor;
                button.ForeColor = Color.White;
            };
        }

        private void LoadDashboard()
        {
            lblCashierName.Text = StaffSession.LoggedInStaff.fname;
            lbl1.Text = "Member Logs";
            lbl2.Text = "Track your gym's daily grind — one member at a time";
            LoadForm("MemberLogs", () => new MemberLogs());
            labelLogs?.Show();
        }

        private void LoadForm(string formKey, Func<Form> formFactory)
        {
          
            frmLoader.SuspendLayout();

            try
            {
        
                if (!formCache.ContainsKey(formKey) ||
                    formCache[formKey] == null ||
                    formCache[formKey].IsDisposed)
                {
                   
                    if (formCache.ContainsKey(formKey) &&
                        formCache[formKey] != null &&
                        !formCache[formKey].IsDisposed)
                    {
                        formCache[formKey].Dispose();
                    }

            
                    var newForm = formFactory();
                    newForm.Dock = DockStyle.Fill;
                    newForm.TopLevel = false;
                    newForm.FormBorderStyle = FormBorderStyle.None;
                    formCache[formKey] = newForm;
                }

       
                frmLoader.Controls.Clear();

             
                Form cachedForm = formCache[formKey];
                frmLoader.Controls.Add(cachedForm);
                cachedForm.Show();
            }
            finally
            {
                frmLoader.ResumeLayout(true);
            }
        }

        private void WelcomeFrm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

 
        private void btnCheck_ins_Click(object sender, EventArgs e)
        {
            UpdateNavigation(btnMemberLogs, "Check-Ins Management",
                "Track members gym attendance and activity",
                "CheckIns", () => new MemberLogs());
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            UpdateNavigation(btnSession, "Sessions",
                "Manage fitness training sessions",
                "Sessions", () => new Schedule());
        }

        private void btnPlans_Click(object sender, EventArgs e)
        {
            UpdateNavigation(
                btnPlans,
                "Membership Plans",
                "Create and manage gym membership packages",
                "Plans",
                () => new MembershipFrm(this)
            );
        }

        private void btnSms_Click(object sender, EventArgs e)
        {
            UpdateNavigation(btnNotification, "SMS Notification",
                "Send and track SMS messages to members",
                "Notification", () => new NotificationFrm());
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            UpdateNavigation(btnTrainer, "Trainers",
                "Manage trainers and their schedules",
                "Trainer", () => new TrainerFrm());
        }

        private void NavigateToLogin()
        {
        
            foreach (var form in formCache.Values)
            {
                form?.Dispose();
            }
            formCache.Clear();

            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            NavigateToLogin();
        }

       
 
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        public void frmLoader_Paint(object sender, PaintEventArgs e) { }
        private void labelInventory_Click(object sender, EventArgs e) { }

        private void labelLogs_Click(object sender, EventArgs e)
        {

        }

        private void labelPlans_Click(object sender, EventArgs e)
        {

        }

        private void labelSession_Click(object sender, EventArgs e)
        {

        }

        private void lblTrainors_Click(object sender, EventArgs e)
        {

        }

        private void labelSms_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
            var staffService = new StaffService();
            staffService.Logout();
            this.Close();
            NavigateToLogin();
        }
    }
    }
