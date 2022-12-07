using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>(); 
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
