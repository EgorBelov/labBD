using Microsoft.EntityFrameworkCore;
using labBD.Models.Entities;

namespace labBD.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Meal> Meals => Set<Meal>();
        public DbSet<MealsComposition> MealsCompositions => Set<MealsComposition>();
        public DbSet<User> Users => Set<User>();
        public DbSet<FoodIntake> FoodIntakes => Set<FoodIntake>();
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
