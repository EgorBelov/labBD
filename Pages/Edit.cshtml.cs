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
    public class EditModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public User? User { get; set; }
        public EditModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            User = await context.Users.FindAsync(id);
            if (User == null) return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Users.Update(User!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
