using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebApplication6.Models.Entities
{
    public class MealsComposition
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int CaloricValue { get; set; }
        public Guid ProductId { get; set; }      // внешний ключ
        public Product? Product { get; set; }    // навигационное свойство

        public Guid MealId { get; set; }      // внешний ключ
        public Meal? Meal { get; set; }    // навигационное свойство
    }
}
