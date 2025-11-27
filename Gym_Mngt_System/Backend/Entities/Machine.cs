using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mngt_System.AdminManagement.Inventory_Management
{
    public class Machine
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public MachineStatus Status { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public List<MaintenanceCheck> Checks { get; set; } = new List<MaintenanceCheck>();
        public bool IsMachine { get; set; }
    }

    public class MaintenanceCheck
    {
        public DateTime CheckDate { get; set; }
        public string Issue { get; set; }
        public string Notes { get; set; }
        public MachineStatus Status { get; set; }
    }

    public enum MachineStatus
    {
        Operating,
        Maintenance,
        OutOfService
    }
}
