using LabStore.Domain.Abstracts;

namespace LabStore.Domain.Repositories
{
    public interface IRepository<T> where T : IAggregateRoot
    {
    }
}
