using Autofac;
using MarketProj.DAL.Queries.ProductAgregate;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace MarketProj.Infrastructures
{
    public class ApplicationModule : Module
    {
        private readonly string _connectionString = string.Empty;

        public ApplicationModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<ProductQuery>()
            //  .As<IProductQuery>()
            //  .InstancePerLifetimeScope();

            builder.Register(x => new ProductQuery(_connectionString))
                .As<IProductQuery>()
                .InstancePerLifetimeScope();

        }


    }
}
