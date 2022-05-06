using Autofac;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace module_10.University.Infrastructure.Sql.Configuration
{
    public class SqlModule : Module
    {
        private readonly string _connectionString;

        public SqlModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();
            builder.Register(x =>
            {
                var option = new DbContextOptionsBuilder<CustomDbContext>();
                option.UseSqlServer(_connectionString);
                return new CustomDbContext(option.Options);
            }).InstancePerLifetimeScope();
            
            builder.RegisterType<SqlProfile>().As<Profile>();
        }
    }
}