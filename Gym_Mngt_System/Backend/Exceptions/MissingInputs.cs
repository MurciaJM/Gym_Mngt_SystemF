using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Exceptions
{
    class MissingInputs : Exception
    {
        public MissingInputs(string message) : base(message)
        {
        }
    }
}
