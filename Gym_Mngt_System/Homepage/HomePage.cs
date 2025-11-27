using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Gym_Mngt_System
{
    public partial class HomePage : Form
    {
        private readonly Dictionary<Control, Point> originalLocations = new Dictionary<Control, Point>();
        private readonly Dictionary<Control, int> targetOffsets = new Dictionary<Control, int>();

        private double animationAngle = 0;
        private Timer floatTimer;
        private Point originalElevateLocation;
        private bool isFloating = true;

        private const int HoverAmount = -6;
        private const double AnimationSpeed = 0.09;
        private const int FloatAmount = 8;

        public static int parentX, parentY;

        public HomePage()
        {
            InitializeComponent();


            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();

            RoundFormCorners(50);
            InitializeHoverAnimation();
            InitializeFloatingAnimation();
        }

        private void InitializeHoverAnimation()
        {

            AddHoverAnimation(btnGetStarted);
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

        private void AddHoverAnimation(Control control)
        {
            if (!originalLocations.ContainsKey(control))
            {
                originalLocations[control] = control.Location;
                targetOffsets[control] = 0;
            }

            control.MouseEnter += async (s, e) => await AnimateControlAsync(control, HoverAmount);
            control.MouseLeave += async (s, e) => await AnimateControlAsync(control, 0);
        }

        private async Task AnimateControlAsync(Control control, int targetOffset)
        {
            if (!originalLocations.ContainsKey(control)) return;

            Point originalLocation = originalLocations[control];
            int startOffset = control.Location.Y - originalLocation.Y;
            int distance = targetOffset - startOffset;

            if (distance == 0) return;


            targetOffsets[control] = targetOffset;

            int steps = 10;
            int delay = 10;

            for (int i = 1; i <= steps; i++)
            {

                if (targetOffsets[control] != targetOffset) return;


                double progress = (double)i / steps;
                double eased = 1 - Math.Pow(1 - progress, 3);

                int newOffset = startOffset + (int)(distance * eased);
                control.Location = new Point(originalLocation.X, originalLocation.Y + newOffset);

                await Task.Delay(delay);
            }


            if (targetOffsets[control] == targetOffset)
            {
                control.Location = new Point(originalLocation.X, originalLocation.Y + targetOffset);
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

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            isFloating = false;

            Form overlay = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.50d,
                BackColor = Color.Black,
                Location = this.Location,
                Size = this.Size,
                ShowInTaskbar = false
            };
            overlay.Show();

            parentX = this.Location.X;
            parentY = this.Location.Y;

            using (Login login = new Login())
            {
                login.Owner = overlay;
                login.StartPosition = FormStartPosition.CenterParent;
                login.ShowDialog();
            }

            overlay.Close();
            overlay.Dispose();


            isFloating = true;
        }

        private void btnElevate_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnElevate_Click_1(object sender, EventArgs e)
        {

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                floatTimer?.Stop();
                floatTimer?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}