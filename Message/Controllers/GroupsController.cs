using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Message.Models;
using System.Linq;
using System;


namespace Message.Controllers
{
  [Route("api/Groups")]
  [ApiController]

  public class GroupsController : ControllerBase
  {
    private readonly MessageContext _db;
    public GroupsController(MessageContext db)
    {
      _db = db;
    }

    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<Group>>> Get(string name)
    {
      var query = _db.Groups.Include(entry => entry.BMessages).AsQueryable();

      if (name != null)
      {
        query = query.Where(e => e.GroupName == name);
      }

      return await query.ToListAsync();
    }
    //GET: api/Groups/1
    [HttpGet("{name}")]
    public async Task<ActionResult<Group>> GetGroup(string name)
    {
      var thisId = _db.Groups.FirstOrDefault(entry => entry.GroupName == name).GroupId;      
      var Group = await _db.Groups.FindAsync(thisId);

      if (Group == null)
      {
        return NotFound();
      }

      return Group;
    }
    // POST api/Groups
    [HttpPost]
    public async Task<ActionResult<Group>> Post(Group group)
    {
      if ((_db.Groups.FirstOrDefault(entry => entry.GroupName == group.GroupName)) != null)
      {
        return BadRequest();
      }
      else {
      _db.Groups.Add(group);
      await _db.SaveChangesAsync();
      }
      return CreatedAtAction("Post", new { id = group.GroupId }, group);
    }
  }
}

//     // PUT: api/Groups/1  }
//     [HttpPut("{id}")]
//     public async Task<IActionResult> Put(int id, BGroup Group)
//     {
//       if (id != Group.BGroupId)
//       {
//         return BadRequest();
//       }
//       _db.Entry(Group).State = EntityState.Modified;

//       try
//       {
//         await _db.SaveChangesAsync();
//       }

//       catch (DbUpdateConcurrencyException)
//       {
//         if(!BGroupExists(id))
//         {
//           return NotFound();
//         }
//         else
//         {
//           throw;
//         }
//       }
      
//       return NoContent();
//     }

//     [HttpDelete("{id}")]
//     public async Task<IActionResult> DeleteBGroup(int id)
//     {
//       var Group = await _db.Group.FindAsync(id);
//       if (Group == null)
//       {
//         return NotFound();
//       }

//       _db.Group.Remove(Group);
//       await _db.SaveChangesAsync();

//       return NoContent();
//     }

//     private bool BGroupExists(int id)
//     {
//       return _db.Group.Any(e => e.BGroupId == id);
//     }
//   }
// }
