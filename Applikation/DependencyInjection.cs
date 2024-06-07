using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Application.CQRS;

namespace Application
{
    public static class DependencyInjection 
    {

        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddApplicationLayerMediatR();

            return services;
        }


        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
