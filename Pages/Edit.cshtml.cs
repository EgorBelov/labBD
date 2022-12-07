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

        public EditModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Product = await context.Products.FindAsync(id);

            if (Product == null) return NotFound();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Products.Update(Product!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
