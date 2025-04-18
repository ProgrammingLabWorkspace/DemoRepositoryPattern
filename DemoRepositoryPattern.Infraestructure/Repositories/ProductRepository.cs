using DemoRepositoryDemo.Core.Models;
using DemoRepositoryPattern.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoRepositoryPattern.Infraestructure.Repositories
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default)
        {
            await _context.Products.AddAsync(product, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return product;
        }

        public async Task<Product> UpdateAsync(Product product, CancellationToken cancellationToken = default)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync(cancellationToken);

            return product;
        }

        public async Task<Product> DeleteAsync(Product product, CancellationToken cancellationToken = default)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync(cancellationToken);

            return product;
        }

        public async Task<Product?> GetById(int id, CancellationToken cancellationToken = default)
        {
            return await _context
                .Products
                .AsNoTracking()
                .FirstOrDefaultAsync(prod => prod.Id == id, cancellationToken);
        }

        public async Task<List<Product>?> GetAll(int skip = 0
            , int take = 25
            , CancellationToken cancellationToken = default)
        {
            return await _context
                .Products
                .AsNoTracking()
                .Skip(skip)
                .Take(take)
                .ToListAsync(cancellationToken);
        }
    }
}
