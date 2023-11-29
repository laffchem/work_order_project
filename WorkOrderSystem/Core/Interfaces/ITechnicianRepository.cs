using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkOrderSystem.Entities;

namespace WorkOrderSystem.Core.Interfaces
{
    public interface ITechnicianRepository
    {
        Task<Technician> GetTechnicianByIdAsync(int id);

        Task<IReadOnlyList<Technician>> GetTechniciansAsync();
    }
}
