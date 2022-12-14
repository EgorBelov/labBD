using labBD.Models.Entities;
using labBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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

        public SelectList MealSL { get; set; }

        public void MealDropDownList(object value = null)
        {
            var query = context.Meals.OrderBy(x => x.Name);

            MealSL = new SelectList(query.AsNoTracking(),
                        "Id", "Name", value);
        }

        public SelectList ProductSL { get; set; }

        public void ProductDropDownList(object value = null)
        {
            var query = context.Products.OrderBy(x => x.Name);

            ProductSL = new SelectList(query.AsNoTracking(),
                        "Id", "Name", value);
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            MealsComposition = await context.MealsCompositions
                .Include(x => x.Meal)
                .Include(x => x.Product)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (MealsComposition == null) return NotFound();

            MealDropDownList(MealsComposition.MealId);
            ProductDropDownList(MealsComposition.ProductId);
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
