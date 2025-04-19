using DemoRepositoryDemo.Core.Models;

namespace DemoRepositoryDemo.Core.Contracts.Repositories
{
    public interface IProductRepository
    {
        public Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default);

        public Task<Product> UpdateAsync(Product product, CancellationToken cancellationToken = default);

        public Task<Product> DeleteAsync(int id, CancellationToken cancellationToken = default);

        public Task<Product?> GetById(int id, CancellationToken cancellationToken = default);

        public Task<List<Product>?> GetAll(int skip = 0
           , int take = 25
           , CancellationToken cancellationToken = default);
    }
}
