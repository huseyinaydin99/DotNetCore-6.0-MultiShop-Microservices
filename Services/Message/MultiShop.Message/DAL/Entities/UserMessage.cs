using MultiShop.Message.DAL.Entities.Concretes;

namespace MultiShop.Message.DAL.Entities;

public class UserMessage : Entity<int>
{
    public string SenderId { get; set; }
    public string ReceiverId { get; set; }
    public string Subject { get; set; }
    public string MessageDetail { get; set; }
    public bool IsRead { get; set; }
    public DateTime MessageDate { get; set; }
}