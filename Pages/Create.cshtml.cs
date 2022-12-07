using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using labBD .Models;
using labBD.Models.Entities;

namespace labBD.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Product Product { get; set; } = new();
        public CreateModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Products.Add(Product);
            //context.Users.Add(Person);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
        
    }
}
