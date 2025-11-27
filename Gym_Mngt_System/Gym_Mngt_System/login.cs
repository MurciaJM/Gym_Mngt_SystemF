using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mngt_System
{
    public partial class Login : Form
    {
        private Timer hoverTimer;
        private Button hoveredButton;
        private Point originalLoginLocation;
        private Point originalCreateAccLocation;
        private Point originalSignOutLocation;
        private int targetOffset = 0;
        private int currentOffset = 0;

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

            originalLoginLocation = btnLogin.Location;
            originalSignOutLocation = btnSignout.Location;
            originalCreateAccLocation = btnCreateAcc.Location;

            hoverTimer = new Timer();
            hoverTimer.Interval = 15;
            hoverTimer.Tick += HoverTimer_Tick;

            
            btnLogin.MouseEnter += (s, ev) => StartHover(btnLogin, -3);
            btnLogin.MouseLeave += (s, ev) => StartHover(btnLogin, 0);

         
            btnSignout.MouseEnter += (s, ev) => StartHover(btnSignout, -3);
            btnSignout.MouseLeave += (s, ev) => StartHover(btnSignout, 0);

            btnCreateAcc.MouseEnter += (s, ev) => StartHover(btnCreateAcc, -3);
            btnCreateAcc.MouseLeave += (s, ev) => StartHover(btnCreateAcc, 0);

        }

        private void StartHover(Button btn, int offset)
        {
            hoveredButton = btn;
            targetOffset = offset;
            hoverTimer.Start();
        }
        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            if (currentOffset < targetOffset)
                currentOffset++;
            else if (currentOffset > targetOffset)
                currentOffset--;

            if (hoveredButton == btnLogin)
                btnLogin.Location = new Point(originalLoginLocation.X, originalLoginLocation.Y + currentOffset);
            else if (hoveredButton == btnSignout)
                btnSignout.Location = new Point(originalSignOutLocation.X, originalSignOutLocation.Y + currentOffset);
            else if (hoveredButton == btnCreateAcc)
                btnCreateAcc.Location = new Point(originalCreateAccLocation.X, originalCreateAccLocation.Y + currentOffset);

            if (currentOffset == targetOffset)
                hoverTimer.Stop();
        }



        private void Login_Load(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            Panel1.Region = Region.FromHrgn(Login.CreateRoundRectRgn(6, 6, Panel1.Width, Panel1.Height, 50, 50));
            //  Panel1.Region = Region.FromHrgn(Login.CreateRoundRectRgn(4, 4, btnSignIn.Width, btnSignIn.Height, 36, 36));

            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.Region = Region.FromHrgn(Login.CreateRoundRectRgn(4, 4, btnSignIn.Width, btnSignIn.Height, 10, 10));

            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.Region = Region.FromHrgn(Login.CreateRoundRectRgn(4, 4, btnSignUp.Width, btnSignUp.Height, 10, 10));

            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Region = Region.FromHrgn(Login.CreateRoundRectRgn(4, 4, btnLogin.Width, btnLogin.Height, 10, 10));

            btnSignout.FlatStyle = FlatStyle.Flat;
            btnSignout.FlatAppearance.BorderSize = 0;
            btnSignout.Region = Region.FromHrgn(Login.CreateRoundRectRgn(4, 4, btnSignout.Width, btnSignout.Height, 10, 10));

            btnCreateAcc.FlatStyle = FlatStyle.Flat;
            btnCreateAcc.FlatAppearance.BorderSize = 0;
            btnCreateAcc.Region = Region.FromHrgn(Login.CreateRoundRectRgn(4, 4, btnCreateAcc.Width, btnCreateAcc.Height, 10, 10));
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            panel_signIn.BringToFront();

            btnSignIn.BackColor = ColorTranslator.FromHtml("#FF4500");
            btnSignUp.BackColor = Color.FromArgb(30, 0, 0, 0);
           
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            panel_signUp.BringToFront();

            btnSignUp.BackColor = ColorTranslator.FromHtml("#FF4500");
            btnSignIn.BackColor = Color.FromArgb(30, 0, 0, 0);
             

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {

        }
    }
}
