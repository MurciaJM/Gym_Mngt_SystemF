using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System
{

    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Location { get; set; }
        public long Quantity { get; set; }
        public long TotalQuantity { get; set; }
        public EquipmentType Type { get; set; }
        public EquipmentStatus Status { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public List<MaintenanceCheck> Checks { get; set; } = new List<MaintenanceCheck>();
        public bool IsLifting { get; set; }
    }

    public class MaintenanceCheck
    {
        public DateTime CheckDate { get; set; }
        public string Issue { get; set; }
        public string Notes { get; set; }
        public EquipmentStatus Status { get; set; }
    }

    public enum EquipmentType
    {
        Machine,
        Lifting
    }
    public enum EquipmentStatus
    {
        Operating,
        Maintenance,
        OutOfService
    }

}
