using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Entities
{
    class MemberLog
    {
        public int logId { get; set; }
        public string fname { get;set; }
        public string middle { get; set; }
        public string lname { get; set; }
        public DateTime checkInTime { get; set; }
        public string getFullname() => $"{fname} {middle} {lname}";
        public string FormattedTime() => checkInTime.ToString("hh:mm tt");
        public string FormattedDate() => checkInTime.ToString("yyyy-MM-dd");
    }
}
