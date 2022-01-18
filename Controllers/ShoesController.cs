using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameApi.Models;

namespace GameApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShoesController: ControllerBase
  {
    private readonly GameApiContext _db;
    public ShoesController(GameApiContext db)
    {
      _db=db;
    }

    // GET api/shoes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Shoe>>> Get()
    {
      return await _db.Shoes.ToListAsync();
    }
    //GET api/shoes/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Shoe>> GetShoe(int id)
    {
      var s = await _db.Shoes.FindAsync(id);
      if(s==null)
      {
        return NotFound();
      }
      return s;
    }

    //POST api/shoes
    [HttpPost]
    public async Task<ActionResult<Shoe>> Post(Shoe s)
    {
      _db.Shoes.Add(s);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new {id=s});
    }

    // PUT: api/Shoes/{id}
    [HttpPut("{id}")]

    public async Task<IActionResult> Put(int id, Shoe shoe)
    {
      if (id != shoe.ShoeId)
      {
        return BadRequest();
      }

      _db.Entry(shoe).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ShoeExists(id))
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

    private bool ShoeExists(int id)
    {
      return _db.Shoes.Any(e => e.ShoeId == id);
    }

    // DELETE: api/Shoes/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteShoe(int id)
    {
      var shoe = await _db.Shoes.FindAsync(id);
      if (shoe == null)
      {
        return NotFound();
      }

      _db.Shoes.Remove(shoe);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
  