using ECommerce.Domain.Entities;
using ECommerce.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ECommerceContext(
                serviceProvider.GetRequiredService<DbContextOptions<ECommerceContext>>()))
            {
                // Look for any board games.
                if (context.Products.Any() && context.Carts.Any())
                {
                    return;
                }

                SeedProducts(context);
                SeedCarts(context);
            }
        }

        private static void SeedProducts(ECommerceContext context)
        {
            context.Products.AddRange(
                new Product("T-Shirt", "Clothes", 50, 14.99M),
                new Product("Sweater", "Clothes", 50, 17.99M),
                new Product("Backpack", "Accessories", 20, 20.99M)
            );
            context.SaveChanges();
        }
        private static void SeedCarts(ECommerceContext context)
        {
            context.Carts.Add(
                new Cart(new List<CartItem>()
                {
                    new CartItem(new Product("T-Shirt", "Clothes", 50, 14.99M))
                })
            );
            context.SaveChanges();
        }
    }
}
