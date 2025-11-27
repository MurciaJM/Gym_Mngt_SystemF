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
using Guna.UI2.WinForms;
using Gym_Mngt_System.AdminManagement.Inventory_Management;
using Gym_Mngt_System.Backend.Session;



namespace Gym_Mngt_System.AdminManagement
{
    public partial class AdminFrm : Form
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
        public AdminFrm()
        {
            InitializeComponent();
            OptimizePerformance();
            InitializeButtonStates();
            InitializeButtonHoverEffects();
            LoadDashboard();
            RoundFormCorners(50);
            InitializeFloatingAnimation();
            lblAdminName.Text = StaffSession.LoggedInStaff.fname;
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
                null, frmLoaderAdmin, new object[] { true });
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
            activeButton = btnDashboard;
            btnDashboard.FillColor = activeButtonColor;
            btnDashboard.ForeColor = Color.Black;
        }

        private void InitializeButtonHoverEffects()
        {

            HideAllLabels();


            SetupButtonHover(btnDashboard, lblDashboard);
            SetupButtonHover(btnInventory, lblInventory);
            SetupButtonHover(btnInvoice, lblInvoice);
            SetupButtonHover(btnStaff, lblStaff);
           
        }

        private void HideAllLabels()
        {
            lblDashboard?.Hide();
            lblInventory?.Hide();
            lblStaff?.Hide();
            lblInvoice?.Hide();
           
        }

        public void UpdateNavigation(Guna2Button button, string title, string subtitle, string formKey, Func<Form> formFactory)
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
            if (button == btnDashboard) return lblDashboard;
            if (button == btnInventory) return lblInventory;
            if (button == btnInvoice) return lblInvoice;
            if (button == btnStaff) return lblStaff;
         
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
            lbl1.Text = "Dashboard";
            lbl2.Text = "Here's what happening at your gym today!";
            LoadForm("Dashboard", () => new Dashboard(this));
            lblDashboard?.Show();
        }

        private void LoadForm(string formKey, Func<Form> formFactory)
        {

            frmLoaderAdmin.SuspendLayout();

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


                frmLoaderAdmin.Controls.Clear();


                Form cachedForm = formCache[formKey];
                frmLoaderAdmin.Controls.Add(cachedForm);
                cachedForm.Show();
            }
            finally
            {
                frmLoaderAdmin.ResumeLayout(true);
            }
        }

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Dashboard dash = new Dashboard(this); 
            dash.Show();
        }

        public void btnDashboard_Click(object sender, EventArgs e)
        {

            UpdateNavigation(
                btnDashboard,
                "Dashboard",
                "Here's what happening at your gym today!",
                "Dashboard",
                () => new Dashboard(this)

                );
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

        public void btnStaff_Click(object sender, EventArgs e)
        {
            UpdateNavigation(
               btnStaff,
               "Staff Management",
               "Organize, Track, and Manage Your Team",
               "Staff",
               () => new FrmStaff(this)
           );
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            UpdateNavigation(
                btnInvoice,
                "Invoices",
                "View and Manage All Transactions",
                "Invoices",
                () => new Invoice_and_paymentsFrm()
            );
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            UpdateNavigation(btnInventory, "Equipment Management",
             "Track and maintain gym equipment",
             "Inventory", () => new Admin_Inventory());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblStaff_Click(object sender, EventArgs e)
        {

        }

        private void lblInvoice_Click(object sender, EventArgs e)
        {

        }

        private void lblInventory_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void frmLoaderAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
