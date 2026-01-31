using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunteerHub.Core.Repositories;
using VolunteerHub.Core.Models;
using VolunteerHub.Data;
using Microsoft.EntityFrameworkCore;


namespace VolunteerHub.Data.Repositories
{
    public class CoordinatorRepository : ICoordinatorRepository
    {
        private readonly DataContext _Coordinator;

        public CoordinatorRepository(DataContext Coordinator)
        {
            _Coordinator = Coordinator;
        }
        public async Task<IEnumerable<Coordinator>> GetAllAsync()
        {
            return await _Coordinator.Coordinator.Include(a => a.Projects).ToListAsync();
        }

        public async Task<Coordinator> GetByIdAsync(int id)
        {
            return await _Coordinator.Coordinator.FirstOrDefaultAsync(p => p.Id == id);
        }
        public Coordinator Create(Coordinator coordinator)
        {
            _Coordinator.Coordinator.Add(coordinator);
            return coordinator;
        }

        public async Task<Coordinator> UpdateAsync(int id, Coordinator coordinator)
        {
            var existing =await GetByIdAsync(id);
            if (existing == null) return null;


            existing.FullName = coordinator.FullName;
            existing.Id = coordinator.Id;
            existing.Projects = coordinator.Projects;
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var coordinator =await GetByIdAsync(id);
            if (coordinator == null) return false;

             _Coordinator.Coordinator.Remove(coordinator);
            return true;
        }
        public async Task SaveAsync()
        {
            await _Coordinator.SaveChangesAsync();
        }
    }

}