using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labBD.Models;
using labBD.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace labBD.Pages
{
	public class IndexModel : PageModel
    { 
        ApplicationContext context;
        public List<User> Users { get; private set; } = new();
        public IndexModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {
            Users= context.Users.AsNoTracking().ToList();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var user = await context.Users
                .Include(x => x.FoodIntakes)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (user != null)
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
