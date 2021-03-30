using Microsoft.EntityFrameworkCore;
using System;
namespace Message.Models
{
  public class MessageContext : DbContext
  {
    public MessageContext(DbContextOptions<MessageContext> options)
      : base(options)
    {
    }
 
    public DbSet<BMessage> BMessages { get; set; }
    public DbSet<Group> Groups { get; set; }
  }
}