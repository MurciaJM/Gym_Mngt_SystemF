using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Entities
{
    //One-day use customer.
    public class Sessions
    {
        public int SessionID { get; set; }
        public string fname { get; set; } //Change to fname, lname, middle name later.
        public string middle { get; set; }
        public string lname { get; set; }
        public DateTime date { get; set; }
        public string staffName { get; set; }
        public string getFullname() => $"{fname} {middle} {lname}";
        public string fullName => getFullname();
        //create builder pattern
    }
}
