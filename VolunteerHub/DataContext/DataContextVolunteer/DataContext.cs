using VolunteerHub.Models;

namespace VolunteerHub.DataContext.DataContextVolunteer
{
    public class DataContext : IDataContext
    {
        public List<Volunteer> volunteer { get; set; }
        public DataContext()
        {
            volunteer = new List<Volunteer>{ new Volunteer { Id=123 , FullName="sara rafalowitz", Email="s0533132366@gmail.com" , Phone="053-3132366" , Status="busy"} ,
            new Volunteer {  Id = 1223, FullName = "efrat mittelman", Email = "e0533132366@gmail.com", Phone = "053-3132344", Status = "can" }  };
        }
    }
}
