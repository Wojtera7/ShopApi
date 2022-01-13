using Microsoft.AspNetCore.Mvc;
using ShopApi.Services;

namespace ShopApi.Controllers
{
    [Route("api/[controller]")] // https://<site>:<port>/api/Products
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public IActionResult Get()
        {           
            var products = _productsService.GetProducts();
            return Ok(products);
        }


        //[Route("{id}/parts/{partNumber}")]
        //https://localhost:xxxx/api/Products/123/parts/abc
        //public IActionResult GetProduct(string id, string partNumber)


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProduct(string id)
        {
            var product = _productsService.GetProduct(id);
            return Ok(product);
        }






    }
}
