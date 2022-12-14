using labBD.Models.Entities;
using labBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
       
        public SelectList MealSL { get; set; }

        public void MealDropDownList(object value = null)
        {
            var query = context.Meals.OrderBy(x => x.Name);

            MealSL = new SelectList(query.AsNoTracking(),
                        "Id", "Name", value);
        }

        public SelectList UserSL { get; set; }

        public void UserDropDownList(object value = null)
        {
            var query = context.Users.OrderBy(x => x.Name);

            UserSL = new SelectList(query.AsNoTracking(),
                        "Id", "Name", value);
        }
        public void OnGet()
        {
            MealDropDownList();
            UserDropDownList();
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
