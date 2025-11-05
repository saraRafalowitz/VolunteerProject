using VolunteerHub.Models;

namespace VolunteerHub.DataContext.DataContextVolunteer
{
    public interface IDataContext
    {
        public List<Volunteer> volunteer { get; set; }
    }
}
