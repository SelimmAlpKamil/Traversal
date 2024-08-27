using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using TravelsalCoreAPI.DAL.Model;

namespace TravelsalCoreAPI.DAL.Entity
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VC77BM0\\SQLEXPRESS; initial catalog=TravelsalCoreAPI; integrated security=true;");
        }

        public DbSet<Visitor> Visitors {  get; set; }  
    }
}
