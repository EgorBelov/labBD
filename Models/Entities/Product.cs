namespace WebApplication6.Models.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProductGroup { get; set; }
        public string Type { get; set; }
        public int CaloricValue { get; set; }
        public List<MealsComposition> MealsCompositions { get; set; } = new();
        public Product()
        {

        }
        public Product(int i)
        {
            Name = i.ToString();
            ProductGroup = i.ToString();
            Type = i.ToString();
            CaloricValue = i;
        }
    }

}
