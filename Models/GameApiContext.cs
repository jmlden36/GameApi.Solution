using Microsoft.EntityFrameworkCore;

namespace GameApi.Models
{
  public class GameApiContext : DbContext
  {
    public GameApiContext(DbContextOptions<GameApiContext> options): base(options)
    {

    }

    public DbSet<Player> Players {get;set;}


    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //   builder.Entity<Player>()
    //     .HasData(
    //       new Player { PlayerId = 6, Name = "Greg", EquippedCardigan = new Cardigan(){CardiganId = 1, Name = "Blue Cardigan", Description = "Blue Cardigan that does stuff" }, EquippedShoes = new Shoe() {ShoeId = 1, Name = "Inside Shoes", Description = "Shoes to walk on carpet"}, HandItem = new Item() {ItemId = 1, Name = "Cool Item", Description = "Item Description words"}});
    // }
  }
}