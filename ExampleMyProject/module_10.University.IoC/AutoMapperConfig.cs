using System.Collections.Generic;
using AutoMapper;
using AutoMapper.EquivalencyExpression;

namespace module_10.University.IoC
{
    public class AutoMapperConfig
    {
        private readonly IEnumerable<Profile> _profiles;

        public AutoMapperConfig(IEnumerable<Profile> profiles)
        {
            _profiles = profiles;
        }

        public IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddCollectionMappers();
                cfg.AddProfiles(_profiles);
            });
            return config.CreateMapper();
        }
    }
}