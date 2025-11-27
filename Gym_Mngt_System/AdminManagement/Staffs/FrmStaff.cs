    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
using Gym_Mngt_System.AdminManagement;
using Gym_Mngt_System.AdminManagement.Staffs;
using Gym_Mngt_System.Backend.Entities;
    using Gym_Mngt_System.Backend.Service;
using Gym_Mngt_System.CashierManagement.Memberships;
    using Gym_Mngt_System.Staffs;

    namespace Gym_Mngt_System
    {
        public partial class FrmStaff : Form
        {



        private AdminFrm adminFrm;

        private readonly StaffService staffService;


        private class FadeController
        {
            public Timer Timer { get; set; }
            public int FadeStep { get; set; }
            public bool FadingIn { get; set; }
            public Label Label { get; set; }

            public FadeController(Label label)
            {
                Label = label;
                Timer = new Timer { Interval = 30 };
                Timer.Tick += OnTick;
            }

            private void OnTick(object sender, EventArgs e)
            {
                if (FadingIn)
                {
                    FadeStep += 25;
                    if (FadeStep >= 255)
                    {
                        FadeStep = 255;
                        Timer.Stop();
                    }
                    Label.ForeColor = Color.FromArgb(FadeStep, Color.Black);
                }
                else
                {
                    FadeStep -= 25;
                    if (FadeStep <= 0)
                    {
                        FadeStep = 0;
                        Label.ForeColor = Color.FromArgb(FadeStep, Color.Black);
                        Timer.Stop();
                        Label.Visible = false;
                    }
                    else
                    {
                        Label.ForeColor = Color.FromArgb(FadeStep, Color.Black);
                    }
                }
            }

            public void StartFadeIn()
            {
                FadeStep = 0;
                FadingIn = true;
                Label.Visible = true;
                Timer.Start();
            }

            public void StartFadeOut()
            {
                FadeStep = 0;
                FadingIn = false;
                Timer.Start();
            }
        }

        public FrmStaff(AdminFrm adminFrm)
            {
                InitializeComponent();
                  SetupHoverEffects();
                staffService = new StaffService();

                flpStaff.AutoScroll = true;

                LoadStaffCards();

                tbSearch.KeyDown -= TbSearch_KeyDown;
                tbSearch.KeyDown += TbSearch_KeyDown;

            this.adminFrm = adminFrm ?? throw new ArgumentNullException(nameof(adminFrm));

        }


        private void SetupHoverEffects()
        {
            SetupButtonHover(btnAddStaff, lblAddStaff, "Add Staff");
        }

        private void SetupButtonHover(Control button, Label label, string text)
        {
            var fadeController = new FadeController(label);


            label.Text = text;
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Visible = false;

            button.MouseEnter += (s, e) =>
            {

                label.Location = new Point(
                    button.Left + (button.Width - label.Width) / 2,
                    button.Top - label.Height - 5
                );
                fadeController.StartFadeIn();
            };

            button.MouseLeave += (s, e) => fadeController.StartFadeOut();
        }

        private void LoadStaffCards()
        {
            try
            {
                var staffList = staffService.GetAllStaff();
                LoadStaffCards(staffList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff cards: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void LoadStaffCards(IEnumerable<Staff> staffList)
            {
                try
                {
                    flpStaff.Controls.Clear();
                    foreach (var s in staffList)
                    {
                        var card = new StaffCard
                        {
                            StaffId = s.StaffID.ToString(),
                            StaffName = s.getFullname(),
                            StaffPosition = s.position,
                            HiredDate = s.FormattedHiredDate(),
                            ContactNumber = s.phoneNumber.ToString(),
                            StaffStatus = s.status,
                            Days = s.scheduleDate,
                            Gender = s.gender,
                            BirthDate = s.FormattedBirthdate(),
                            Margin = new Padding(6),
                            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                        };

                        flpStaff.Controls.Add(card);
                    }

                    if (!staffList.Any())
                    {
                        MessageBox.Show("No staff found matching your search.",
                                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading staff cards: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void TbSearch_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;

                    string q = tbSearch.Text?.Trim().ToLower() ?? "";

                    try
                    {
                        var searchStaff = staffService.GetAllStaff();
                        var filtered = searchStaff
                            .Where(x => x.getFullname().ToLower().Contains(q) || x.position.ToLower().Contains(q) || x.StaffID.ToString().ToLower().Contains(q))
                            .ToList();

                        LoadStaffCards(filtered);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Search error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



            private void FrmStaff_Load(object sender, EventArgs e)
            {

            }

            private void guna2Button1_Click(object sender, EventArgs e)
            {
                var active = staffService.GetAllStaff().Where(x => x.status == "Active").ToArray();
                LoadStaffCards(active);
            }

            private void guna2Button2_Click(object sender, EventArgs e)
            {
                var inactive = staffService.GetAllStaff().Where(x => x.status == "Inactive").ToArray();
                LoadStaffCards(inactive);
            }

            private void flpStaff_Paint(object sender, PaintEventArgs e)
            {

            }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (adminFrm == null)
            {
                MessageBox.Show("Parent Admin Form not found!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            adminFrm.MainLabel.Text = "Add Staff";
            adminFrm.frmLoaderAdmin.Controls.Clear();

            AddStaffFrm addStaffFrm = new AddStaffFrm(adminFrm);
            addStaffFrm.TopLevel = false;
            addStaffFrm.FormBorderStyle = FormBorderStyle.None;
            addStaffFrm.Dock = DockStyle.Fill;

            adminFrm.frmLoaderAdmin.Controls.Add(addStaffFrm);
            addStaffFrm.Show();
        }
    }
    }
    