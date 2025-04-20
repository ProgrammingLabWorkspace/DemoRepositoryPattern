using LabStore.Domain.Abstracts;
using LabStore.Domain.Entities;
using LabStore.Domain.Repositories;
using LabStore.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LabStore.Infraestructure.Repositories
{
    public class ProductRepository(AppDbContext context) : IProductRepository
    {
        public async Task<Product> GetByIdAsync(Specification<Product> specification, CancellationToken cancellationToken)
        {
            var product = await context.Products
                .Where(specification.ToExpression())
                .FirstOrDefaultAsync(cancellationToken);

            return product;
        }

        public async Task Create(Product product, CancellationToken cancellationToken = default)
        {
            await context.Products.AddAsync(product, cancellationToken);
            //await context.SaveChangesAsync(cancellationToken);
        }
    }
}
