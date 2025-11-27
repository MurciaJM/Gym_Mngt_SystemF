using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mngt_System.CashierManagement.Inventory
{
    public partial class EquipmentCheckCard : UserControl
    {
        public EquipmentCheckCard()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(238, 249, 241);
            this.Padding = new Padding(10);

        }

        public void SetData(string equipmentName, string checkedBy, string quantity, string totalQuantity, DateTime checkDate)
        {
            lblEquipment.Text = equipmentName;
            lblStaff.Text = $"Checked By: {checkedBy}";
            lblQty.Text = $"Quantity: {quantity}";
            lblTotalQty.Text = $"Total Quantity: {totalQuantity}";
            lblDateOnly.Text = $"Checked on: {checkDate:MM/dd/yyyy}";
        }

        public string MachineName
        {
            get => lblEquipment.Text;
            set => lblEquipment.Text = value;
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
        public string Quantity
        {
            get => lblQty.Text;
            set => lblQty.Text = value;
        }

        public string Total
        {
            get => lblTotalQty.Text;
            set => lblTotalQty.Text = value;
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
