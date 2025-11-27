using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Gym_Mngt_System.AdminManagement;
using Gym_Mngt_System.AdminManagement.Staffs;

namespace Gym_Mngt_System
{
    public partial class Dashboard : Form
    {
        private readonly Dictionary<Control, Point> originalLocations = new Dictionary<Control, Point>();
        private readonly Dictionary<Control, int> currentOffsets = new Dictionary<Control, int>();
        private readonly Dictionary<Control, Control> linkedControls = new Dictionary<Control, Control>();
        private readonly HashSet<Control> activeControls = new HashSet<Control>();  
        private Timer hoverTimer;

        private AdminFrm adminFrm;

        private const int HoverAmount = -6;
        private const int AnimationStep = 1;
        private const int TimerInterval = 10;

        public Dashboard(AdminFrm adminFrm)
        {
            InitializeComponent();
            InitializeHoverAnimation();
            this.adminFrm = adminFrm;
        }

        private void InitializeHoverAnimation()
        {
            hoverTimer = new Timer();
            hoverTimer.Interval = TimerInterval;
            hoverTimer.Tick += HoverTimer_Tick;

            
            StoreOriginalLocation(btnTotalMembers);
            StoreOriginalLocation(btnActiveMem);
            StoreOriginalLocation(btnTotalEquipment);
            StoreOriginalLocation(btnAddStaff);
            StoreOriginalLocation(btnAddEquipment);
            StoreOriginalLocation(btnMachineInventory);
            StoreOriginalLocation(lblTotalMem);
            StoreOriginalLocation(lblActiveMem);
            StoreOriginalLocation(lblTotalEquipment);
             
         
            linkedControls[btnTotalMembers] = lblTotalMem;
            linkedControls[btnActiveMem] = lblActiveMem;
            linkedControls[btnTotalEquipment] = lblTotalEquipment;

         
            RegisterHover(btnTotalMembers);
            RegisterHover(btnActiveMem);
            RegisterHover(btnTotalEquipment);
            RegisterHover(btnAddStaff);
            RegisterHover(btnAddEquipment);
            RegisterHover(btnMachineInventory);
           
        }

        private void StoreOriginalLocation(Control ctrl)
        {
            originalLocations[ctrl] = ctrl.Location;
            currentOffsets[ctrl] = 0;
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

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void ApplyRoundedCorners(Control panel)
        {
            panel.Region = Region.FromHrgn(
                Login.CreateRoundRectRgn(6, 6, panel.Width, panel.Height, 50, 50)
            );
        }

        private void guna2Panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        public static int parentX, parentY;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckLiftingFrm checkMachineFrm = new CheckLiftingFrm();
            checkMachineFrm.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActiveMem_Click(object sender, EventArgs e)
        {

        }

        private void btnTotalMembers_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTotalEquipment_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pic2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (adminFrm != null)
            {
                adminFrm.UpdateNavigation(
                    adminFrm.btnStaff,
                    "Add Staff",
                    "Manage your team members",
                    "StaffAdd",
                    () =>
                    {
                        AddStaffFrm add = new AddStaffFrm(adminFrm);
                        add.TopLevel = false;
                        add.FormBorderStyle = FormBorderStyle.None;
                        add.Dock = DockStyle.Fill;
                        return add;
                    }
                );
            }
        }
        
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            AddEquipmentFrm addEquipmentFrm = new AddEquipmentFrm();
            addEquipmentFrm.Show();
        }

        private void btnMachineInventory_Click(object sender, EventArgs e)
        {
            AddMachineFrm addMachineFrm = new AddMachineFrm();
            addMachineFrm.Show();
        }

        private void modalEffect_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect.Stop();
            }
            else
            {
                Opacity += .03;
            }
        }
    }
}