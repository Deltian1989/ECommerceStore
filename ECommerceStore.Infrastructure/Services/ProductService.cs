using AutoMapper;
using ECommerceStore.Core.DTOS;
using ECommerceStore.Core.Entities;
using ECommerceStore.Core.Interfaces;

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

        public async Task<IReadOnlyList<DiscountedProductDto>> GetDiscountedProducts()
        {
            var productEntities = await _repository.GetAsync<Product>(p => p.Discount > 0, 0, 14);

            var featuredProducts = _mapper.Map<IReadOnlyList<DiscountedProductDto>>(productEntities);

            return featuredProducts;
        }

        public async Task<IReadOnlyList<FeaturedProductDto>> GetFeaturedProducts()
        {
            var dateTimeLastTwoWeeks = DateTime.Now.AddDays(-14);

            var productEntities = await _repository.GetAsync<Product>(p => p.AddedDate >= dateTimeLastTwoWeeks,0,14);

            var featuredProducts = _mapper.Map<IReadOnlyList<FeaturedProductDto>>(productEntities);

            return featuredProducts;
        }
    }
}
