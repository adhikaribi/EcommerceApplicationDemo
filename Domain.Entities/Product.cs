using System;
using System.Collections.Generic;

namespace EcommerceAppDomain.Entities
{
    public class Product
    {
        public Product()
        {
            this.stocks = new HashSet<Stock>();
        }

        public int productId { get; set; }
        public int catid { get; set; }
        public string name { get; set; }
        public Nullable<double> price { get; set; }
        public string path { get; set; }
        public string description { get; set; }

        public virtual ICollection<Stock> stocks { get; set; }
        public virtual Category category { get; set; }
    }
}