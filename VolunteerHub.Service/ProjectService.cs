using System.Collections.Generic;
using VolunteerHub.Core.Models;
using VolunteerHub.Core.Repositories;

namespace VolunteerHub.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _repo;

        public ProjectService(IProjectRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Project>> GetAllAsync() => await _repo.GetAllAsync();

        public async Task<Project> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

        public void Create(Project project)
        {
            _repo.Create(project);
            _repo.SaveAsync();
        }

        public async Task UpdateAsync(int id, Project project)
        {
            _repo.UpdateAsync(id, project);
            await _repo.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _repo.DeleteAsync(id);
            await _repo.SaveAsync();
        }
    }
}


