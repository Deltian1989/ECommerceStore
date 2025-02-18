using ECommerceStore.Core.Interfaces;
using ECommerceStore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ECommerceStore.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<TEntity>> GetAsync<TEntity>() where TEntity : class
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }
    }
}
