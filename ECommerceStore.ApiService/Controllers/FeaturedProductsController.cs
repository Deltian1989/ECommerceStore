using AutoMapper;
using ECommerceStore.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceStore.ApiService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeaturedProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public FeaturedProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFeaturedProducts()
        {
            var products = await _productService.GetFeaturedProducts();

            return Ok(products);
        }
    }
}
