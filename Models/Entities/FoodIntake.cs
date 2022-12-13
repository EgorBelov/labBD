namespace labBD.Models.Entities
{
    public class FoodIntake
    {
        public Guid Id { get; set; }
        public string? TypeOfFoodIntake { get; set; }
        public DateTime? Date { get; set; }
        public Guid? MealId { get; set; }      // внешний ключ
        public Meal? Meal { get; set; }    // навигационное свойство
        public Guid? UserlId { get; set; }      // внешний ключ
        public User? User { get; set; }    // навигационное свойство
        
        public FoodIntake() { }
            
    }
}
