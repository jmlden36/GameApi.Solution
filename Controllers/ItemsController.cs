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
  public class ItemsController : ControllerBase
  {
    private readonly GameApiContext _db;
    public ItemsController(GameApiContext db)
    {
      _db = db;
    }

    // GET api/items
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Item>>> Get()
    {
      return await _db.Items.ToListAsync();
    }

    // POST api/items
    [HttpPost]
    public async Task<ActionResult<Item>> Post(Item item)
    {
      _db.Items.Add(item);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetItem), new { id = item.ItemId }, item);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Item>> GetItem(int id)
    {
      var item = await _db.Items.FindAsync(id);

      if (item == null)
      {
        return NotFound();
      }

      return item;
    }

    // PUT: api/Items/{id}
    [HttpPut("{id}")]

    public async Task<IActionResult> Put(int id, Item item)
    {
      if (id != item.ItemId)
      {
        return BadRequest();
      }

      _db.Entry(item).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ItemExists(id))
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

    private bool ItemExists(int id)
    {
      return _db.Items.Any(e => e.ItemId == id);
    }

    // DELETE: api/Items/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteItem(int id)
    {
      var item = await _db.Items.FindAsync(id);
      if (item == null)
      {
        return NotFound();
      }

      _db.Items.Remove(item);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}