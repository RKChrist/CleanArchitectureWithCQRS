using Microsoft.Extensions.DependencyInjection;

namespace Application.CQRS
{
    public static class MediatRInjection
    {
        public static IServiceCollection AddApplicationLayerMediatR(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
                //cfg.AddBehavior<>
            });
            return services;
        }
    }
}
