using LabStore.Domain.Abstracts;
using LabStore.Domain.Entities;

namespace LabStore.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetByIdAsync(Specification<Product> product, CancellationToken cancellationToken);
        Task Create(Product product, CancellationToken cancellationToken = default);
    }
}
