using System;
using System.Collections.Generic;
using VolunteerHub.Core.Models;

namespace VolunteerHub.Core.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Open";
        public List<Volunteer> Volunteers { get; set; } = new();
    }
}

