using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labBD.Models;
using labBD.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace labBD.Pages.Meals
{
	public class IndexModel : PageModel
    {
        ApplicationContext context;
        public List<Meal> Meals { get; private set; } = new();
        public IndexModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {
            Meals = context.Meals
                .Include(x => x.MealsCompositions)
                .AsNoTracking()
                .ToList();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var meal = await context.Meals
                .Include(x => x.MealsCompositions)
                .Include(x => x.FoodIntakes)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (meal != null)
            {
                context.Meals.Remove(meal);
                await context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
