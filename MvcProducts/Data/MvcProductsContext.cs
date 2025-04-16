using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcProducts.Models;

namespace MvcProducts.Data
{
    public class MvcProductsContext : DbContext
    {
        public MvcProductsContext (DbContextOptions<MvcProductsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcProducts.Models.Product> Product { get; set; } = default!;

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Seed data here
        //    modelBuilder.Entity<Product>().HasData(
        //        new Product { Id = 1, Title = "Piens", Description="Limbažu", Price = 3.99},
        //        new Product { Id = 2, Title = "Maize", Description = "Hanzas maiznīca", Price = 1.99 },
        //        new Product { Id = 3, Title = "Cepumi", Description = "Austiņas", Price = 3.99 },
        //        new Product { Id = 4, Title = "Krūze", Description = "Caurspīdīga", Price = 4.99 }
        //    );
        //}
    }
}
