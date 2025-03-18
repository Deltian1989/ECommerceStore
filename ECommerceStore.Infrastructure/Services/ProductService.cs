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

        public async Task<IReadOnlyList<FeaturedProductDto>> GetFeaturedProducts()
        {
            var dateTimeLastTwoWeeks = DateTime.Now.AddDays(14);

            var productEntities = await _repository.GetAsync<Product>(p => p.AddedDate >= dateTimeLastTwoWeeks,0,8);

            var featuredProducts = _mapper.Map<IReadOnlyList<FeaturedProductDto>>(productEntities);

            return featuredProducts;
        }
    }
}
