using Gym_Mngt_System.Backend.Service.Session_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gym_Mngt_System
{
    public partial class Schedule : Form
    {

        private readonly List<SessionCard> _allSessions = new List<SessionCard>();
        private readonly SessionService _sessionService = new SessionService();
  
        public Schedule()
        {
            InitializeComponent();
       
            InitializeDatePicker();
            LoadSessions();
        }
 
        private void InitializeDatePicker()
        {
            guna2DateTimePicker1.Value = DateTime.Today;
        }
        private void LoadSessions()
        {
            flpSession.Controls.Clear();

            _allSessions.Clear();

            var sessions = _sessionService.GetAllSessions();

            foreach(var session in sessions)
            {
                var card = SessionCard.Create(session.getFullname(), session.date, session.staffName);
                _allSessions.Add(card);
                Margin = new Padding(8);

            }
            FilterAndDisplaySessions();
        }
        private void FilterAndDisplaySessions()
        {
            string searchTerm = tbSearch.Text.Trim().ToLower();
            DateTime selectedDate = guna2DateTimePicker1.Value;

            var filtered = _allSessions
                .Where(card =>
                    (string.IsNullOrEmpty(searchTerm) || card.SessionName.ToLower().Contains(searchTerm)) &&
                    card.Date.Date == selectedDate.Date)
                .ToList();

            flpSession.Controls.Clear();

            if (filtered.Any())
            {
                foreach (var card in filtered)
                    flpSession.Controls.Add(card);
                Margin = new Padding(8);

            }
            else
            {
                DisplayNoSessionsMessage();
            }
        }

        private void DisplayNoSessionsMessage()
        {
            var noSessionsLabel = new Label
            {
                Text = "No sessions found for this date.",
                AutoSize = false,
                Width = flpSession.Width - 20,
                Height = 40,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                ForeColor = System.Drawing.Color.Gray
            };
            flpSession.Controls.Add(noSessionsLabel);
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            LoadSessions();
        }

        private void btnAddSession_Click_1(object sender, EventArgs e)
        {
            var addForm = new AddSessions();
            DialogResult rs = addForm.ShowDialog(this);
            if (rs == DialogResult.OK)
            {
                LoadSessions();
                Margin = new Padding(8);
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FilterAndDisplaySessions();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            FilterAndDisplaySessions();
        }
    }
}