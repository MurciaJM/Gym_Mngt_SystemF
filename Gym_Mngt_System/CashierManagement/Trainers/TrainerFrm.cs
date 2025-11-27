using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Gym_Mngt_System.CashierManagement.Trainers
{
    public partial class TrainerFrm : Form
    {
        private readonly List<TrainersCard> _allTrainerCards = new List<TrainersCard>();
        private readonly StaffService _staffService = new StaffService(); // Use StaffService
        private List<Staff> _allTrainers = new List<Staff>();
        public TrainerFrm()
        {
            InitializeComponent();
        }

        private void TrainerFrm_Load(object sender, EventArgs e)
        {
            LoadTrainers();
        }

        private void LoadTrainers()
        {
            flpTrainer.Controls.Clear();
            _allTrainerCards.Clear();

            var trainers = _staffService.GetAllTrainer();

            foreach (var t in trainers)
            {
                var card = TrainersCard.Create(t);
                card.Margin = new Padding(8);

                card.Click += (s, e) =>
                {
                    var detailedTrainer = _staffService.GetTrainerWithTrainees(t.StaffID);

                    if (detailedTrainer != null)
                    {
                        var detailForm = new TrainerDetailsFrm(detailedTrainer);
                        detailForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Failed to load trainer details.");
                    }
                };

                _allTrainerCards.Add(card);
                flpTrainer.Controls.Add(card);
            }

            if (!_allTrainerCards.Any())
            {
                DisplayNoTrainersMessage();
            }
        }

        private void DisplayNoTrainersMessage()
        {
            var noTrainersLabel = new Label
            {
                Text = "No trainers found.",
                AutoSize = false,
                Width = flpTrainer.Width - 20,
                Height = 40,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                ForeColor = System.Drawing.Color.Gray,
                Margin = new Padding(8)
            };
            flpTrainer.Controls.Add(noTrainersLabel);
        }


        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
