using LabStore.Domain.Abstracts;

namespace LabStore.Domain.Entities
{
    public class Product : Entity
    {
        public string Title { get; set; } = string.Empty;
    }
}
