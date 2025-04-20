using LabStore.Domain.Abstracts;
using LabStore.Domain.Entities;
using System.Linq.Expressions;

namespace LabStore.Domain.Specifications.Products
{
    public class GetProductByIdSpecification(Guid id) : Specification<Product>
    {
        public override Expression<Func<Product, bool>> ToExpression()
            => product => product.Id == id;
    }
}
