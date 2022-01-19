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
    public DbSet<Player> Players {get;set;}


    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Player>()
        .HasData(
          new Player { PlayerId = 5, Name = "Greg", EquippedCardigan = {CardiganId = 1, Name = "Blue Cardigan", Description = "Blue Cardigan that does stuff" }, EquippedShoes = {ShoeId = 1, Name = "Inside Shoes", Description = "Shoes to walk on carpet"}, HandItem = {ItemId = 1, Name = "Cool Item", Description = "Item Description words"}}
        );
    }
  }
}