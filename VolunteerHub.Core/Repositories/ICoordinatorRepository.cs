using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunteerHub.Core.Models;

namespace VolunteerHub.Core.Repositories
{
    public interface ICoordinatorRepository
    {
        Task<IEnumerable<Coordinator>> GetAllAsync();
        Task<Coordinator> GetByIdAsync(int id);
        Coordinator Create(Coordinator coordinator);
        Task<Coordinator> UpdateAsync(int id, Coordinator coordinator);
        Task<bool> DeleteAsync(int id);
        public Task SaveAsync();
    }
}
