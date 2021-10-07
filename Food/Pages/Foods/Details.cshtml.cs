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
    public class DetailsModel : PageModel
    {
        private readonly FoodFoodblogContext _context;

        public DetailsModel(FoodFoodblogContext context)
        {
            _context = context;
        }

        public Foodie Foodie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Foodie = await _context.Food.FirstOrDefaultAsync(m => m.ID == id);

            if (Foodie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
