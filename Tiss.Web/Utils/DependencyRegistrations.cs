using Ninject.Modules;
using Tiss.Data.Context;
using Tiss.Data.Contracts;
using Tiss.Data.Repositories;

namespace Tiss.Web.Utils
{
    public class DependencyRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductRepository>().To<ProductRepository>()
                .WithConstructorArgument("databaseContext", new DatabaseContext());
        }
    }
}