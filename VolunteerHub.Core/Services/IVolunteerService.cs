using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunteerHub.Core.Models;

namespace VolunteerHub.Core.Services
{
    public interface IVolunteerService
    {
        Task<IEnumerable<Volunteer>> GetAllAsync();
        Task<Volunteer> GetByIdAsync(int id);
        void Create(Volunteer volunteer);
        Task UpdateAsync(int id, Volunteer volunteer);
        Task DeleteAsync(int id);
    }
}
