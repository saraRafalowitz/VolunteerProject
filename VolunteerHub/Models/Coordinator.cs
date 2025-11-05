using System.Collections.Generic;

namespace VolunteerHub.Models
{
    public class Coordinator
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public List<Project> Projects { get; set; } = new();
    }
}

