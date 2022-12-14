using labBD.Models.Entities;
using labBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        public void OnGet()
        {

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
