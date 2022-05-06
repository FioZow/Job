using Autofac;
using Microsoft.EntityFrameworkCore;
using module_10.University.Infrastructure.Sql.Configuration;
using module_10.University.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace module_10.University.Infrastructure.Sql.Tests
{
    class SqlTestContainer
    {
        public static IContainer GetContainer()
        {
            var containerBuilder = IoCConfig.GetContainerBuilder(new SqlModule("test"));
            containerBuilder.RegisterInstance(new CustomDbContext(new DbContextOptionsBuilder<CustomDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options)).As<CustomDbContext>();
            return containerBuilder.Build();
        }
    }
}
