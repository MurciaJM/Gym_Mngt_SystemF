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
using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Exceptions;
using Gym_Mngt_System.Backend.Service;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Gym_Mngt_System.AdminManagement.Staffs
{
    public partial class UsernameFrm : Form
    {
        private readonly Dictionary<Control, Point> originalLocations = new Dictionary<Control, Point>();
        private readonly Dictionary<Control, int> currentOffsets = new Dictionary<Control, int>();
        private readonly HashSet<Control> activeControls = new HashSet<Control>();
        private readonly Dictionary<Control, Control> linkedControls = new Dictionary<Control, Control>();

        private const int TimerInterval = 15;
        private const int HoverAmount = -5;
        private const int AnimationStep = 1;


        private Timer floatTimer;
        private Point originalElevateLocation;
        private bool isFloating = true;
        private const int FloatAmount = 8;
        private double animationAngle = 0;
        private const double AnimationSpeed = 0.09;

        private Timer hoverTimer;

        private ToolTip statusToolTip;
        private Timer popupTimer;
        private int targetOpacity = 100;
        public Staff StaffData { get; set; }

        public UsernameFrm()
        {
            InitializeComponent();
            InitializeHoverAnimation();
            InitializePopup();
            RoundFormCorners(30);
            InitializeFloatingAnimation();
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
        private void InitializePopup()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(567, 696);


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

        private void InitializeHoverAnimation()
        {
            hoverTimer = new Timer();
            hoverTimer.Interval = TimerInterval;
            hoverTimer.Tick += HoverTimer_Tick;

            StoreOriginalLocation(BtnCreateStaff);
            RegisterHover(BtnCreateStaff);
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

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BtnCreateStaff_Click(object sender, EventArgs e)
        {
            var _staffService = new StaffService();

            try
            {
              
                if (string.IsNullOrWhiteSpace(TbName.Text))
                {
                    MessageBox.Show("Please enter a username.",
                        "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(TbPass.Text))
                {
                    MessageBox.Show("Please enter a password.",
                        "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbPass.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(TbConfirmPassword.Text))
                {
                    MessageBox.Show("Please confirm your password.",
                        "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbConfirmPassword.Focus();
                    return;
                }

                 
                if (TbPass.Text != TbConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match. Please try again.",
                        "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbConfirmPassword.Clear();
                    TbConfirmPassword.Focus();
                    return;
                }

              
                if (TbPass.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.",
                        "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbPass.Focus();
                    return;
                }

            
                if (_staffService.accountExists(TbName.Text))
                {
                    MessageBox.Show("Username already exists. Please choose another one.",
                        "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbName.Focus();
                    return;
                }

                
                if (StaffData != null)
                {
                   
                    _staffService.AddStaff(StaffData, true, TbName.Text.Trim(), TbPass.Text.Trim());

                    MessageBox.Show("Account created successfully! Staff can now log in.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    TbName.Clear();
                    TbPass.Clear();
                    TbConfirmPassword.Clear();

                  
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Staff information is missing. Please fill out staff details first.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void UsernameFrm_Load_1(object sender, EventArgs e)
        //{
        //    if (StaffData != null && !string.IsNullOrWhiteSpace(StaffData.getFullname()))
        //    {
        //        throw new MissingInputs("Staff information is missing. Please fill out staff details first.");
        //    }
        //}
    }
}