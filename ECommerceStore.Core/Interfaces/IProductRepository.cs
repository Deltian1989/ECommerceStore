using ECommerceStore.Core.Entities;

namespace ECommerceStore.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<TEntity>> GetAsync<TEntity>() where TEntity : class;
    }
}
