using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _repository;

        public CartService(ICartRepository repository)
        {
            _repository = repository;
        }

        public void AddCartItem(CartProduct item)
        {
            _repository.AddCartItem(item);
        }

        public void DeleteItem(int productId)
        {
            _repository.DeleteItem(productId);
        }

        public IEnumerable<CartProduct> GetCartItems()
        {
            return _repository.GetCartItems();
        }

        public double GetTotalPrice()
        {
            return _repository.GetTotalPrice();
        }
    }
}
