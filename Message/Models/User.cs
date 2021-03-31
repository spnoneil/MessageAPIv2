using System.Collections.Generic;

namespace Message.Models
{

public class User
  { 

    public User()
    {
      this.BMessages = new HashSet<BMessage>();
    }
    public int UserId { get; private set;}
    public string UserName { get; set; }
    public ICollection<BMessage> BMessages { get; set; }

  }
}