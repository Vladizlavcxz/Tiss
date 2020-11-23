using System.Collections.Generic;
using Tiss.Core;
using Tiss.Data.Contracts;
using Tiss.Data.Context;

namespace Tiss.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public DatabaseContext DatabaseContext { get; private set; }

        public ProductRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return DatabaseContext.Products;
        }

        public void Dispose()
        {
            DatabaseContext.Dispose();
        }
    }
}
