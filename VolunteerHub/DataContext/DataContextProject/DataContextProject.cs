using System.Collections.Generic;
using VolunteerHub.Models;

namespace VolunteerHub.DataContext.DataContextProject
{
    public class DataContextProject : IDataContextProject
    {
        public List<Project> project { get; set; }

        public DataContextProject()
        {
            project = new List<Project>(new Project { Date = DateTime.Now, Description = "taking the sick people", Id = 15, Name = "Ambulance", Status = "Open", Volunteers = new List<Volunteer>  });
        }
    }
}
