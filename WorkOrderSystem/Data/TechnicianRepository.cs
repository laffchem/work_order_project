using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkOrderSystem.Core.Interfaces;
using WorkOrderSystem.Entities;

namespace WorkOrderSystem.Data
{
    public class TechnicianRepository : ITechnicianRepository
    {
        private readonly WODbContext _context;

        public TechnicianRepository(WODbContext context)
        {
            _context = context;
        }

        public async Task<Technician> GetTechnicianByIdAsync(int id)
        {
            return await _context.Technicians.FirstOrDefaultAsync(t => t.TechnicianId == id);
        }

        public async Task<IReadOnlyList<Technician>> GetTechniciansAsync()
        {
            return await _context.Technicians.ToListAsync();
        }
    }
}
