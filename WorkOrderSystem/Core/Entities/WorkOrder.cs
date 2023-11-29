using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkOrderSystem.Enums;

namespace WorkOrderSystem.Entities
{
    public class WorkOrder
    {
        public int WorkOrderId { get; set; }
        public string? Email { get; set; }
        public string? ContactName { get; set; }
        public string? ContactNumber { get; set; }
        public string? Problem { get; set; }
        public string? TechnicianComments { get; set; }
        public int? TechnicianId { get; set; }
        public Technician? Technician { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateAssigned { get; set; }
        public DateTime? DateComplete { get; set; }
        public WorkOrderStatus? Status { get; set; }
    }
}
