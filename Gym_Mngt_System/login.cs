using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Guna.UI2.WinForms;
using Gym_Mngt_System.AdminManagement;
using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Exceptions;
using Gym_Mngt_System.Backend.Service;
using Gym_Mngt_System.Backend.Session;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Gym_Mngt_System
{
    public partial class Login : Form
    {
        
        private readonly Dictionary<Control, Point> originalLocations = new Dictionary<Control, Point>();
        private readonly Dictionary<Control, int> currentOffsets = new Dictionary<Control, int>();
        private readonly HashSet<Control> activeControls = new HashSet<Control>();
        private readonly Dictionary<Control, Control> linkedControls = new Dictionary<Control, Control>();

         
        private const int TimerInterval = 15;
        private const int HoverAmount = -5;
        private const int AnimationStep = 1;

     
        private Timer hoverTimer;

   
        private Timer floatTimer;
        private Point originalElevateLocation;
        private bool isFloating = true;
        private const int FloatAmount = 8;
        private double animationAngle = 0;
        private const double AnimationSpeed = 0.09;

        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottonRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Login()
        {
            InitializeComponent();
            RoundFormCorners(30);
            InitializeHoverAnimation();
            InitializeFloatingAnimation();
        }

        private void InitializeHoverAnimation()
        {
            hoverTimer = new Timer();
            hoverTimer.Interval = TimerInterval;
            hoverTimer.Tick += HoverTimer_Tick;

            StoreOriginalLocation(BtnLogin);
            StoreOriginalLocation(BtnSignout);
         

            RegisterHover(BtnLogin);
            RegisterHover(BtnSignout);
        }

        private void StoreOriginalLocation(Control ctrl)
        {
            if (!originalLocations.ContainsKey(ctrl))
            {
                originalLocations[ctrl] = ctrl.Location;
                currentOffsets[ctrl] = 0;
            }
        }

        private void RegisterHover(Control ctrl)
        {
            ctrl.MouseEnter += (s, e) =>
            {
                ctrl.Tag = HoverAmount;
                activeControls.Add(ctrl);

                if (linkedControls.ContainsKey(ctrl))
                {
                    var linked = linkedControls[ctrl];
                    linked.Tag = HoverAmount;
                    activeControls.Add(linked);
                }

                hoverTimer.Start();
            };

            ctrl.MouseLeave += (s, e) =>
            {
                ctrl.Tag = 0;
                activeControls.Add(ctrl);

                if (linkedControls.ContainsKey(ctrl))
                {
                    var linked = linkedControls[ctrl];
                    linked.Tag = 0;
                    activeControls.Add(linked);
                }

                hoverTimer.Start();
            };
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            bool anyAnimating = false;
            var controlsToRemove = new List<Control>();

            foreach (var ctrl in activeControls)
            {
                if (!originalLocations.ContainsKey(ctrl))
                    continue;

                int targetOffset = (ctrl.Tag is int offset) ? offset : 0;
                int currentOffset = currentOffsets[ctrl];

          
                if (currentOffset < targetOffset)
                {
                    currentOffset = Math.Min(currentOffset + AnimationStep, targetOffset);
                }
                else if (currentOffset > targetOffset)
                {
                    currentOffset = Math.Max(currentOffset - AnimationStep, targetOffset);
                }

                currentOffsets[ctrl] = currentOffset;

                 
                Point originalPos = originalLocations[ctrl];
                ctrl.Location = new Point(originalPos.X, originalPos.Y + currentOffset);

                if (currentOffset != targetOffset)
                {
                    anyAnimating = true;
                }
                else
                {
                    controlsToRemove.Add(ctrl);
                }
            }

       
            foreach (var ctrl in controlsToRemove)
            {
                activeControls.Remove(ctrl);
            }

            if (!anyAnimating)
            {
                hoverTimer.Stop();
                activeControls.Clear();
            }
        }

        private void InitializeFloatingAnimation()
        {
            originalElevateLocation = btnElevate.Location;

            floatTimer = new Timer { Interval = 16 };
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

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
 
        private void panel_signIn_Paint(object sender, PaintEventArgs e)
        {
        }
  
        private void modalEffectTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffectTimer.Stop();
            }
            else
            {
                Opacity += .05;
            }
        }
 
        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {
        }
 
      
        private void label10_Click(object sender, EventArgs e)
        {
        }

       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var _staffService = new StaffService();

            DialogResult result = MessageBox.Show("Are you sure you want to sign out?",
                "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _staffService.Logout();

                TbUsername.Clear();
                TbPassword.Clear();

                Application.Exit();
            }
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TbUsername.Text) || string.IsNullOrEmpty(TbPassword.Text))
                {
                    MessageBox.Show("Please enter username and password.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StaffService _staffService = new StaffService();

                bool loginSuccessful = _staffService.Login(TbUsername.Text.Trim(), TbPassword.Text.Trim());

                if (loginSuccessful && StaffSession.LoggedInStaff != null)
                {
                    var staff = StaffSession.LoggedInStaff;

                    if (staff.position.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($"Welcome Admin, {staff.getFullname()}!",
                            "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TbUsername.Clear();
                        TbPassword.Clear();
                        this.Hide();

                        AdminFrm adminDashboard = new AdminFrm();
                        adminDashboard.Show();
                        return;
                    }

                    MessageBox.Show($"Welcome, {staff.getFullname()}!",
                        "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TbUsername.Clear();
                    TbPassword.Clear();
                    this.Hide();

                    WelcomeFrm landing = new WelcomeFrm();
                    landing.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}