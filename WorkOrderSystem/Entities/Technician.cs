using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkOrderSystem.Entities
{
    public class Technician
    {
        public int TechnicianId { get; set; }

        public required string TechnicianName { get; set; }

        public required string TechnicianEmail { get; set; }

        public ICollection<WorkOrder>? WorkOrders { get; set; }
    }
}
