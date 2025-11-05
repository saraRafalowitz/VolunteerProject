using VolunteerHub.Models;

namespace VolunteerHub.DataContext.DataContextCoordinators
{
    public interface IDataContextCoordinators
    {
        public List<Coordinator> Coordinators { get; set; }
    }
}
