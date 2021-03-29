using Microsoft.EntityFrameworkCore;
namespace Message.Models
{
  public class MessageContext : DbContext
  {
    public MessageContext(DbContextOptions<MessageContext> options)
      : base(options)
    {
    }

    public DbSet<BMessage> BMessages { get; set; }
  }
}