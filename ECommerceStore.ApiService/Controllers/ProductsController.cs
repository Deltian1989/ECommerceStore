using ECommerceStore.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceStore.ApiService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("featured")]
        public async Task<IActionResult> GetFeaturedProducts()
        {
            var products = await _productService.GetFeaturedProducts();

            return Ok(products);
        }

        [HttpGet("discounted")]
        public async Task<IActionResult> GetDiscountedProducts()
        {
            var products = await _productService.GetDiscountedProducts();

            return Ok(products);
        }
    }
}
