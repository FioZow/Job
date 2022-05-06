using System;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using module_10.University.Api.Configuration;
using module_10.University.Domain.DomainModule;
using module_10.University.Infrastructure.Sql.Configuration;
using module_10.University.IoC;
using module_10.University.Notifications;

namespace module_10.University.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x =>
            {
                x.EnableEndpointRouting = false;
            });
            
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "module_10.University.Api", Version = "v1"});
            });

            var sqlConnectionString = Configuration.GetConnectionString("SqlServerInstance");

            var builder = IoCConfig.GetContainerBuilder(new ApiModule(), new DomainModule(),
                new SqlModule(sqlConnectionString), new NotificationsModule());

            builder.Populate(services);

            return new AutofacServiceProvider(builder.Build());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "module_10.University.Api v1"));

            app.UseHttpsRedirection();

            app.UseMvc();

        }
    }
}