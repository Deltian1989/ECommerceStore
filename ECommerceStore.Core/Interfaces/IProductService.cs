using ECommerceStore.Core.DTOS;

namespace ECommerceStore.Core.Interfaces
{
    public interface IProductService
    {
        Task<IReadOnlyList<FeaturedProductDto>> GetFeaturedProducts();
    }
}
