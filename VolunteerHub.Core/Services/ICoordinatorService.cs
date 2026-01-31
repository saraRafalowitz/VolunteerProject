using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunteerHub.Core.Models;

namespace VolunteerHub.Core.Services
{
    public interface ICoordinatorService
    {
        Task<IEnumerable<Coordinator>> GetAllAsync();
        Task<Coordinator> GetByIdAsync(int id);
        void Create(Coordinator coordinator);
        Task UpdateAsync(int id, Coordinator coordinator);
        Task DeleteAsync(int id);
    }
}
