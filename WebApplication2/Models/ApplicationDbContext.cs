using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApplication2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("YourConnectionStringName")
        {
        }

        public DbSet<User> Users { get; set; }

        // Add other DbSet properties for additional entities if needed
    }
}