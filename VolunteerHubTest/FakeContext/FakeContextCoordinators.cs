using System;
using System.Collections.Generic;
using VolunteerHub.DataContext.DataContextCoordinators;
using VolunteerHub.Models;

namespace VolunteerHubTest.FakeContext
{
    public class FakeContextCoordinators : IDataContextCoordinators
    {
        public List<Coordinator> Coordinators { get; set; }

        public FakeContextCoordinators()
        {
            Coordinators = new List<Coordinator>
            {
                new Coordinator
                {
                    FullName = "chaim",
                    Id = 121,
                    Projects = new List<Project>()
                }
            };
        }
    }
}

