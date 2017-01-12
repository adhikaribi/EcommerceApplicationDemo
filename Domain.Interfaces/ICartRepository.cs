using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICartRepository
    {
        IEnumerable<CartProduct> GetCartItems();
        void AddCartItem(CartProduct item);
        double GetTotalPrice();
        void DeleteItem(int productId);
    }
}
