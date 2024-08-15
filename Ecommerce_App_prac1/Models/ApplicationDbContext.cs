using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_App_prac1.Models
{

public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>()
        //        .Property(p => p.Price)
        //        .HasColumnType("decimal(18,2)"); // Specify column type with precision and scale
        //}

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

    }

}
