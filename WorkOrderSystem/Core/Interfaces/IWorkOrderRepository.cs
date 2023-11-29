using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkOrderSystem.Entities;
using WorkOrderSystem.Enums;

namespace WorkOrderSystem.Core.Interfaces
{
    public interface IWorkOrderRepository
    {
        Task<WorkOrder> GetWorkOrderByIdAsync(int id);
        Task<IReadOnlyList<WorkOrder>> GetWorkOrdersAsync();

        Task<IReadOnlyList<WorkOrder>> GetWorkOrderByStatusAsync(WorkOrderStatus status);
    }
}
