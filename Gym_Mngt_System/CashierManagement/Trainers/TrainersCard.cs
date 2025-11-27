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

namespace Gym_Mngt_System.CashierManagement.Trainers
{
    public partial class TrainersCard : UserControl
    {
        public string TrainerName { get; private set; }
        public string Schedule { get; private set; }
        public string Gender { get; private set; }
        public Staff TrainerData { get; private set; }

        public TrainersCard()
        {
            InitializeComponent();
        }

        private void TraindersCard_Load(object sender, EventArgs e)
        {

        }
        public static TrainersCard Create(Staff staff)
        {
            var card = new TrainersCard();

            card.TrainerData = staff;
            card.TrainerName = staff.getFullname();
            card.Schedule = staff.scheduleDate;
            card.Gender = staff.gender;


            card.lblStaffName.Text = card.TrainerName;
            card.lblSchedule.Text = card.Schedule ?? "No schedule";
            card.lblGender.Text = card.Gender;

            card.Tag = staff;

            return card;
        }
        private void btnTrainerDetails_Click(object sender, EventArgs e)
        {
            if (TrainerData == null) return;

            // Load the trainer WITH trainees
            var staffService = new StaffService();
            var detailedTrainer = staffService.GetTrainerWithTrainees(TrainerData.StaffID);

            if (detailedTrainer != null)
            {
                var frm = new TrainerDetailsFrm(detailedTrainer);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed to load trainer details.");
            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
