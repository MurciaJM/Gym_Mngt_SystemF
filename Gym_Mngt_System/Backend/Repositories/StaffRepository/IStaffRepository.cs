using Gym_Mngt_System.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Repositories.Interface
{
    interface IStaffRepository
    {
        IEnumerable<Staff> GetAll();
        Staff GetTrainerWithTrainees(int staffId);
        Staff staffWithAccount(Staff staff);
        void AddStaffWithoutAccount(Staff staff);
        void updateStaff(Staff staff);
        bool usernameExists(string username, int? staffid = null);
        void AddStaffWithAccount(Staff staff);
    }
}
