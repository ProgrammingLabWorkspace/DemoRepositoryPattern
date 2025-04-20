namespace LabStore.Domain.Abstracts
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
