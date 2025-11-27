using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Entities
{
    public class Membership
    {
        public int memberID { get; set; }
        public int membershipID { get; set; }
        public string memberName { get; set; }
        public DateTime startDate { get; set; } 
        public DateTime endDate { get; set; }
        public string membershipType { get; set; }
        public string trainerName { get; set; }
        public string staffInCharge { get; set; }
        public string status { get; set; }
    }
}
