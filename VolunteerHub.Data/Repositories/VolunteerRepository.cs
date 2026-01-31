using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VolunteerHub.Core.Models;
using VolunteerHub.Core.Repositories;
namespace VolunteerHub.Data.Repositories
{
    public class VolunteerRepository : IVolunteerRepository
    {
        private  readonly DataContext _Volunteers;

        public VolunteerRepository(DataContext Volunteers)
        {
            _Volunteers = Volunteers;
        }

        public async Task<IEnumerable<Volunteer>> GetAllAsync()
        {
            return await _Volunteers.volunteer.ToListAsync();
        }

            public async Task<Volunteer> GetByIdAsync(int id) =>
            await _Volunteers.volunteer.FirstOrDefaultAsync(v => v.Id == id);

        public Volunteer Create(Volunteer volunteer)
        {
            _Volunteers.volunteer.Add(volunteer);
            return volunteer;
        }

        public async Task<Volunteer> UpdateAsync(int id, Volunteer volunteer)
        {
            var existing =await GetByIdAsync(id);
            if (existing == null) return null;

            existing.FullName = volunteer.FullName;
            existing.Email = volunteer.Email;
            existing.Phone = volunteer.Phone;
            existing.Status = volunteer.Status;
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var volunteer =await GetByIdAsync(id);
            if (volunteer == null) return false;

            _Volunteers.volunteer.Remove(volunteer);
            return true;
        }
        public async Task SaveAsync()
        {
            await _Volunteers.SaveChangesAsync();
        }
    }
}

