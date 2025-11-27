using Gym_Mngt_System.Backend.Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gym_Mngt_System.Staffs
{
    public partial class ViewStaffDetails : Form
    {
        private ToolTip statusToolTip;
        private Timer popupTimer;
        private int targetOpacity = 100;

        public string StaffId
        {
            set => lblStaffId.Text = value;
        }
        public string StaffName
        {
            set => lblStaffName.Text = value;
        }
        public string Position
        {
            set => lblPosition.Text = value;
        }
        public string HiredDate
        {
            set => lblHiredDate.Text = value;
        }
        public string Status
        {
            set
            {
                lblStaffStatus.Text = value;
                UpdateStatusColor(value);
            }
        }
        public string ContactNumber
        {
            set => lblContacts.Text = value;
        }
        public string Days 
        {
            set
            {
                lblSchedule.Text = value;
            }
        }
        public string Gender
        {
            set => lblGender.Text = value;
        }
        public string BirthDate
        {
            set => lblBirthDate.Text = value;
        }

        public ViewStaffDetails()
        {
            InitializeComponent();

      
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();

            SetupTooltip();
            InitializePopup();
        }

        private void InitializePopup()
        {
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.BackColor = Color.FromArgb(42, 71, 71);



            this.Size = new Size(758, 646);

     
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

        protected override CreateParams CreateParams
        {
            get
            {
                 
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  
                return cp;
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
                pnlStatusIndicator.FillColor = Color.FromArgb(173, 255, 47);
                statusToolTip.SetToolTip(pnlStatusIndicator, "Active");
            }
            else if (status == "Inactive")
            {
                pnlStatusIndicator.FillColor = Color.FromArgb(139, 0, 0);
                statusToolTip.SetToolTip(pnlStatusIndicator, "Inactive");
            }
        }


        private void RoundFormCorners(int radius)
        {
            try
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
            catch
            {
                 
            }
        }

        private void CloseWithFadeOut()
        {
            Timer fadeOutTimer = new Timer();
            fadeOutTimer.Interval = 20;
            fadeOutTimer.Tick += (s, ev) =>
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.1;  
                }
                else
                {
                    fadeOutTimer.Stop();
                    fadeOutTimer.Dispose();
                    this.Close();
                }
            };
            fadeOutTimer.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            CloseWithFadeOut();
        }

        private void ViewStaffDetails_Load(object sender, EventArgs e)
        {
            MakeIndicatorCircle();
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

        private void lblStaffStatus_Click(object sender, EventArgs e)
        {
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
 