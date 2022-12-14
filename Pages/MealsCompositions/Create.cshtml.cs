using labBD.Models.Entities;
using labBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace labBD.Pages.MealsCompositions
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public MealsComposition MealsComposition { get; set; } = new();
        public CreateModel(ApplicationContext db)
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


        public void OnGet()
        {
            MealDropDownList();
            ProductDropDownList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            context.MealsCompositions.Add(MealsComposition);
            //context.FoodIntakes.Add(Person);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}
