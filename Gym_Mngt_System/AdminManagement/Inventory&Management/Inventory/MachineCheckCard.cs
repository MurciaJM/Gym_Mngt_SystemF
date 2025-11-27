using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Mngt_System.Backend.Entities;

namespace Gym_Mngt_System
{
    public partial class MachineCheckCard : UserControl
    {
        public MachineCheckCard()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(238, 249, 241);
            this.Padding = new Padding(10);
        }

        public string MachineName
        {
            get => lblMachineName.Text;
            set => lblMachineName.Text = value;
        }

        public string CheckedBy
        {
            get => lblStaff.Text;
            set => lblStaff.Text = $"Checked by {value}";
        }

        public DateTime CheckDate
        {
            set
            {
                lblDateOnly.Text = value.ToString("MMM dd, yyyy");
                lblTimeOnly.Text = value.ToString("HH:mm");
            }
        }

        public string Status
        {
            get => lblStatus.Text;
            set => lblStatus.Text = value;
        }

        public string category
        {
            get => lblCategory.Text;
            set => lblCategory.Text = value;
        }

        public void SetData(string machineName, string checkedBy, string status, string category, DateTime checkDate)
        {
            lblMachineName.Text = machineName;
            lblStaff.Text = $"Checked By: {checkedBy}";
            lblStatus.Text = $"Status: {status}";
            lblCategory.Text = $"Category: {category}";
            lblDateOnly.Text = $"Checked on: {checkDate:MM/dd/yyyy}";
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }
    }
}
