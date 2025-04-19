using DemoRepositoryDemo.Core.Contracts.Repositories;
using DemoRepositoryDemo.Core.Models;
using DemoRepositoryPattern.Infraestructure.Data;

namespace DemoRepositoryPattern.Infraestructure.Repositories
{
    public class ProductRepository (AppDbContext _context) : Repository<Product>(_context), IProductRepository;
}
