using Microsoft.EntityFrameworkCore;

namespace GameApi.Models
{
  public class GameApiContext : DbContext
  {
    public GameApiContext(DbContextOptions<GameApiContext> options): base(options)
    {

    }

    public DbSet<Cardigan> Cardigans { get; set; }
    public DbSet<Shoe> Shoes { get; set; }
    public DbSet<Item> Items { get; set; }
    
  }
}