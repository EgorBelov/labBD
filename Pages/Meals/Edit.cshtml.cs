using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labBD.Models;
using labBD.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace labBD.Pages.Meals
{
    [IgnoreAntiforgeryToken]
    public class EditModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Meal? Meal { get; set; }
        public EditModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            Meal = await context.Meals.FindAsync(id);
            if (Meal == null) return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Meals.Update(Meal!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
