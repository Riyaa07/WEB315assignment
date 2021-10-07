using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Foodblog.Models;

namespace Food.Pages_Foods
{
    public class IndexModel : PageModel
    {
        private readonly FoodFoodblogContext _context;

        public IndexModel(FoodFoodblogContext context)
        {
            _context = context;
        }

        public IList<Foodie> Foodie { get;set; }

        public async Task OnGetAsync()
        {
            Foodie = await _context.Food.ToListAsync();
        }
    }
}
