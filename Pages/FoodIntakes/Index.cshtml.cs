using labBD.Models.Entities;
using labBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace labBD.Pages.FoodIntakes
{
    public class IndexModel : PageModel
    {
        ApplicationContext context;
        public List<FoodIntake> FoodIntakes { get; private set; } = new();
        public IndexModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {
            FoodIntakes = context.FoodIntakes
                .Include(x => x.Meal)
                .Include(x => x.User)
                .AsNoTracking().ToList();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var foodIntake = await context.FoodIntakes.FindAsync(id);

            if (foodIntake != null)
            {
                context.FoodIntakes.Remove(foodIntake);
                await context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
