using System;
using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Service;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mngt_System.Staffs
{
    public partial class StaffCard : UserControl
    {
        public string StaffId { get => lblStaffID.Text; set => lblStaffID.Text = $"Staff ID - {value}"; }

        public string StaffName
        {
            get => lblStaffName.Text;
            set => lblStaffName.Text = value;
        }

        public string StaffPosition
        {
            get => lblStaffPosition.Text;
            set => lblStaffPosition.Text = value;
        }
        public string Days { get; set; }
        public string HiredDate { get; set; }
        public string ContactNumber { get; set; }
        public string StaffStatus
        {
            get => lblStaffStatus.Text;
            set
            {
                lblStaffStatus.Text = value;
                UpdateStatusLabelColor(value);   // ✅ Properly updates color
            }
        }

        public string Gender { get; set; }
        public string BirthDate { get; set; }

        public StaffCard()
        {
            InitializeComponent();

            btnStaffView.Click -= btnStaffView_Click;
            btnStaffEdit.Click -= btnStaffEdit_Click;

            btnStaffView.Click += btnStaffView_Click;
            btnStaffEdit.Click += btnStaffEdit_Click;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnStaffView_Click(object sender, EventArgs e)
        {
            ViewStaffDetails detailsForm = new ViewStaffDetails
            {
                StaffId = this.StaffId,
                StaffName = this.StaffName,
                Position = this.StaffPosition,
                HiredDate = this.HiredDate,
                ContactNumber = this.ContactNumber,
                Status = this.StaffStatus,
                Days = this.Days,
                Gender = this.Gender,
                BirthDate = this.BirthDate
            };

            detailsForm.Show();
        }

        private IEnumerable<Control> GetAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                yield return control;
                foreach (Control child in GetAllControls(control))
                {
                    yield return child;
                }
            }
        }

        private void btnStaffEdit_Click(object sender, EventArgs e)
        {
            using (var editForm = new EditStaff())
            {
                editForm.StaffId = this.StaffId;
                editForm.StaffName = this.StaffName;
                editForm.StaffPosition = this.StaffPosition;
                editForm.StaffStatus = this.StaffStatus;
                editForm.Gender = this.Gender;
                editForm.BirthDate = this.BirthDate;

                editForm.StaffUpdated += (s, args) =>
                {
                    this.StaffStatus = editForm.StaffStatus;

                };

                editForm.StartPosition = FormStartPosition.CenterParent;
                editForm.ShowDialog();
            }
        }

        private void UpdateStatusLabelColor(string status)
        {
            if (status == "Active")
            {
                lblStaffStatus.ForeColor = Color.FromArgb(50, 205, 50);   
            }
            else if (status == "Inactive")
            {
                lblStaffStatus.ForeColor = Color.FromArgb(220, 20, 60);   
            }
            else
            {
                lblStaffStatus.ForeColor = Color.White;   
            }
        }

        private void lblStaffStatus_Click(object sender, EventArgs e)
        {
        }
    }
}
