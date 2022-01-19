namespace GameApi.Models
{
  public class TilePosition
  {
    public int TilePositionId { get; set; }
    public int TileId { get; set; }
    public virtual Tile Tile { get; set; }
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

  }
}