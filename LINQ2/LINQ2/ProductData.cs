namespace LINQ2
{
    public class ProductList
    {
        public static readonly List<Product> Products = new List<Product>
        {
                new Product()
            {
                Id = 1,
                Name = "Vesi",
                Category = "Jook",
                Price = 5,
                Amount = 100,
            },
                 new Product()
            {
                Id = 2,
                Name = "Kala",
                Category = "Söök",
                Price = 29.99,
                Amount = 100,
           },
                  new Product()
            {
                Id = 3,
                Name = "Auto",
                Category = "Sõiduvahend",
                Price = 100000,
                Amount = 250,
           },
                   new Product()
            {
                Id = 4,
                Name = "Hakkliha",
                Category = "Söök",
                Price = 5,
                Amount = 10,
           },
                    new Product()
            {
                Id = 5,
                Name = "Telefon",
                Category = "Elektroonika",
                Price = 1000,
                Amount = 5,
           },
                     new Product()
            {
                Id = 6,
                Name = "Jalanõud",
                Category = "Riided",
                Price = 15.99,
                Amount = 10000,
           },
                      new Product()
            {
                Id = 7,
                Name = "Leib",
                Category = "Söök",
                Price = 2,
                Amount = 5,
           },
                       new Product()
            {
                Id = 8,
                Name = "Limonaad",
                Category = "Jook",
                Price = 2.89,
                Amount = 1000,
           },
                        new Product()
            {
                Id = 9,
                Name = "Jope",
                Category = "Riided",
                Price = 55.99,
                Amount = 10,
           },
                         new Product()
            {
                Id = 10,
                Name = "Arvuti",
                Category = "Elektroonika",
                Price = 1500,
                Amount = 25,
           }
        };
    }
}
