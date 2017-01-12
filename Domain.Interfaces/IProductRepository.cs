using EcommerceAppDomain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts();
        int UpdateProduct(Product product);
        IEnumerable<Product> SearchProductsByName(string productName);
        IEnumerable<Product> GetProductsByCategory(int catId);
    }
}
