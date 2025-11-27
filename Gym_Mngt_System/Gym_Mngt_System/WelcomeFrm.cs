using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mngt_System
{
    public partial class WelcomeFrm : Form
    {
        private Timer fadeTimerDashboard;
        private int fadeStepDashboard = 0;
        private bool fadingInDashboard = false;


        private Timer fadeTimerMembers;
        private int fadeStepMembers = 0;
        private bool fadingInMembers = false;

        private Timer fadeTimerCheckIns;
        private int fadeStepCheckIns = 0;
        private bool fadingInCheckIns = false;

        private Timer fadeTimerClasses;
        private int fadeStepClasses = 0;
        private bool fadingInClasses = false;

        private Timer fadeTimerEquipment;
        private int fadeStepEquipment = 0;
        private bool fadingInEquipment = false;

        private Timer fadeTimerPayment;
        private int fadeStepPayment = 0;
        private bool fadingInPayment = false;

        private Timer fadeTimerPlans;
        private int fadeStepPlans= 0;
        private bool fadingInPlans = false;

        public WelcomeFrm()
        {
            InitializeComponent();

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;

            lbl1.Text = "Dashboard";
            lbl2.Text = "Here's what happening at your gym today!";
            this.frmLoader.Controls.Clear();
            Dashboard frmDashboard_Vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();

            btnDashboard.MouseEnter += (s, e) =>
            {
                labelDashboard.Text = "Dashboard";
                labelDashboard.Location = new Point(
                    btnDashboard.Left + (btnDashboard.Width - labelDashboard.Width) / 2,
                    btnDashboard.Top - labelDashboard.Height - 5
                );
                labelDashboard.Visible = true;

                fadeStepDashboard = 0;
                fadingInDashboard = true;
                fadeTimerDashboard.Start();
            };

            btnDashboard.MouseLeave += (s, e) =>
            {
                fadingInDashboard = false;
                fadeTimerDashboard.Start();
            };



            btnMembers.MouseEnter += (s, e) =>
            {
                labelMem.Text = "Members";
                labelMem.Location = new Point(
                    btnMembers.Left + (btnMembers.Width - labelMem.Width) / 2,
                    btnMembers.Top - labelMem.Height - 5
                );
                labelMem.Visible = true;

                fadeStepMembers = 0;
                fadingInMembers = true;
                fadeTimerMembers.Start();
            };

            btnMembers.MouseLeave += (s, e) =>
            {
                fadingInMembers = false;
                fadeTimerMembers.Start();
            };


            btnCheck_ins.MouseEnter += (s, e) =>
            {
                labelCheck.Text = "Check-Ins";
                labelCheck.Location = new Point(
                    btnCheck_ins.Left + (btnCheck_ins.Width - labelCheck.Width) / 2,
                    btnCheck_ins.Top - labelCheck.Height - 5
                );
                labelCheck.Visible = true;

                fadeStepCheckIns = 0;
                fadingInCheckIns = true;
                fadeTimerCheckIns.Start();
            };

            btnCheck_ins.MouseLeave += (s, e) =>
            {
                fadingInCheckIns = false;
                fadeTimerCheckIns.Start();
            };

            btnClasses.MouseEnter += (s, e) =>
            {
                labelClasses.Text = "Classes";
                labelClasses.Location = new Point(
                    btnClasses.Left + (btnClasses.Width - labelClasses.Width) / 2,
                    btnClasses.Top - labelClasses.Height - 5
                );
                labelClasses.Visible = true;

                fadeStepClasses = 0;
                fadingInClasses = true;
                fadeTimerClasses.Start();
            };

            btnClasses.MouseLeave += (s, e) =>
            {
                fadingInClasses = false;
                fadeTimerClasses.Start();
            };

            btnEquipment.MouseEnter += (s, e) =>
            {
                labelEquipment.Text = "Equipment";
                labelEquipment.Location = new Point(
                    btnEquipment.Left + (btnEquipment.Width - labelEquipment.Width) / 2,
                    btnEquipment.Top - labelEquipment.Height - 5
                );
                labelEquipment.Visible = true;

                fadeStepEquipment = 0;
                fadingInEquipment = true;
                fadeTimerEquipment.Start();
            };

            btnEquipment.MouseLeave += (s, e) =>
            {
                fadingInEquipment = false;
                fadeTimerEquipment.Start();
            };

            btnPayment.MouseEnter += (s, e) =>
            {
                labelPayment.Text = "Payment";
                labelPayment.Location = new Point(
                    btnPayment.Left + (btnPayment.Width - labelPayment.Width) / 2,
                    btnPayment.Top - labelPayment.Height - 5
                );
                labelPayment.Visible = true;

                fadeStepPayment = 0;
                fadingInPayment = true;
                fadeTimerPayment.Start();
            };

            btnPayment.MouseLeave += (s, e) =>
            {
                fadingInPayment = false;
                fadeTimerPayment.Start();
            };

            btnPlans.MouseEnter += (s, e) =>
            {
                labelPlans.Text = "Plans";
                labelPlans.Location = new Point(
                    btnPlans.Left + (btnPlans.Width - labelPlans.Width) / 2,
                    btnPlans.Top - labelPlans.Height - 5
                );
                labelPlans.Visible = true;

                fadeStepPlans = 0;
                fadingInPlans= true;
                fadeTimerPlans.Start();
            };

            btnPlans.MouseLeave += (s, e) =>
            {
                fadingInPlans = false;
                fadeTimerPlans.Start();
            };

            fadeTimerDashboard = new Timer { Interval = 30 };
            fadeTimerDashboard.Tick += FadeTimerDashboard_Tick;

            fadeTimerMembers = new Timer { Interval = 30 };
            fadeTimerMembers.Tick += FadeTimerMembers_Tick;

            fadeTimerCheckIns = new Timer { Interval = 30 };
            fadeTimerCheckIns.Tick += FadeTimerCheckIns_Tick;

            fadeTimerClasses = new Timer { Interval = 30 };
            fadeTimerClasses.Tick += FadeTimerClasses_Tick;

            fadeTimerEquipment = new Timer { Interval = 30 };
            fadeTimerEquipment.Tick += FadeTimerEquipment_Tick;

            fadeTimerPayment = new Timer { Interval = 30 };
            fadeTimerPayment.Tick += FadeTimerPayment_Tick;


            fadeTimerPlans= new Timer { Interval = 30 };
            fadeTimerPlans.Tick += FadeTimerPlans_Tick;

        }


        private void FadeTimerDashboard_Tick(object sender, EventArgs e)
        {
            if (fadingInDashboard)
            {
                if (fadeStepDashboard < 255)
                {
                    fadeStepDashboard += 25;

                }
                else fadeTimerDashboard.Stop();
            }
            else
            {
                if (fadeStepDashboard > 0)
                {
                    fadeStepDashboard -= 25;
                    labelDashboard.ForeColor = Color.FromArgb(fadeStepDashboard, Color.White);
                }
                else
                {
                    fadeTimerDashboard.Stop();
                    labelDashboard.Visible = false;
                }
            }
        }


        private void FadeTimerMembers_Tick(object sender, EventArgs e)
        {
            if (fadingInMembers)
            {
                if (fadeStepMembers < 255)
                {
                    fadeStepMembers += 25;

                }
                else fadeTimerMembers.Stop();
            }
            else
            {
                if (fadeStepMembers > 0)
                {
                    fadeStepMembers -= 25;
                    labelMem.ForeColor = Color.FromArgb(fadeStepMembers, Color.White);
                }
                else
                {
                    fadeTimerMembers.Stop();
                    labelMem.Visible = false;
                }
            }
        }

        private void FadeTimerCheckIns_Tick(object sender, EventArgs e)
        {
            if (fadingInCheckIns)
            {
                if (fadeStepCheckIns < 255)
                {
                    fadeStepCheckIns += 25;

                }
                else fadeTimerCheckIns.Stop();
            }
            else
            {
                if (fadeStepCheckIns > 0)
                {
                    fadeStepCheckIns -= 25;

                }
                else
                {
                    fadeTimerCheckIns.Stop();
                    labelCheck.Visible = false;
                }
            }
        }

        private void FadeTimerClasses_Tick(object sender, EventArgs e)
        {
            if (fadingInClasses)
            {
                if (fadeStepClasses < 255)
                {
                    fadeStepClasses += 25;

                }
                else fadeTimerClasses.Stop();
            }
            else
            {
                if (fadeStepClasses > 0)
                {
                    fadeStepClasses -= 25;

                }
                else
                {
                    fadeTimerClasses.Stop();
                    labelClasses.Visible = false;
                }
            }
        }

        private void FadeTimerEquipment_Tick(object sender, EventArgs e)
        {
            if (fadingInEquipment)
            {
                if (fadeStepEquipment < 255)
                {
                    fadeStepEquipment += 25;

                }
                else fadeTimerEquipment.Stop();
            }
            else
            {
                if (fadeStepEquipment > 0)
                {
                    fadeStepEquipment -= 25;

                }
                else
                {
                    fadeTimerEquipment.Stop();
                    labelEquipment.Visible = false;
                }
            }
        }

        private void FadeTimerPayment_Tick(object sender, EventArgs e)
        {
            if (fadingInPayment)
            {
                if (fadeStepPayment < 255)
                {
                    fadeStepPayment += 25;

                }
                else fadeTimerPayment.Stop();
            }
            else
            {
                if (fadeStepPayment > 0)
                {
                    fadeStepPayment -= 25;

                }
                else
                {
                    fadeTimerPayment.Stop();
                    labelPayment.Visible = false;
                }
            }
        }


        private void FadeTimerPlans_Tick(object sender, EventArgs e)
        {
            if (fadingInPlans)
            {
                if (fadeStepPlans < 255)
                {
                    fadeStepPlans+= 25;

                }
                else fadeTimerPlans.Stop();
            }
            else
            {
                if (fadeStepPlans > 0)
                {
                    fadeStepPlans-= 25;

                }
                else
                {
                    fadeTimerPlans.Stop();
                    labelPlans.Visible = false;
                }
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;

            lbl1.Text = "Dashboard";
            lbl2.Text = "Here's what happening at your gym today!";
            this.frmLoader.Controls.Clear();
            Dashboard frmDashboard_Vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnMembers.Height;
            pnlNav.Top = btnMembers.Top;
            pnlNav.Left = btnMembers.Left;


            lbl1.Text = "Members";
            lbl2.Text = "Manage gym members and their memberships";
            this.frmLoader.Controls.Clear();
            MembersFrm frmDashboard_Vrb = new MembersFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnCheck_ins_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnCheck_ins.Height;
            pnlNav.Top = btnCheck_ins.Top;
            pnlNav.Left = btnCheck_ins.Left;


            lbl1.Text = "Check-Ins Management";
            lbl2.Text = "Track members gym attendance and activity";
            this.frmLoader.Controls.Clear();
            Check_insFrm frmDashboard_Vrb = new Check_insFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnClasses.Height;
            pnlNav.Top = btnClasses.Top;
            pnlNav.Left = btnClasses.Left;


            lbl1.Text = "Classes and Sessions";
            lbl2.Text = "Manage fitness classes and training sessions";
            this.frmLoader.Controls.Clear();
            ClassesFrm frmDashboard_Vrb = new ClassesFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEquipment.Height;
            pnlNav.Top = btnEquipment.Top;
            pnlNav.Left = btnEquipment.Left;

            lbl1.Text = "Equipment Management";
            lbl2.Text = "Track and maintain gym equipment";
            this.frmLoader.Controls.Clear();
            EquipmentFrm frmDashboard_Vrb = new EquipmentFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnPayment.Height;
            pnlNav.Top = btnPayment.Top;
            pnlNav.Left = btnPayment.Left;


            lbl1.Text = "Payment and Billing";
            lbl2.Text = "Track membership payments and revenue";
            this.frmLoader.Controls.Clear();
            PaymentFrm frmDashboard_Vrb = new PaymentFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnPlans_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPlans.Height;
            pnlNav.Top = btnPlans.Top;
            pnlNav.Left = btnPlans.Left;


            lbl1.Text = "Membership Plans";
            lbl2.Text = "Create and manage gym membership packages";
            this.frmLoader.Controls.Clear();
            PlansFrm frmDashboard_Vrb = new PlansFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }
    }


}
