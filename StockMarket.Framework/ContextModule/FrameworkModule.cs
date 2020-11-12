using Autofac;
using StockMarket.Framework.Files;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Framework.ContextModule
{
    public class FrameworkModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FrameworkModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrameworkContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<StockMarketUnitOfWork>().As<IStockMarketUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StockMarketRepository>().As<IStockMarketRepository>()
               .InstancePerLifetimeScope();

            builder.RegisterType<StockMarketService>().As<IStockMarketService>()
                .InstancePerLifetimeScope();



            base.Load(builder);
        }
    }
}
