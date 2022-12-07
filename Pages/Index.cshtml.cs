using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Pages
{
    public class IndexModel : PageModel
    {
        ApplicationContext context;
        public List<Product> Products { get; private set; } = new();
        //public List<User> Users { get; private set; } = new();
        public IndexModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {
            //Users = context.Users.AsNoTracking().ToList();
            Products = context.Products.AsNoTracking().ToList();
        }
        //public List<Product> GetProducts()
        //{
        //    return context.Products.AsNoTracking().ToList();
        //}


        public async Task<IActionResult> OnPostDeleteAsync(Guid id)
        {
            var product = await context.Products.FindAsync(id);

            if (product != null)
            {
                context.Products.Remove(product);
                await context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        //public async Task<IActionResult> OnPostDeleteAsync(int id)
        //{
        //    var user = await context.Users.FindAsync(id);

        //    if (user != null)
        //    {
        //        context.Users.Remove(user);
        //        await context.SaveChangesAsync();
        //    }

        //    return RedirectToPage();
        //}
    }
}