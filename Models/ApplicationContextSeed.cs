using WebApplication6.Models.Entities;

namespace WebApplication6.Models
{
    
    public class ApplicationContextSeed
    {
        public static async Task InitializeDb(ApplicationContext db)
        {
            if (db.Products.Any())
                return;

            for (int i = 0; i < 100; i++)
            {
                var item = new Product(i);
                await db.Products.AddAsync(item);
            }
            await db.SaveChangesAsync();
        }
    }
}
