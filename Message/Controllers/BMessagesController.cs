using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Message.Models;
using System.Linq;
using System;


namespace Message.Controllers
{
  [Route("api/Messages")]
  [ApiController]

  public class BMessagesController : ControllerBase
  {
    private readonly MessageContext _db;
    public BMessagesController(MessageContext db)
    {
      _db = db;
    }
    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<BMessage>>> Get(string message)
    {
      var query = _db.BMessages.AsQueryable();

      if (message != null)
      {
        query = query.Where(e => e.Message == message);
      }

      return await query.ToListAsync();
    }
    //GET: api/Messages/1
    [HttpGet("{id}")]
    public async Task<ActionResult<BMessage>> GetMessage(int id)
    {
      var message = await _db.BMessages.FindAsync(id);

      if (message == null)
      {
        return NotFound();
      }

      return message;
    }
    // POST api/Messages
    [HttpPost]
    public async Task<ActionResult<BMessage>> Post(BMessage message, string name)
    {
      var thisGroup = _db.Groups.Include(entry => entry.BMessages).FirstOrDefault(entry => entry.GroupName == name);
      
      if (thisGroup != null)
      {
        message.Posted = DateTime.Now;
        message.GroupId = thisGroup.GroupId;
        // Console.WriteLine(string.Join(" ", thisGroup.BMessages.Count));
        thisGroup.BMessages.Add(message);
        // _db.Groups.Attach(thisGroup);
        // _db.Entry(thisGroup).Collection("BMessages").IsModified = true;
        // Console.WriteLine(string.Join(" ", thisGroup.BMessages.Count));
        _db.Groups.Update(thisGroup);
        // _db.SaveChanges();
        // _db.Entry(thisGroup).State = EntityState.Modified;
        // await _db.Groups.AddAsync(thisGroup);        
        await _db.SaveChangesAsync();
      }
      else
      {
        return BadRequest();
      }
      // return CreatedAtAction("Post", new { id = message.BMessageId }, message);
      return CreatedAtAction("Post", new { id = message.GroupId}, thisGroup);
    }

    // PUT: api/Messages/1  }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, BMessage message)
    {
      if (id != message.BMessageId)
      {
        return BadRequest();
      }
      _db.Entry(message).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }

      catch (DbUpdateConcurrencyException)
      {
        if(!BMessageExists(id))
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

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBMessage(int id)
    {
      var message = await _db.BMessages.FindAsync(id);
      if (message == null)
      {
        return NotFound();
      }

      _db.BMessages.Remove(message);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool BMessageExists(int id)
    {
      return _db.BMessages.Any(e => e.BMessageId == id);
    }
  }
}