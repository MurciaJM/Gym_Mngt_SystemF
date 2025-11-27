using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Entities
{
    public class MembershipType
    {
        public int membershipTypeID { get; set; }
        public string typeName { get; set; }
        public int durationInDays { get; set; }
        public decimal price { get; set; }
        public override string ToString()
        {
            return $"{typeName} - ₱{price:N2} / {durationInDays} days";
        }
    }
}
