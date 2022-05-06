using Autofac;
using AutoMapper;

namespace module_10.University.IoC
{
    public static class IoCConfig
    {
        public static ContainerBuilder GetContainerBuilder(params Module[] modules)
        {
            var containerBuilder = new ContainerBuilder();
            
            containerBuilder.RegisterType<AutoMapperConfig>();
            
            containerBuilder.Register(context => context.Resolve<AutoMapperConfig>().GetMapper())
                .As<IMapper>().SingleInstance();
            
            foreach (var module in modules)
            {
                containerBuilder.RegisterModule(module);
            }

            return containerBuilder;
        }
    }
}