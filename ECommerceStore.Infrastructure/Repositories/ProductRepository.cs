using ECommerceStore.Core.Interfaces;
using ECommerceStore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerceStore.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<TEntity>> GetAsync<TEntity>(Expression<Func<TEntity, bool>> wherePredicate, int skip, int take) where TEntity : class
        {
            return await _dbContext.Set<TEntity>().Where(wherePredicate).Skip(skip).Take(take).ToListAsync();
        }
    }
}
