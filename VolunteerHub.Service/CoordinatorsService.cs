using System.Collections.Generic;
using VolunteerHub.Core.Models;
using VolunteerHub.Core.Repositories; 

namespace VolunteerHub.Core.Services
{
    public class CoordinatorsService : ICoordinatorService
    {
        private readonly ICoordinatorRepository _repo; 

        public CoordinatorsService(ICoordinatorRepository repo) 
        {
            _repo = repo; 
        }

        public async Task<IEnumerable<Coordinator>> GetAllAsync() => await _repo.GetAllAsync();

        public async Task<Coordinator> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

        public void Create(Coordinator coordinator)
        {
            _repo.Create(coordinator);
            _repo.SaveAsync();
        }

        public async Task UpdateAsync(int id, Coordinator coordinator)
        {
            _repo.UpdateAsync(id, coordinator);
            await _repo.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _repo.DeleteAsync(id);
            await _repo.SaveAsync();
        }

       
    }
}

