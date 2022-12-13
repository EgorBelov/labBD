using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labBD.Models;
using labBD.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace labBD.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public User User { get; set; } = new();
        public CreateModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            context.Users.Add(User);
            //context.FoodIntakes.Add(Person);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}
