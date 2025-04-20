using LabStore.Domain.Abstracts;
using LabStore.Domain.Repositories;
using LabStore.Infraestructure.Data;
using LabStore.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LabStore.Infraestructure
{
    public static class InfraExtension
    {
        public static IServiceCollection AddInfra(this IServiceCollection services) {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
