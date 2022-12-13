using labBD.Models.Entities;
using labBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace labBD.Pages.FoodIntakes
{
    [IgnoreAntiforgeryToken]
    public class EditModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public FoodIntake? FoodIntake { get; set; }
        public EditModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            FoodIntake = await context.FoodIntakes.FindAsync(id);
            if (FoodIntake == null) return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.FoodIntakes.Update(FoodIntake!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
