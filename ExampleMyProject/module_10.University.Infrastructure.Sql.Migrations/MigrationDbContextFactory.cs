using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace module_10.University.Infrastructure.Sql.Migrations
{
    public class MigrationDbContextFactory : IDesignTimeDbContextFactory<CustomDbContext>
    {
        public CustomDbContext CreateDbContext(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Local";
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json", true, false)
                .AddJsonFile($"appsettings.{environment}.json", true, false);
            var configuration = configurationBuilder.Build();
            return new CustomDbContext(new DbContextOptionsBuilder<CustomDbContext>()
                .UseSqlServer(configuration.GetConnectionString("SqlServerInstance"),
                    e => e.MigrationsAssembly("module_10.University.Infrastructure.Sql.Migrations")).Options);
        }
    }
}