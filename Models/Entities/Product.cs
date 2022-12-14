namespace labBD.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ProductGroup { get; set; }
        public string? Type { get; set; }
        public int? CaloricValue { get; set; }
        public List<MealsComposition>? MealsCompositions { get; set; } = new();
        
    }

}
