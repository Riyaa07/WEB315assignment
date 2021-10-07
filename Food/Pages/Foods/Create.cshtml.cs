using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Foodblog.Models;

namespace Food.Pages_Foods
{
    public class CreateModel : PageModel
    {
        private readonly FoodFoodblogContext _context;

        public CreateModel(FoodFoodblogContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Foodie Foodie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Food.Add(Foodie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
