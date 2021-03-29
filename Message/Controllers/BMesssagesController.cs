using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Message.Models;
using System.Linq;
using System;

namespace Message.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class BMessagesController : ControllerBase
  {
    private readonly MessageContext _db;
    public BMessagesController(MessageContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<BMessage>> Get(string message, DateTime posted)
    {
      var query = _db.BMessages.AsQueryable();

      if (message != null)
      {
        query = query.Where(e => e.Message == message);
      }

      if (posted != null)
      {
        query = query.Where(e => e.Posted == posted);
      }

      return query.ToList();
    }
  }
}