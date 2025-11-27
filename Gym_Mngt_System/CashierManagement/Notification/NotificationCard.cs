using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mngt_System.CashierManagement.Notification
{
    public partial class NotificationCard : UserControl
    {
        public NotificationCard()
        {
            InitializeComponent();

        }


        public string MemberName
        {
            get => lblMemName.Text;
            set => lblMemName.Text = value;
        }

        public string PNumber
        {
            get => labelPnum.Text;
            set => labelPnum.Text = value;
        }
        public string Message
        {
            get => lblMessage.Text;
            set => lblMessage.Text = value;
        }

        public string Icon
        {
            get => lblIcon.Text;
            set
            {
                lblIcon.Text = value;
                lblIcon.ForeColor = Color.Red;

            }
        }
        public DateTime SentDate
        {
            set => lblDate.Text = value.ToString("MMM dd, yyyy - HH:mm");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
