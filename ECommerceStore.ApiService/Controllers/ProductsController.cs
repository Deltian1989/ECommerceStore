using ECommerceStore.Core.Interfaces;
using ECommerceStore.Core.Utils;
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

        [HttpGet()]
        public async Task<IActionResult> GetProducts(ProductSliderCategory productSliderCategory = ProductSliderCategory.None)
        {
            var products = await _productService.GetProducts(productSliderCategory);

            return Ok(products);
        }
    }
}
