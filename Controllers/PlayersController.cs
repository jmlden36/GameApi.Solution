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
    
    
    [HttpGet("prox")]
    public async Task<ActionResult<IEnumerable<Player>>> GetProxPlayers(int x, int y, int z, int range)
    {
      var query = _db.Players.AsQueryable();
      query =  query.Where(p=> p.z==z);
      query = query.Where(p=>p.x >= x-range&&p.x<=x+range);
      query = query.Where(p=>p.y >= y-range&&p.y<=y+range);
      return await query.ToListAsync();
    }
    
    [HttpGet("con/{pId}")]
    public async Task<ActionResult<Player>> moveRequest(int pId, bool n, bool s, bool e, bool w)
    {
      int[] dest = getDestination(pId, n,s,e,w);
      
      
      if(CzechTransparancy(dest[0],dest[1],dest[2]))
      {
        Player target = await _db.Players.FindAsync(pId);
        target.y = dest[1];
        target.x = dest[0];
        target.z = dest[2];
        _db.Entry(target).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("GET");
      }
      return RedirectToAction("GET");
    }
    [HttpGet("map")]
    public async Task<ActionResult<IEnumerable<TilePosition>>> getMap()
    {
      return await _db.World
        .Include(w=>w.Tile)
        .OrderBy(w=>w.TilePositionId)
        .ToListAsync();
    }
    
    //POST api/players
    
    [HttpPost]
    public async Task<ActionResult<Player>> Post(Player input)
    {
      // Player objectInput = JsonSerializer.Deserialize<Player>(input);
      
      _db.Players.Add(input);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new {id=input.PlayerId}, input);
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

    //Function Zone
    
    private bool PlayerExists(int id)
    {
      return _db.Players.Any(e => e.PlayerId == id);
    }

    
    public bool CzechTransparancy(int x, int y, int z)
    {
      return _db.World
        .Include(w=>w.Tile)
        .FirstOrDefault(w=>w.x==x&&w.y==y&&w.z==z).Tile.Transparent;
    }
    
    public int[] getDestination(int PlayerId, bool n, bool s,bool e,bool w)
    {
      Player target = _db.Players.FirstOrDefault(x=>x.PlayerId == PlayerId);
      int[] output = {target.x,target.y,target.z};

      if(n)
      {
        output[1]-=1;
      }
      if(s)
      {
        output[1]+=1;
      }
      if(e)
      {
        output[0]+=1;
      }
      if(w)
      {
        output[0]-=1;
      }
      return output;
    }
  }
}