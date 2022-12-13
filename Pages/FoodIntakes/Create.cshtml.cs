using labBD.Models.Entities;
using labBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace labBD.Pages.FoodIntakes
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public FoodIntake FoodIntake { get; set; } = new();
        public CreateModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            context.FoodIntakes.Add(FoodIntake);
            //context.FoodIntakes.Add(Person);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}
