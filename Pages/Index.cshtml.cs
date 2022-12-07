﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;
using WebApplication6.Models.Entities;

namespace WebApplication6.Pages
{
    public class IndexModel : PageModel
    {
        ApplicationContext context;
        public List<Product> Products { get; private set; } = new();
        public IndexModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {
            Products = context.Products.AsNoTracking().ToList();
        }
      
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
    }
}