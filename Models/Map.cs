using System.Collections.Generic;
namespace GameApi.Models
{
  public class Map
  {
    public int MapId { get; set; }
    public int Name { get; set; }

    public List<Tile> oneDTest {get;set;}
  }
}