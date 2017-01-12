using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class CartRepository : ICartRepository
    {
        private static List<CartProduct> cartItems = new List<CartProduct>();

        // TODO Bibek : Session manipulation as per user needs to be implemented here
        // The cart must be availabe for each user, so that it does not conflict with others
        // Storing cart can be done via Entity Model or Keeping the list in Session object
        public void AddCartItem(CartProduct item)
        {
            var existingItem = cartItems.SingleOrDefault(c => c.productId == item.productId &&
            c.name.Equals(item.name));
            if (existingItem == null)
                cartItems.Add(item);
            else
                existingItem.qty += 1;
        }

        public void DeleteItem(int productId)
        {
            var existingItem = cartItems.SingleOrDefault(c => c.productId == productId);
            if (existingItem != null)
                cartItems.Remove(existingItem);
        }

        public IEnumerable<CartProduct> GetCartItems()
        {
            return cartItems;
        }

        public double GetTotalPrice()
        {
            return cartItems.Sum(c => c.qty * c.price);
        }
    }
}
