using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.CashierManagement.Memberships
{
public class MemberAddedEventArgs
    {

        public string MemberID { get; }
        public string MemberName { get; }
        public string MembershipPlan { get; }
        public string Gender { get; }
      
        public string Trainer { get; }
        public string ContactNumber { get; }


        public MemberAddedEventArgs(string id, string name, string plan, string gender,
           string trainer, string contact)

        {
            MemberID = id;
            MemberName = name;
            MembershipPlan = plan;
            Gender = gender;
     
            Trainer = trainer;
            ContactNumber = contact;
        }
    }
}
