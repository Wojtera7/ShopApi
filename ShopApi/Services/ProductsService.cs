using ShopApi.Models.Api;
using ShopApi.Repositories;
using System.Collections.Generic;

namespace ShopApi.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public List<Product> GetProducts()
        {
            return _productsRepository.GetProducts();
        }

        public Product GetProduct(string id)
        {
            return _productsRepository.GetProduct(id);
        }
    }
}
