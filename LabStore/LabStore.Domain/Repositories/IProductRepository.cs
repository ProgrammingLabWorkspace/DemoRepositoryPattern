using LabStore.Domain.Entities;

namespace LabStore.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
