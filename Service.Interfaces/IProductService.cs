using EcommerceAppDomain.Entities;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface IProductService
    {
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts();
        int UpdateProduct(Product product);
        IEnumerable<Product> SearchProductsByName(string productName);
        IEnumerable<Product> GetProductsByCategory(int catId);
    }
}
