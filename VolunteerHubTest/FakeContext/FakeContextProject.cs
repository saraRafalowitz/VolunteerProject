//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using VolunteerHub.Data.DataContext.DataContextProject;
//using VolunteerHub.Core.Models;

//namespace VolunteerHubTest.FakeContext
//{
//    public class FakeContextProject : IDataContextProject
//    {
//        public List<Project> project { get; set; }

//        public FakeContextProject()
//        {
//            project = new List<Project>
//            {
//                new Project
//                {
//                    Date = DateTime.Now,
//                    Description = "meals",
//                    Id = 18,
//                    Name = "hospital",
//                    Status = "Open",
//                    Volunteers = new List<Volunteer>
//                    {
//                        new Volunteer
//                        {
//                            Email = "fghjkl",
//                            FullName = "menhnjk",
//                            Id = 2,
//                            Phone = "0589876541",
//                            Status = "busy"
//                        }
//                    }
//                }
//            };
//        }
//    }
//}
