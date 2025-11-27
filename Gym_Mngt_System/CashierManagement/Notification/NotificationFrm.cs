using Guna.UI2.WinForms;
using Gym_Mngt_System.CashierManagement.Notification;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Gym_Mngt_System
{
    public partial class NotificationFrm : Form
    {
        string conString = @"Data Source=JIEM\SQLEXPRESS;Initial Catalog=gym_db;Integrated Security=True;";
        private FlowLayoutPanel flowPanelNotifications;

        private List<NotificationCard> allNotifications = new List<NotificationCard>();

        public NotificationFrm()
        {
            InitializeComponent();

        }

        private void NotificationFrm_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            flpNotification.Controls.Clear();

            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = @"
        SELECT s.sms_id, 
               CONCAT(m.fname, ' ', m.middle, ' ', m.lname)AS member_name, 
               s.membership_id, 
               s.phone_number, 
               s.sent_date, 
               mem.date_start,  
               mem.date_end     
        FROM sms_notification s
        LEFT JOIN membership mem ON s.membership_id = mem.membership_id
        LEFT JOIN members m ON mem.member_id = m.member_id
        ORDER BY s.sent_date DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    NotificationCard notif = new NotificationCard();

                    string name = row["member_name"].ToString();
                    DateTime startDate = Convert.ToDateTime(row["date_start"]);
                    DateTime endDate = Convert.ToDateTime(row["date_end"]);
                    DateTime today = DateTime.Today;

                    string autoMessage = GenerateMessage(name, startDate, endDate);

                    notif.MemberName = name;
                    notif.PNumber = row["phone_number"].ToString();
                    notif.Message = autoMessage;
                    notif.SentDate = Convert.ToDateTime(row["sent_date"]);

                    flpNotification.Controls.Add(notif);
                }
            }
        }

        private string GenerateMessage(string name, DateTime start, DateTime end)
        {
            DateTime today = DateTime.Today;

            if (start == today)
            {
                return $"Welcome {name}! Your membership has been \n activated today. Enjoy your workout!";
            }

            if ((end - today).TotalDays == 1)
            {
                return $"Hello {name}, your gym membership will \n expire tomorrow. Please renew to \n avoid interruption.";
            }

            if (end == today)
            {
                return $"Hi {name}, your membership has \n expired today. Feel free to \n visit us to renew.";
            }

            return $"Hello {name}, thank you for being part \n of our gym!";
        }

        public void AddNotification(string memberName, string pnum, string message)
        {
            var card = new NotificationCard
            {
                MemberName = memberName,
                PNumber = pnum,
                Message = message,
                Icon = "⚠",
                Margin = new Padding(8)
            };

            allNotifications.Add(card);
        }

        private void FilterNotifications()
        {
            string selected = cbNotification?.SelectedItem?.ToString() ?? "All Notifications";
            string searchText = tbSearch?.Text.ToLower() ?? string.Empty;

            flpNotification.Controls.Clear();

            foreach (var card in allNotifications)
            {
                bool matchFilter = selected == "All Notifications" ||
                                   (selected == "Expiring Memberships" && card.Message.ToLower().Contains("expires")) ||
                                   (selected == "Expired Memberships" && card.Message.ToLower().Contains("expired"));

                bool matchSearch = string.IsNullOrWhiteSpace(searchText) ||
                                   card.MemberName.ToLower().Contains(searchText) ||
                                   card.PNumber.ToLower().Contains(searchText) ||
                                   card.Message.ToLower().Contains(searchText);

                if (matchFilter && matchSearch)
                    flpNotification.Controls.Add(card);
            }
        }

        private void cbNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterNotifications();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            FilterNotifications();
        }
    }
}
