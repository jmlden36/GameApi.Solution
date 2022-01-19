using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameApi.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Cors;
using System;

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
    public async Task<ActionResult<IEnumerable<Player>>> Get()
    {
      return await _db.Players.ToListAsync();
    }
    [EnableCors("outside")]

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
    
    [EnableCors("outside")]
    [HttpGet("prox")]
    public async Task<ActionResult<IEnumerable<Player>>> GetProxPlayers(int x, int y, int z, int range)
    {
      var query = _db.Players.AsQueryable();
      query =  query.Where(p=> p.z==z);
      query = query.Where(p=>p.x >= x-range&&p.x<=x+range);
      query = query.Where(p=>p.y >= y-range&&p.y<=y+range);
      return await query.ToListAsync();
    }
    [EnableCors("outside")]
    [HttpGet("con")]
    public async Task<ActionResult<Player>> moveRequest(int pId, bool n, bool s, bool e, bool w)
    {
      
      return NoContent();
    }
    [HttpGet("map")]
    public async Task<ActionResult<IEnumerable<TilePosition>>> getMap()
    {
      return await _db.World
        .Include(w=>w.Tile)
        .OrderBy(w=>w.TilePositionId)
        .ToListAsync();
    }
    [EnableCors("outside")]
    [HttpGet("map/t")]
    public void getTransparency(int x, int y, int z)
    {
      if(CzechTransparancy(x,y,z))
      {
        Console.WriteLine("good to go");  
      }else{
        Console.WriteLine("Not good to go");
      }
    }
    //POST api/players
    [EnableCors("outside")]
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
    [EnableCors("outside")]
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

      return RedirectToAction("GetPlayer", new {id = id});
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

    //ROUTE GRAVEYARD

    // [HttpPatch("{id}")]

    // public async Task<IActionResult> Patch(int id, Player player)
    // {
    //   if (id != player.PlayerId)
    //   {
    //     return BadRequest();
    //   }

    //   _db.Entry(player).State = EntityState.Modified;

    //   try
    //   {
    //     await _db.SaveChangesAsync();
    //   }
    //   catch (DbUpdateConcurrencyException)
    //   {
    //     if (!PlayerExists(id))
    //     {
    //       return NotFound();
    //     }
    //     else
    //     {
    //       throw;
    //     }
    //   }

    //   return NoContent();
    // }


    //Function Zone
    [EnableCors("outside")]
    private bool PlayerExists(int id)
    {
      return _db.Players.Any(e => e.PlayerId == id);
    }

    [EnableCors("outside")]
    public bool CzechTransparancy(int x, int y, int z)
    {
      return _db.World
        .Include(w=>w.Tile)
        .FirstOrDefault(w=>w.x==x&&w.y==y&&w.z==z).Tile.Transparent;
    }
  }
}