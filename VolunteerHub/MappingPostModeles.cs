using AutoMapper;
using VolunteerHub.Core.Models;
using VolunteerHub.Models;

namespace VolunteerHub
{
    public class MappingPostModeles:Profile
    {
        public MappingPostModeles()
        {
            CreateMap<VolunteerPostModel, Volunteer>();
            CreateMap<CoordinatorPostModel, Coordinator>();
            CreateMap<ProjectPostModel, Project>();
        }
    }
}
