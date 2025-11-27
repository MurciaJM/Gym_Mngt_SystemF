using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.Backend.Repositories.MachineRepository
{
    interface ILiftingRepository 
    {
        IEnumerable<Equipment> GetAllLiftingEquipments();
        long AddLiftingEquipment(Equipment equipment);
        void UpdateLiftingEquipment(Equipment equipment);

    }
}
