using Microsoft.EntityFrameworkCore;

namespace PlayersApi.Models
{
    public class PlayersContext : DbContext
    
    {
  public PlayersContext(DbContextOptions<PlayersContext> options): base(options){}

  public DbSet<PlayersContext> Player { get; set; }

    }
}