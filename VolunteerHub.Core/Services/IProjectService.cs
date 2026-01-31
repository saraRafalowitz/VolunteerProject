using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunteerHub.Core.Models;

namespace VolunteerHub.Core.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAllAsync();
        Task<Project> GetByIdAsync(int id);
        void Create(Project project);
        Task UpdateAsync(int id, Project project);
        Task DeleteAsync(int id);
    }
}
