using DemoRepositoryDemo.Core.Contracts.Repositories;
using DemoRepositoryPattern.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoRepositoryPattern.Infraestructure.Repositories
{
    /// <summary>
    /// Implementação base das operações de leitura, criação, atualização e remoção.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="context"></param>
    public abstract class Repository<T>(DbContext context) : IRepository<T> where T : class
    {
        // Obté
        private readonly DbSet<T> _dbSet = context.Set<T>();

        public async Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
            return entity;
        }

        public async Task<T> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await GetById(id);

            _dbSet.Remove(entity);
            await context.SaveChangesAsync(cancellationToken);

            return entity;
        }

        public async Task<List<T>?> GetAll(int skip = 0, int take = 25, CancellationToken cancellationToken = default)
        {
            return await _dbSet.AsNoTracking().Skip(skip).Take(take).ToListAsync();
        }

        public async Task<T?> GetById(int id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(id, cancellationToken);
        }

        public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            _dbSet.Update(entity);
            context.SaveChangesAsync(cancellationToken);

            return entity;

        }
    }
}
