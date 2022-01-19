using Microsoft.EntityFrameworkCore;

namespace GameApi.Models
{
  public class GameApiContext : DbContext
  {
    public GameApiContext(DbContextOptions<GameApiContext> options): base(options)
    {

    }
    

    public DbSet<Player> Players {get;set;}
    public DbSet<Tile> Tiles { get; set; }
    public DbSet<TilePosition> World {get;set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Tile>().HasData(
        new Tile {TileId = 1, Name="floor", Transparent=true},
        new Tile {TileId = 2, Name="wall", Transparent=false},
        new Tile {TileId = 3, Name="player", Transparent=false}
      );
      builder.Entity<TilePosition>().HasData(
        new TilePosition {TilePositionId = 1, TileId=2, x=0,y=6,z=0},new TilePosition {TilePositionId = 8, TileId=2, x=1,y=6,z=0},new TilePosition {TilePositionId = 15, TileId=2, x=2,y=6,z=0},new TilePosition {TilePositionId = 22, TileId=2, x=3,y=6,z=0},new TilePosition {TilePositionId = 29, TileId=2, x=4,y=6,z=0},new TilePosition {TilePositionId = 36, TileId=2, x=5,y=6,z=0},new TilePosition {TilePositionId = 43, TileId=2, x=6,y=6,z=0},
        new TilePosition {TilePositionId = 2, TileId=2, x=0,y=5,z=0},new TilePosition {TilePositionId = 9, TileId=1, x=1,y=5,z=0},new TilePosition {TilePositionId = 16, TileId=1, x=2,y=5,z=0},new TilePosition {TilePositionId = 23, TileId=1, x=3,y=5,z=0},new TilePosition {TilePositionId = 30, TileId=1, x=4,y=5,z=0},new TilePosition {TilePositionId = 37, TileId=1, x=5,y=5,z=0},new TilePosition {TilePositionId = 44, TileId=2, x=6,y=5,z=0},
        new TilePosition {TilePositionId = 3, TileId=2, x=0,y=4,z=0},new TilePosition {TilePositionId = 10, TileId=1, x=1,y=4,z=0},new TilePosition {TilePositionId = 17, TileId=1, x=2,y=4,z=0},new TilePosition {TilePositionId = 24, TileId=1, x=3,y=4,z=0},new TilePosition {TilePositionId = 31, TileId=1, x=4,y=4,z=0},new TilePosition {TilePositionId = 38, TileId=1, x=5,y=4,z=0},new TilePosition {TilePositionId = 45, TileId=2, x=6,y=4,z=0},
        new TilePosition {TilePositionId = 4, TileId=2, x=0,y=3,z=0},new TilePosition {TilePositionId = 11, TileId=1, x=1,y=3,z=0},new TilePosition {TilePositionId = 18, TileId=1, x=2,y=3,z=0},new TilePosition {TilePositionId = 25, TileId=1, x=3,y=3,z=0},new TilePosition {TilePositionId = 32, TileId=1, x=4,y=3,z=0},new TilePosition {TilePositionId = 39, TileId=1, x=5,y=3,z=0},new TilePosition {TilePositionId = 46, TileId=2, x=6,y=3,z=0},
        new TilePosition {TilePositionId = 5, TileId=2, x=0,y=2,z=0},new TilePosition {TilePositionId = 12, TileId=1, x=1,y=2,z=0},new TilePosition {TilePositionId = 19, TileId=1, x=2,y=2,z=0},new TilePosition {TilePositionId = 26, TileId=1, x=3,y=2,z=0},new TilePosition {TilePositionId = 33, TileId=1, x=4,y=2,z=0},new TilePosition {TilePositionId = 40, TileId=1, x=5,y=2,z=0},new TilePosition {TilePositionId = 47, TileId=2, x=6,y=2,z=0},
        new TilePosition {TilePositionId = 6, TileId=2, x=0,y=1,z=0},new TilePosition {TilePositionId = 13, TileId=1, x=1,y=1,z=0},new TilePosition {TilePositionId = 20, TileId=1, x=2,y=1,z=0},new TilePosition {TilePositionId = 27, TileId=1, x=3,y=1,z=0},new TilePosition {TilePositionId = 34, TileId=1, x=4,y=1,z=0},new TilePosition {TilePositionId = 41, TileId=1, x=5,y=1,z=0},new TilePosition {TilePositionId = 48, TileId=2, x=6,y=1,z=0},
        new TilePosition {TilePositionId = 7, TileId=2, x=0,y=0,z=0},new TilePosition {TilePositionId = 14, TileId=2, x=1,y=0,z=0},new TilePosition {TilePositionId = 21, TileId=2, x=2,y=0,z=0},new TilePosition {TilePositionId = 28, TileId=2, x=3,y=0,z=0},new TilePosition {TilePositionId = 35, TileId=2, x=4,y=0,z=0},new TilePosition {TilePositionId = 42, TileId=2, x=5,y=0,z=0},new TilePosition {TilePositionId = 49, TileId=2, x=6,y=0,z=0}
      );
    }
     
  }
}