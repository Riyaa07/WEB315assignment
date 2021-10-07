using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Foodblog.Models;

    public class FoodFoodblogContext : DbContext
    {
        public FoodFoodblogContext (DbContextOptions<FoodFoodblogContext> options)
            : base(options)
        {
        }

        public DbSet<Foodblog.Models.Foodie> Food { get; set; }
    }
