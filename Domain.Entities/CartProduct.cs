using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CartProduct
    {
        public int productId { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int qty { get; set; }
    }
}
