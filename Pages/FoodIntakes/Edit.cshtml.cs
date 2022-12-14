using labBD.Models.Entities;
using labBD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> OnGetAsync(int id)
        {
            FoodIntake = await context.FoodIntakes
               .Include(x => x.Meal)
               .Include(x => x.User)
               .FirstOrDefaultAsync(x => x.Id == id);


            if (FoodIntake == null) return NotFound();

            MealDropDownList(FoodIntake.MealId);
            UserDropDownList(FoodIntake.UserId);
            
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
