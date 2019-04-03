using Microsoft.EntityFrameworkCore;

namespace TeamsApi.Models
{
  public class TeamsContext : DbContext
  {
    public TeamsContext(DbContextOptions<TeamsContext> options): base(options){}

    public DbSet<TeamsContext> Team { get; set; }

  }
}