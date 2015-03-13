using System.Data.Entity;

namespace CodePound.Demos.SpaWithSignalR.Models
{
    public class MessageContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}