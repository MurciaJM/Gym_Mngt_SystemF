using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Entities
{
    public class TrainerPlan
    {
        public int trainerPlanID { get; set; }
        public string planName { get; set; }
        public int durationInDays { get; set; }
        public decimal price { get; set; }

        public override string ToString()
        {
            return planName;
        }
    }
}
