using Microsoft.EntityFrameworkCore;

namespace SignalRApi.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options) 
        {

        }

        DbSet<Visitor> Visitors { get; set; }
        

    }
}
