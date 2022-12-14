using labBD.Models.Entities;
using labBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace labBD.Pages.MealsCompositions
{
    public class IndexModel : PageModel
    {
        ApplicationContext context;
        public List<MealsComposition> MealsComposotions { get; private set; } = new();
        public IndexModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {
            MealsComposotions = context.MealsCompositions
                .Include(x => x.Meal)
                .Include(x => x.Product)
                .AsNoTracking()
                .ToList();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var mealscompositions = await context.MealsCompositions.FindAsync(id);

            if (mealscompositions != null)
            {
                context.MealsCompositions.Remove(mealscompositions);
                await context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
