using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labBD.Models;
using labBD.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace labBD.Pages.Meals
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Meal Meal { get; set; } = new();
        public CreateModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            context.Meals.Add(Meal);
            //context.FoodIntakes.Add(Person);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}
