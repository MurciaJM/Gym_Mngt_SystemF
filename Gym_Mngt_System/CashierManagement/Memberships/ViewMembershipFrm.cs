using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gym_Mngt_System
{
    public partial class ViewMembershipFrm : Form
    {
        private ToolTip statusToolTip;
        private Timer popupTimer;
        private int targetOpacity = 100;

        public string MemberName { get; set; }
        public string Plan { get; set; }
        public string Status { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Price { get; set; }
        public string Staff { get; set; }

        public ViewMembershipFrm()
        {
            InitializeComponent();
            RoundFormCorners(30);
            SetupTooltip();
            InitializePopup();
        }


        private void InitializePopup()
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(651, 611);


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
        private void SetupTooltip()
        {
            statusToolTip = new ToolTip
            {
                InitialDelay = 100,
                AutoPopDelay = 3000
            };
        }

        private void UpdateStatusColor(string status)
        {
            if (status == "Active")
            {
                pnlStatusIndicator.BackColor = Color.FromArgb(144, 238, 144);  
                statusToolTip.SetToolTip(pnlStatusIndicator, "Active");
            }
            else if (status == "Inactive" || status == "Expired")
            {
                pnlStatusIndicator.BackColor = Color.FromArgb(139, 0, 0);  
                statusToolTip.SetToolTip(pnlStatusIndicator, status);
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

        private void ViewMembershipFrm_Load(object sender, EventArgs e)
        {
            lblMemberName.Text = MemberName;
            lblPlan.Text = Plan;
            lblStatus.Text = Status;
            lblStartDate.Text = StartDate;
            lblEndDate.Text = EndDate;
 
            lblStaff.Text = Staff;

            MakeIndicatorCircle();
            UpdateStatusColor(Status);
        }

        private void MakeIndicatorCircle()
        {
            int diameter = Math.Min(pnlStatusIndicator.Width, pnlStatusIndicator.Height);
            pnlStatusIndicator.Width = diameter;
            pnlStatusIndicator.Height = diameter;

            var circle = new System.Drawing.Drawing2D.GraphicsPath();
            circle.AddEllipse(0, 0, diameter, diameter);
            pnlStatusIndicator.Region = new Region(circle);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        /*protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                statusToolTip?.Dispose();
            }
            base.Dispose(disposing);
        }*/
    }
}