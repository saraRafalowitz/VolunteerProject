using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using VolunteerHub.Core.Models;
using VolunteerHub.Core.Repositories;

namespace VolunteerHub.Core.Services
{
    public class VolunteerService : IVolunteerService
    {
        private readonly IVolunteerRepository _repo;

        public VolunteerService(IVolunteerRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Volunteer>> GetAllAsync() => await _repo.GetAllAsync();

        public async Task<Volunteer> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

        public async void Create(Volunteer volunteer)
        {
            _repo.Create(volunteer);
            await _repo.SaveAsync();
        }

        public async Task UpdateAsync(int id, Volunteer volunteer)
        {
            _repo.UpdateAsync(id, volunteer);
            await _repo.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _repo.DeleteAsync(id);
            await _repo.SaveAsync();
        }
    }
}

