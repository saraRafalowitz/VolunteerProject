using VolunteerHub.Models;
using System.Collections.Generic;

namespace VolunteerHub.DataContext.DataContextCoordinators
{
    public class DataContextCoordinators : IDataContextCoordinators
    {
        public List<Coordinator> Coordinators { get; set; }

        public DataContextCoordinators()
        {
            Coordinators = new List<Coordinator>
            {
                new Coordinator
                {
                    FullName = "moshe",
                    Id = 173,
                    Projects = new List<Project>()
                }
            };
        }
    }
}

