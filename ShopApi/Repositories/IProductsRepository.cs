using ShopApi.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApi.Repositories
{
    public interface IProductsRepository
    {
        List<Product> GetProducts();
        Product GetProduct(string id);
    }
}
