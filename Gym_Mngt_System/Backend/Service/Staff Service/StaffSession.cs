using Gym_Mngt_System.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Session
{
    public class StaffSession
    {
        public static Staff LoggedInStaff { get; set; }
        public void logout()
        {
            LoggedInStaff = null;
        }
    }
}
