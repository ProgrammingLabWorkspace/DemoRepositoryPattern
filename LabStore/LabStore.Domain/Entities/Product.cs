using LabStore.Domain.Abstracts;
using LabStore.Domain.Repositories;

namespace LabStore.Domain.Entities
{
    public class Product : Entity, IAggregateRoot
    {
        public string Title { get; set; } = string.Empty;
    }
}
