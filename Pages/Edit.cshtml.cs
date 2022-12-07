using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication6.Models;

namespace WebApplication6.Pages
{
    [IgnoreAntiforgeryToken]
    public class EditModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Product? Product { get; set; }
        //public User? Person { get; set; }
        public EditModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            Product = await context.Products.FindAsync(id);
            if (Product == null) return NotFound();
            
            //Person = await context.Users.FindAsync(id);
            //if (Person == null) return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Products.Update(Product!);
            //context.Users.Update(Person!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
