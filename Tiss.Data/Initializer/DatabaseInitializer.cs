using System.Collections.Generic;
using System.Data.Entity;
using Tiss.Core;
using Tiss.Data.Context;

namespace Tiss.Data.Initializer
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            Product product1 = new Product()
            {
                Count = 14,
                Price = 14212.42
            };
            Product product2 = new Product()
            {
                Count = 12,
                Price = 1442.31
            };
            Product product3 = new Product()
            {
                Count = 6,
                Price = 15625.23
            };
            Product product4 = new Product()
            {
                Count = 0,
                Price = 11251.78
            };
            Product product5 = new Product()
            {
                Count = 3,
                Price = 124522.22
            };
            Product product6 = new Product()
            {
                Count = 1431,
                Price = 65.23
            };
            Product product7 = new Product()
            {
                Count = 124,
                Price = 7560.50
            };
            Product product8 = new Product()
            {
                Count = 16,
                Price = 1212.123
            };

            context.Products.AddRange(new List<Product>() { product1, product2, product3, product4, product5, product6, product7, product8 });
        }
    }
}
