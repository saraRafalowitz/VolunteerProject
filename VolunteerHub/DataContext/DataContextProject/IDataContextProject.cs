using VolunteerHub.Models;

namespace VolunteerHub.DataContext.DataContextProject
{
    public interface IDataContextProject
    {
        public List<Project> project { get; set; }
    }
}
