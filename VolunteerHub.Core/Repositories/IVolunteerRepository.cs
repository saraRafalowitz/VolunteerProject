using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunteerHub.Core.Models;

namespace VolunteerHub.Core.Repositories
{
    public interface IVolunteerRepository
    {
        Task<IEnumerable<Volunteer>> GetAllAsync();
        Task<Volunteer> GetByIdAsync(int id);
        Volunteer Create(Volunteer volunteer);
        Task<Volunteer> UpdateAsync(int id, Volunteer volunteer);
        Task<bool> DeleteAsync(int id);
        public Task SaveAsync();
    }
}
