namespace VolunteerHub.Models
{
    public class ProjectPostModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Open";
    }
}
