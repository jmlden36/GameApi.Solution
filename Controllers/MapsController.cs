// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using GameApi.Models;
// using System.Text.Json;
// using Microsoft.AspNetCore.Cors;

// namespace GameApi.Controllers
// {
//   [Route("api/[controller")]
//   [ApiController]
//   public class MapsController: ControllerBase
//   {
//     private readonly GameApiContext _db;
//     public MapsController(GameApiContext db)
//     {
//       _db = db;
//     }

//     [EnableCors("outside")]
//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<Map>>> Get()
//     {
//       return await _db.Maps.ToListAsync();
//     }

//     [EnableCors("outside")]
//     [HttpPost]
//     public async Task<ActionResult<Map>> Post(string x)
//     {
//       Map s = JsonSerializer.Deserialize<Map>(x);
//       _db.Maps.Add(s);
//       await _db.SaveChangesAsync();

//       return CreatedAtAction("Post", new {id=s});
//     }
//   }
// }