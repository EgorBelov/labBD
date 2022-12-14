using labBD.Models.Entities;
using labBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace labBD.Pages.MealsCompositions
{
    [IgnoreAntiforgeryToken]
    public class EditModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public MealsComposition? MealsComposition { get; set; }
        public EditModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            MealsComposition = await context.MealsCompositions.FindAsync(id);
            if (MealsComposition == null) return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.MealsCompositions.Update(MealsComposition!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
