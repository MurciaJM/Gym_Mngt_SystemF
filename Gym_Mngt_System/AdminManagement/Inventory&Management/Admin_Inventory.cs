using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mngt_System.AdminManagement.Inventory_Management
{
    public partial class Admin_Inventory : Form
    {
        private int navAnimationSpeed = 8;
        private Form activeForm = null;  

        public Admin_Inventory()
        {
            InitializeComponent();
            InitializeNavigationPanel();

            
            this.Load += Admin_Inventory_Load;
        }

        private void Admin_Inventory_Load(object sender, EventArgs e)
        {
          
            LoadFormInPanel(new MachinesFrm());
        }

        private void InitializeNavigationPanel()
        {
            if (pnlNav == null || btnCheckMachine == null)
            {
                Debug.WriteLine("Warning: pnlNav or btnCheckMachine is null");
                return;
            }

            pnlNav.Width = btnCheckMachine.Width;
            pnlNav.Height = 3;
            pnlNav.Top = btnCheckMachine.Bottom;
            pnlNav.Left = btnCheckMachine.Left;
            pnlNav.Visible = true;
            pnlNav.BringToFront();
        }

        private async Task AnimateNavPanelAsync(Control targetButton, bool fast = false)
        {
            if (pnlNav == null || targetButton == null)
                return;

            int startLeft = pnlNav.Left;
            int targetLeft = targetButton.Left;

            int steps = fast ? 8 : 12;
            int delay = fast ? 10 : navAnimationSpeed;

            for (int i = 1; i <= steps; i++)
            {
                double progress = (double)i / steps;
                double eased = 1 - Math.Pow(1 - progress, 3);
                pnlNav.Left = startLeft + (int)((targetLeft - startLeft) * eased);
                await Task.Delay(delay);
            }

            pnlNav.Left = targetLeft;
        }

        private void LoadFormInPanel(Form frm)
        {
             
            if (activeForm != null)
                activeForm.Close();

            activeForm = frm;

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelLoader.Controls.Clear();  
            panelLoader.Controls.Add(frm);
            frm.Show();
        }

        private async void btnCheckMachine_Click(object sender, EventArgs e)
        {
            await AnimateNavPanelAsync(btnCheckMachine, fast: true);
            LoadFormInPanel(new MachinesFrm());
        }

        private async void btnCheckEquipment_Click(object sender, EventArgs e)
        {
            await AnimateNavPanelAsync(btnCheckEquipment, fast: true);
            LoadFormInPanel(new EquipmentsFrm());
        }

        private async void btnInventory_Click(object sender, EventArgs e)
        {
            await AnimateNavPanelAsync(btnInventory, fast: true);
            LoadFormInPanel(new Inventory());
        }
    }
}
