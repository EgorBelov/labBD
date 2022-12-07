namespace WebApplication6.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProductGroup { get; set; }
        public string Type { get; set; }
        public int CaloricValue { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; } // имя пользователя
        public int Age { get; set; } // возраст пользователя
    }
}
