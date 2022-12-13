namespace labBD.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        //public string Password { get; set; }
        public int? Weight { get; set; }
        public int? Height { get; set; }
        public int? Age { get; set; }
        public string? Sex { get; set; }
        public double? PhysicalActivity { get; set; }
        public List<FoodIntake>? FoodIntakes { get; set; } = new();
    }
}
