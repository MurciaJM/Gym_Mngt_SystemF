using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Gym_Mngt_System
{
    public partial class Dashboard : Form
    {
        
        private readonly Dictionary<Control, Point> originalLocations = new Dictionary<Control, Point>();

         
        private readonly Dictionary<Control, int> currentOffsets = new Dictionary<Control, int>();

        private Timer hoverTimer;

        private const int HoverAmount = -6;   
        private const int Step = 1;          

        public Dashboard()
        {
            InitializeComponent();

             
            originalLocations[btnTotalMembers] = btnTotalMembers.Location;
            originalLocations[btnActive] = btnActive.Location;
            originalLocations[btnToday_ins] = btnToday_ins.Location;
            originalLocations[btnTotalEquipment] = btnTotalEquipment.Location;

             
            currentOffsets[btnTotalMembers] = 0;
            currentOffsets[btnActive] = 0;
            currentOffsets[btnToday_ins] = 0;
            currentOffsets[btnTotalEquipment] = 0;

             
            hoverTimer = new Timer { Interval = 15 };
            hoverTimer.Tick += HoverTimer_Tick;

             
            RegisterHover(btnTotalMembers);
            RegisterHover(btnActive);
            RegisterHover(btnToday_ins);
            RegisterHover(btnTotalEquipment);
        }

        private void RegisterHover(Control ctrl)
        {
            ctrl.MouseEnter += (s, e) =>
            {
                ctrl.Tag = HoverAmount;  
                Debug.WriteLine($"MouseEnter {ctrl.Name}");
                hoverTimer.Start();
            };

            ctrl.MouseLeave += (s, e) =>
            {
                ctrl.Tag = 0;  
                Debug.WriteLine($"MouseLeave {ctrl.Name}");
                hoverTimer.Start();
            };
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            bool anyAnimating = false;

            foreach (var ctrl in originalLocations.Keys)
            {
                if (!(ctrl.Tag is int targetOffset)) targetOffset = 0;

                int currentOffset = currentOffsets[ctrl];

                if (currentOffset < targetOffset) currentOffset += Step;
                else if (currentOffset > targetOffset) currentOffset -= Step;

                currentOffsets[ctrl] = currentOffset;

                 
                var orig = originalLocations[ctrl];
                ctrl.Location = new Point(orig.X, orig.Y + currentOffset);

                if (currentOffset != targetOffset)
                    anyAnimating = true;
            }

             
            if (!anyAnimating)
                hoverTimer.Stop();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
