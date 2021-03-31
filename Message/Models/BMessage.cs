using System;

namespace Message.Models
{
  public class BMessage
  {
    public int BMessageId { get; private set; }
    public string Message { get; set; }
    public DateTime Posted { get; set; }
    public int GroupId { get; set; }

  }
}