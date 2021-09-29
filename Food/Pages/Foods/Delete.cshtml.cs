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
    public class DeleteModel : PageModel
    {
        private readonly FoodContext _context;

        public DeleteModel(FoodContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Foodie = await _context.Food.FindAsync(id);

            if (Foodie != null)
            {
                _context.Food.Remove(Foodie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
