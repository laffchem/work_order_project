using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkOrderSystem.Core.Interfaces;
using WorkOrderSystem.Entities;
using WorkOrderSystem.Enums;

namespace WorkOrderSystem.Data
{
    public class WorkOrderRepository : IWorkOrderRepository
    {
        private readonly WODbContext _context;

        public WorkOrderRepository(WODbContext context)
        {
            _context = context;
        }

        public async Task<WorkOrder> GetWorkOrderByIdAsync(int id)
        {
            return await _context
                .WorkOrders
                .Include(w => w.Technician)
                .FirstOrDefaultAsync(w => w.WorkOrderId == id);
        }

        public async Task<IReadOnlyList<WorkOrder>> GetWorkOrderByStatusAsync(
            WorkOrderStatus status
        )
        {
            return await _context
                .WorkOrders
                .Include(w => w.Technician)
                .Where(w => w.Status == status)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<WorkOrder>> GetWorkOrdersAsync()
        {
            return await _context.WorkOrders.Include(w => w.Technician).ToListAsync();
        }
    }
}
