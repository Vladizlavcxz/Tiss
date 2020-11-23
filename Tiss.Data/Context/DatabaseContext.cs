using System.Data.Entity;
using Tiss.Core;

namespace Tiss.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DatabaseContext()
            : base("TissConnectionString")
        {

        }
    }
}
