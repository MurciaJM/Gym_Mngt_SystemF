using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Service.Session_Service;
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
    public partial class SessionCard : UserControl
    {
        public string SessionName { get; set; }
        public string TimeIn { get; set; }
        public string staffName { get; set; }
        public DateTime Date { get; set; }

        public SessionCard()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                SetData(SessionName, Date, staffName);
            }
        }

        public void SetData(string name, DateTime date, string sName)
        {
            SessionName = name;
            staffName = sName;
            Date = date;

            lblName.Text = name;
            lblDate.Text = date.ToString("MMMM dd, yyyy");
            lblStaff.Text = staffName;
        }


        public static SessionCard Create(string name, DateTime date, string staffName)
        {
            var card = new SessionCard();
            card.SetData(name, date, staffName);
            return card;

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}