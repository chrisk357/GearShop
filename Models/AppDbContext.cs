using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Jersey> Jerseys { get; set; }
        public DbSet<Pant> Pants { get; set; }



        public DbSet<Helmet> Helmets { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        /*     
         *     protected override void OnModelCreating(ModelBuilder builder)
                {
                    base.OnModelCreating(builder);
                    builder.Entity<Jersey>();
                    builder.Entity<Pant>();
        }*/





    }
}
