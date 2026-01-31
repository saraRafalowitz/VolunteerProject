using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolunteerHub.Core.DTO;
using VolunteerHub.Core.Models;

namespace VolunteerHub.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Volunteer,VolunteerDTO>().ReverseMap();
            CreateMap<Coordinator, CoordinatorDTO>().ReverseMap();
            CreateMap<Project, ProjectDTO>().ReverseMap();
        }
        
    }
}
