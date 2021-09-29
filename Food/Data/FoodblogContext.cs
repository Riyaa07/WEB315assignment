using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Foodblog.Models;

    public class FoodblogContext : DbContext
    {
        public FoodblogContext (DbContextOptions<FoodblogContext> options)
            : base(options)
        {
        }

        public DbSet<Foodblog.Models.Foodie> Food { get; set; }
    }
