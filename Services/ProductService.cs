using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceAppDomain.Entities;
using Domain.Interfaces;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        
        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _repository.GetProducts();
        }

        public IEnumerable<Product> GetProductsByCategory(int catId)
        {
            return _repository.GetProductsByCategory(catId);
        }

        public IEnumerable<Product> SearchProductsByName(string productName)
        {
            return _repository.SearchProductsByName(productName);
        }

        public int UpdateProduct(Product product)
        {
            return _repository.UpdateProduct(product);
        }
    }
}
