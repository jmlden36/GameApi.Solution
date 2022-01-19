namespace GameApi.Models
{
  public class Player
  {
    public int PlayerId {get;set;}
    public string Name {get;set;}
    public int x {get;set;}
    public int y {get;set;}
    public int z {get;set;}
    
    //make a check move function after you make a map you need

    //check function 
      //input will be player id (grab player from database wityh this id and get x,y and z)
      //input will also have n(t/f), s(t/f), e(t/f), w(t/f)
      //north = y+1
      //sourth = y-1
      //east = x+1
      //weast = x-1
      //return (destingation[z][x][y].transparent)
    

    //Move function
      //if check is true set position to destination
  }

}