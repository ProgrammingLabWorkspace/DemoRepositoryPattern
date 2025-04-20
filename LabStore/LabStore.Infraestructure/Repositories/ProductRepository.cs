using LabStore.Domain.Entities;
using LabStore.Domain.Repositories;
using LabStore.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LabStore.Infraestructure.Repositories
{
    public class ProductRepository(AppDbContext context) : IProductRepository
    {
        public async Task<Product> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);

            return product;
        }
    }
}
