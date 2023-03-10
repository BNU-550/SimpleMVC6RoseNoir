using SimpleMVC6RoseNoir.Models;

namespace SimpleMVC6RoseNoir.Data
{
    public static class DbIntialiser
    {
        public static void SeedData(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            AddProducts(context);
            AddVariations(context);
        }

        private static void AddProducts(ApplicationDbContext context)
        {
            if (context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product()
                {
                     Name = "Product 1",
                     Description = "Product 1 descriptiom ",
                     Price = 21.00m,
                },
                 new Product()
                {
                     Name = "Product 2",
                     Description = "Product 2 descriptiom ",
                     Price = 22.00m,
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
        private static void AddVariations(ApplicationDbContext context)
        {
            if (context.Variations.Any())
            {
                return;
            }

            var variations = new Variation[]
            {
                new Variation()
                {
                    ProductId = 1,
                    Name = "Yellow Product 1",
                    Description = "Yellow Product 1 Description",
                    Colour ="Yellow",
                    Price = 0
                },
                new Variation()
                {
                    ProductId = 1,
                    Name = "Blue Product 1",
                    Description = "Blue Product 1 Description",
                    Colour ="Blue",
                    Price = 0
                },
               new Variation()
                {
                    ProductId = 2,
                    Name = "Yellow Product 2",
                    Description = "Yellow Product 2 Description",
                    Colour ="Yellow",
                    Price = 0
                },
                new Variation()
                {
                    ProductId = 2,
                    Name = "Blue Product 2",
                    Description = "Blue Product 2 Description",
                    Colour ="Blue",
                    Price = 0
                }
            };

            foreach (var variation in variations)
            {
                context.Variations.Add(variation);
            }

            context.SaveChanges();
        }
    }
}
