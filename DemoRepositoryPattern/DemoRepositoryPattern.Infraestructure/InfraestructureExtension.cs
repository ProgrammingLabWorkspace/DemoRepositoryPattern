using DemoRepositoryPattern.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DemoRepositoryPattern.Infraestructure
{
    public static class InfraestructureExtension
    {
        public static void AddInfra(this IServiceCollection services)
        {
            // Uma instância para cada vez que é solicitado uma instância de ProductRepository
            services.AddTransient<ProductRepository>();
        }
    }
}
