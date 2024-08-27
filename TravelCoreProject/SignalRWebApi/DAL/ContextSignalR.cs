using Microsoft.EntityFrameworkCore;

namespace SignalRWebApi.DAL
{
    public class ContextSignalR :DbContext
    {
        public ContextSignalR(DbContextOptions<ContextSignalR> options) : base(options)
        {

        }

        DbSet<Visitor> Visitors { get; set; }
    }
}
