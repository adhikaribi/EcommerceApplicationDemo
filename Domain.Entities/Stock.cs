using System;

namespace EcommerceAppDomain.Entities
{
    public class Stock
    {
        public int stockId { get; set; }
        public int productId { get; set; }
        public Nullable<int> qty { get; set; }

        public virtual Product tbl_product { get; set; }
    }
}