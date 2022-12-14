using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace labBD.Models.Entities
{
    public class MealsComposition
    {
        public int Id { get; set; }
        public int? ProductWeight { get; set; }
       
        public int? ProductId { get; set; }      // внешний ключ
        public Product? Product { get; set; }    // навигационное свойство

        public int? MealId { get; set; }      // внешний ключ
        public Meal? Meal { get; set; }    // навигационное свойство
    }
}
