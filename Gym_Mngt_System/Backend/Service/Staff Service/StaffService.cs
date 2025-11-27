using Gym_Mngt_System.Backend.Repositories;
using Gym_Mngt_System.Backend.Entities;
using Gym_Mngt_System.Backend.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Service
{
    class StaffService
    {
        private StaffRepository _staffRepo = new StaffRepository();

        public bool Login(string username, string password)
        {
            try
            {
                var _staff = Staff.Builder()
                    .withAccount(username, password)
                    .Build();

                var loggedInStaff = _staffRepo.staffWithAccount(_staff);

                if (loggedInStaff != null)
                {
                    // Set the logged in staff in the session
                    StaffSession.LoggedInStaff = loggedInStaff;
                    return true;
                }

                // If we get here, credentials were invalid
                StaffSession.LoggedInStaff = null;
                return false;
            }
            catch (Exception ex)
            {
                // Log the error or show it
                System.Diagnostics.Debug.WriteLine($"Login error: {ex.Message}");
                StaffSession.LoggedInStaff = null;
                throw new Exception($"Login failed: {ex.Message}", ex);
            }
        }

        public void Logout()
        {
            StaffSession.LoggedInStaff = null;
        }

        public bool accountExists(string username)
        {
            try
            {
                return _staffRepo.usernameExists(username);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Staff GetTrainerMember(Staff staff) //Trainer dashboard.
        {
            return _staffRepo.GetTrainerWithMembers(staff);
        }

        public IEnumerable<Staff> GetAllTrainer() //For trainer list and for combobox.
        {
            return _staffRepo.GetAllTrainer();
        }

        public IEnumerable<TrainerPlan> GetTrainerPlans()
        {
            return _staffRepo.GetTrainerPlans();
        }

        public IEnumerable<Staff> GetAllStaff()
        {
            return _staffRepo.GetAll();
        }
        public Staff GetTrainerWithTrainees(int staffId)
        {
            var result = _staffRepo.GetTrainerWithTrainees(staffId);

            // DEBUG
            if (result != null)
            {
                System.Diagnostics.Debug.WriteLine($"GetTrainerWithTrainees returned: {result.getFullname()}");
                System.Diagnostics.Debug.WriteLine($"Schedule: {result.scheduleDate}");
                System.Diagnostics.Debug.WriteLine($"Trainees: {result.memberWithTrainer?.Count ?? 0}");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("GetTrainerWithTrainees returned NULL!");
            }

            return result;
        }
        public void AddStaff(Staff staff, bool createAccount, string username = null, string password = null)
        {
            if (createAccount)
            {
                staff.account = new Account
                {
                    Username = username,
                    Password = password
                };
                _staffRepo.AddStaffWithAccount(staff);
            }
            else
            {
                _staffRepo.AddStaffWithoutAccount(staff);
            }
        }

        public void updateStaff(Staff staff)
        {
            _staffRepo.updateStaff(staff);
        }
    }
}