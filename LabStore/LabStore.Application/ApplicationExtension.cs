using Microsoft.Extensions.DependencyInjection;

namespace LabStore.Application
{
    public static class ApplicationExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) {
            services.AddMediatR(med =>
            {
                med.RegisterServicesFromAssembly(typeof(ApplicationExtension).Assembly);
            });

            return services;
        }
    }
}
