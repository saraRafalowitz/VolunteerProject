using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VolunteerHub.Core.Models;
using VolunteerHub.Core.Repositories;


namespace VolunteerHub.Data.Repositories
{
    public class ProjectRepository : IProjectRepository 
    {
        private readonly DataContext _Projects;

        public ProjectRepository(DataContext project)
        {
            _Projects = project;
        }

        public async Task<IEnumerable<Project>> GetAllAsync() => await _Projects.project.Include(v=>v.Volunteers).ToListAsync();

        public async Task<Project> GetByIdAsync(int id) =>
            await _Projects.project.FirstOrDefaultAsync(p => p.Id == id);

        public Project Create(Project project)
        {
            _Projects.project.Add(project);
            return project;
        }
        public async Task<Project> UpdateAsync(int id, Project project)
        {
            var existing =await GetByIdAsync(id);
            if (existing == null) return null;

            existing.Name = project.Name;
            existing.Description = project.Description;
            existing.Date = project.Date;
            existing.Status = project.Status;
            return existing;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var project =await GetByIdAsync(id);
            if (project == null) return false;

            _Projects.project.Remove(project);
            return true;
        }
        public async Task SaveAsync()
        {
            await _Projects.SaveChangesAsync();
        }
    }
}

