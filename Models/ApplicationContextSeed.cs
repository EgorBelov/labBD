using labBD.Models.Entities;

namespace labBD.Models
{
    
    public class ApplicationContextSeed
    {
        
        public static async Task InitializeDb(ApplicationContext db)        {
            //if (db.Products.Any())
            //    return;

            //var product1 = new Product() { Name = "рис", ProductGroup = "крупа", Type = null, CaloricValue = 45 };
            //var product2 = new Product() { Name = "говядина", ProductGroup = "мясо", Type = "фарш", CaloricValue = 211 };
            //var product3 = new Product() { Name = "курица", ProductGroup = "мясо", Type = "целое", CaloricValue = 165 };
            //var product4 = new Product() { Name = "укроп", ProductGroup = "овощ", Type = null, CaloricValue = 10 };
            //var product5 = new Product() { Name = "огурец", ProductGroup = "овощ", Type = null, CaloricValue = 27 };
            //var product6 = new Product() { Name = "вода", ProductGroup = "вода", Type = null, CaloricValue = 0 };
            //await db.Products.AddRangeAsync(product1, product2, product3, product4, product5, product6);

            //var meal1 = new Meal() { Name = "плов", Category = "горячее", CaloricValue = 150 };
            //var meal2 = new Meal() { Name = "зеленый", Category = "салат", CaloricValue = 246 };
            //var meal3 = new Meal() { Name = "бульон", Category = "суп", CaloricValue = 99 };
            //await db.Meals.AddRangeAsync(meal1, meal2, meal3);

            //var mealscomposition1 = new MealsComposition() { Meal = meal1, Product = product1, ProductWeight = 30 };
            //var mealscomposition2 = new MealsComposition() { Meal = meal1, Product = product2, ProductWeight = 25 };
            //var mealscomposition3 = new MealsComposition() { Meal = meal2, Product = product4, ProductWeight = 100 };
            //var mealscomposition4 = new MealsComposition() { Meal = meal2, Product = product5, ProductWeight = 50 };
            //var mealscomposition5 = new MealsComposition() { Meal = meal3, Product = product3, ProductWeight = 200 };
            //var mealscomposition6 = new MealsComposition() { Meal = meal3, Product = product6, ProductWeight = 400 };
            //await db.MealsCompositions.AddRangeAsync(mealscomposition1, mealscomposition2, mealscomposition3, mealscomposition4, mealscomposition5, mealscomposition6);

            //var user1 = new User() { Name = "Егор", Email = "qwer", Age = 19, Height = 200, Weight = 80, Sex = "М", PhysicalActivity = 1 };
            //var user2 = new User() { Name = "Виталик", Email = "asdf", Age = 5, Height = 123, Weight = 100, Sex = "Ж", PhysicalActivity = 2 };
            //var user3 = new User() { Name = "Лев", Email = "zxcv", Age = 25, Height = 180, Weight = 73, Sex = "М", PhysicalActivity = 3 };
            //await db.Users.AddRangeAsync(user1, user2, user3);

            //var foodintake1 = new FoodIntake() { Date = new DateTime(2020, 11, 12), Meal = meal1, TypeOfFoodIntake = "обед", User = user1 };
            //var foodintake2 = new FoodIntake() { Date = new DateTime(2020, 9, 24), Meal = meal2, TypeOfFoodIntake = "ужин", User = user3 };
            //var foodintake3 = new FoodIntake() { Date = new DateTime(2020, 10, 7), Meal = meal3, TypeOfFoodIntake = "перекус", User = user2 };
            //await db.FoodIntakes.AddRangeAsync(foodintake1, foodintake2, foodintake3);

            //await db.SaveChangesAsync();
        }
    }
}
