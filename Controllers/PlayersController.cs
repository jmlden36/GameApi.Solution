using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameApi.Models;
using System.Text.Json;

namespace GameApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PlayersController: ControllerBase
  {
    private readonly GameApiContext _db;
    public PlayersController(GameApiContext db)
    {
      _db=db;
    }

    // GET api/players
    [HttpGet]
    // public async string Get()
    // {
    //   var x = await _db.Players.ToListAsync();
    //   string test = JsonSerializer.Serialize(x);
    //   return test;
    // }
    public async Task<ActionResult<IEnumerable<Player>>> Get()
    {
      return await _db.Players.ToListAsync();
    }
    
    //GET api/players/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Player>> GetPlayer(int id)
    {
      var s = await _db.Players.FindAsync(id);
      if(s==null)
      {
        return NotFound();
      }
      return s;
    }

    //POST api/players
    [HttpPost]
    public async Task<ActionResult<Player>> Post(string x)
    {
      Player s = JsonSerializer.Deserialize<Player>(x);
      // Player s = new Player() {Name=x.Name,EquippedCardigan=(Cardigan) x.EquippedCardigan, EquippedShoes=(Shoe) x.EquippedShoes, }
      _db.Players.Add(s);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new {id=s});
    }

    // PUT: api/Players/{id}
    [HttpPut("{id}")]

    public async Task<IActionResult> Put(int id, Player player)
    {
      if (id != player.PlayerId)
      {
        return BadRequest();
      }

      _db.Entry(player).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!PlayerExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool PlayerExists(int id)
    {
      return _db.Players.Any(e => e.PlayerId == id);
    }

    // DELETE: api/Players/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePlayer(int id)
    {
      var player = await _db.Players.FindAsync(id);
      if (player == null)
      {
        return NotFound();
      }

      _db.Players.Remove(player);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}