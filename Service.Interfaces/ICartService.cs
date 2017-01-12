using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICartService
    {
        IEnumerable<CartProduct> GetCartItems();
        void AddCartItem(CartProduct item);
        double GetTotalPrice();
        void DeleteItem(int productId);
    }
}
