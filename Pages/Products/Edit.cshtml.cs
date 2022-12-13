using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using labBD.Models;
using labBD.Models.Entities;

namespace labBD.Pages.Products
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
        public async Task<IActionResult> OnGetAsync(Guid id)
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
