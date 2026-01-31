using Microsoft.EntityFrameworkCore;
using VolunteerHub.Core.Models;
namespace VolunteerHub.Data;

public class DataContext : DbContext
{
    public DbSet<Volunteer> volunteer { get; set; }
    public DbSet<Project> project { get; set; }
    public DbSet<Coordinator> Coordinator { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;database=Volunteer_db");
    }
}
