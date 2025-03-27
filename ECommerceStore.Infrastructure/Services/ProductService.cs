using AutoMapper;
using ECommerceStore.Core.DTOS;
using ECommerceStore.Core.Entities;
using ECommerceStore.Core.Interfaces;
using ECommerceStore.Core.Utils;

namespace ECommerceStore.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<ProductDto>> GetProducts(ProductSliderCategory productSliderCategory)
        {
            var dateTimeLastTwoWeeks = DateTime.Now.AddDays(-14);

            IReadOnlyList<Product> productEntities = null;

            if (productSliderCategory == ProductSliderCategory.FeaturedProducts)
            {
                productEntities = await _repository.GetAsync<Product>(p => p.AddedDate >= dateTimeLastTwoWeeks, 0, 14);
            }
            else if (productSliderCategory == ProductSliderCategory.DiscountedProducts)
            {
                productEntities = await _repository.GetAsync<Product>(p => p.Discount > 0, 0, 14);
            }
            else if (productSliderCategory == ProductSliderCategory.PopularProducts)
            {
                productEntities = await _repository.GetAsync<Product>(p => p.Discount > 0, 0, 14);
            }
            else
            {
                var dateTimeLastMonth = DateTime.Now.AddMonths(-1);

                productEntities = await _repository.GetAsync<Product>(p => p.AddedDate >= dateTimeLastMonth, 0, 200);
            }

            var featuredProducts = _mapper.Map<IReadOnlyList<ProductDto>>(productEntities);

            return featuredProducts;
        }
    }
}
