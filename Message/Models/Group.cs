using System.Collections.Generic;

namespace Message.Models
{

public class Group
  { 

    public Group()
    {
      this.BMessages = new HashSet<BMessage>();
    }
    public int GroupId { get; set; }
    public string GroupName { get; set; }
    public ICollection<BMessage> BMessages { get; set; }

  }
}