using Autofac;
using AutoMapper;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace module_10.University.Api.Configuration
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApiProfile>().As<Profile>();
            builder.RegisterType<ExceptionHandlerMiddleware>().SingleInstance();
            builder.RegisterGeneric(typeof(Logger<>)).As(typeof(ILogger<>));
            builder.RegisterType<NLogLoggerFactory>().AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}