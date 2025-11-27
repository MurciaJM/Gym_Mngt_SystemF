using Gym_Mngt_System.AdminManagement.Inventory_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Repositories.MachineRepository
{
    interface IMachineRepository
    {
        IEnumerable<Machine> GetAll();
        void AddMachine(Machine machine);
        void UpdateMachine(Machine machine);
    }
}
