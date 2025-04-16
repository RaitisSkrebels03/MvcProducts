using Microsoft.EntityFrameworkCore;
using MvcProducts.Data;

namespace MvcProducts.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcProductsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcProductsContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }
                context.Product.AddRange(
                    new Product
                    {
                        Title = "Torte",
                        Description = "Saldā",
                        Price = 8.7
                    },
                    new Product
                    {
                        Title = "Maize",
                        Description = "Rudzu",
                        Price = 1.9
                    },
                    new Product
                    {
                        Title = "Krūžu komplekts",
                        Description = "Krāsa - balta",
                        Price = 19.99
                    },
                    new Product
                    {
                        Title = "Piens",
                        Description = "Limbažu",
                        Price = 0.89
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
