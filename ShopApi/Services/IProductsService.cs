using ShopApi.Models.Api;
using System.Collections.Generic;

namespace ShopApi.Services
{
    public interface IProductsService
    {
        List<Product> GetProducts();
        Product GetProduct(string id);
    }
}
