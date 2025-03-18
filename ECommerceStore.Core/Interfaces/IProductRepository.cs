using System.Linq.Expressions;

namespace ECommerceStore.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<TEntity>> GetAsync<TEntity>(Expression<Func<TEntity, bool>> wherePredicate, int skip, int take) where TEntity : class;
    }
}
