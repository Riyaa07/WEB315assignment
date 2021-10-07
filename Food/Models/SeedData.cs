using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Foodblog.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FoodFoodblogContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FoodFoodblogContext>>()))
            {
                // Look for any movies.
                if (context.Food.Any())
                {
                    return;   // DB has been seeded
                }

                context.Food.AddRange(
                    new Foodie
                    {
                        Name = "Pav bhaji",
                        Ingredients = "Potato, Cabbge & all vegetables",
                        Price = 7.99M
                    },

                    new Foodie
                    {
                        Name = "Aloo paratha",
                        Ingredients = "chpati stuffed with potato, ginger & garlic",
                        Price = 8.99M
                    },

                    new Foodie
                    {
                        Name = "Rasugulla",
                        Ingredients = "Made out of milk with sugar syrup",
                        Price = 9.99M
                    },

                    new Foodie
                    {
                        Name = "Khichdi",
                        Ingredients = "rice , dal , onion , tomato & indian spices",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}