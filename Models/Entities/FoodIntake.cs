namespace labBD.Models.Entities
{
    public class FoodIntake
    {
        public int Id { get; set; }
        public string? TypeOfFoodIntake { get; set; }
        public DateTime? Date { get; set; }
        public int? MealId { get; set; }      // внешний ключ
        public Meal? Meal { get; set; }    // навигационное свойство
        public int? UserId { get; set; }      // внешний ключ
        public User? User { get; set; }    // навигационное свойство
        
        public FoodIntake() { }
            
    }
}
