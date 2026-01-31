using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunteerHub.Core.Models;

namespace VolunteerHub.Core.Repositories
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetAllAsync();
        Task<Project> GetByIdAsync(int id);
        Project Create(Project project);
        Task<Project> UpdateAsync(int id, Project project);
        Task<bool> DeleteAsync(int id);
        public Task SaveAsync();
    }
}
