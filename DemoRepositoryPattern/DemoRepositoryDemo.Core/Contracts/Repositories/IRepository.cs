namespace DemoRepositoryDemo.Core.Contracts.Repositories
{
    /// <summary>
    /// Repositório genérico que apresenta as quatro operações: criação, leitura, atualização e remoção.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        public Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);

        public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);

        public Task<T> DeleteAsync(int id, CancellationToken cancellationToken = default);

        public Task<T?> GetById(int id, CancellationToken cancellationToken = default);

        public Task<List<T>?> GetAll(int skip = 0
           , int take = 25
           , CancellationToken cancellationToken = default);
    }
}
