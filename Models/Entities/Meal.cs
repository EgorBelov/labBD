namespace labBD.Models.Entities
{
    public class Meal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int? CaloricValue { get; set; }
        public List<MealsComposition>? MealsCompositions { get; set; } = new();
        public List<FoodIntake>? FoodIntakes { get; set; } = new();
    }
}
