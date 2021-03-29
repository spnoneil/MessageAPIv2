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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<BMessage>()
          .HasData(
              new BMessage { BMessageId = 1, Message = "Matilda", Posted = DateTime.Now },
              new BMessage { BMessageId = 2, Message = "Rexie", Posted = DateTime.Now },
              new BMessage { BMessageId = 3, Message = "Matilda", Posted = DateTime.Now },
              new BMessage { BMessageId = 4, Message = "Pip", Posted = DateTime.Now },
              new BMessage { BMessageId = 5, Message = "Bartholomew", Posted = DateTime.Now }
          );
    }

    public DbSet<BMessage> BMessages { get; set; }
  }
}