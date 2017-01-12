using Domain.Interfaces;
using System;
using System.Collections.Generic;
using EcommerceAppDomain.Entities;
using System.Linq;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>() {
                new Product() { productId = 5, name = "Ghost Riders", description="Test", path="/images/ghost.jpg", price=20, catid = 1},
                new Product() { productId = 10, name="Fan", description="Test", path="/images/fan.jpg", price=1200, catid = 2},
                new Product() { productId = 15, name="Microwave", description="Test", path="/images/microwave.jpg", price=1100, catid = 1 },
            };
        }

        public Product GetProductById(int id)
        {
            var result = products.Where(p => p.productId.Equals(id)).SingleOrDefault();
            return result;
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByCategory(int catId)
        {
            var result = products.Where(p => p.catid.Equals(catId));
            return result;
        }

        public IEnumerable<Product> SearchProductsByName(string productName)
        {
            var result = products.Where(p => p.name.ToLower().Contains(productName.ToLower()));
            return result;
        }

        public int UpdateProduct(Product product)
        {
            var result = products.Where(p => p.productId.Equals(product.productId)).SingleOrDefault();
            result.name = product.name;
            result.path = product.path;
            result.price = product.price;
            result.productId = product.productId;
            //products.Remove(result);
           // products.Add(product);
            return 1;
        }
    }
}
