using ECommerceStore.Core.DTOS;
using ECommerceStore.Core.Utils;

namespace ECommerceStore.Core.Interfaces
{
    public interface IProductService
    {
        Task<IReadOnlyList<ProductDto>> GetProducts(ProductSliderCategory productSliderCategory);
    }
}
