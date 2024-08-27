using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VC77BM0\\SQLEXPRESS; database=TravelDB2; integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutPartner> AboutPartners { get; set; }
        public DbSet<AboutSub> AboutSubs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<NewLetter> NewLetters { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Announcement> Announcements { get; set; }

        public DbSet<Accound> accounds { get; set; }


        
    }
}
