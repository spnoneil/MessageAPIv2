using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Message.Models;
using System.Linq;

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
  }
}