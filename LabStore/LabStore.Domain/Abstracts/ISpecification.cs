using System.Linq.Expressions;

namespace LabStore.Domain.Abstracts
{
    public  interface ISpecification<T>
    {
        Expression<Func<T, bool>> ToExpression();
        bool IsSatisfiedBy(T entity);
    }
}
