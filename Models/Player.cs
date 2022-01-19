namespace GameApi.Models
{
  public class Player
  {
    public int PlayerId {get;set;}
    public string Name {get;set;}
    public Cardigan EquippedCardigan {get;set;}
    public Shoe EquippedShoes {get;set;}
    public Item HandItem {get;set;}
  }

}