using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameApi.Models;
//Any error fixed with Linq
using System.Linq;

namespace GameApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CardigansController : ControllerBase
  {
    private readonly GameApiContext _db;
    public CardigansController(GameApiContext db)
    {
      _db = db;
    }

    // GET api/cardigans
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cardigan>>> Get()
    {
      return await _db.Cardigans.ToListAsync();
    }

    // POST api/cardigans
    [HttpPost]
    public async Task<ActionResult<Cardigan>> Post(Cardigan cardigan)
    {
      _db.Cardigans.Add(cardigan);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetCardigan), new { id = cardigan.CardiganId }, cardigan);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Cardigan>> GetCardigan(int id)
    {
      var cardigan = await _db.Cardigans.FindAsync(id);

      if (cardigan == null)
      {
        return NotFound();
      }

      return cardigan;
    }

    // PUT: api/Cardigans/{id}
    [HttpPut("{id}")]

    public async Task<IActionResult> Put(int id, Cardigan cardigan)
    {
      if (id != cardigan.CardiganId)
      {
        return BadRequest();
      }

      _db.Entry(cardigan).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CardiganExists(id))
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

    private bool CardiganExists(int id)
    {
      return _db.Cardigans.Any(e => e.CardiganId == id);
    }

    // DELETE: api/Cardigans/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCardigan(int id)
    {
      var cardigan = await _db.Cardigans.FindAsync(id);
      if (cardigan == null)
      {
        return NotFound();
      }

      _db.Cardigans.Remove(cardigan);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}