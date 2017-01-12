using System;
using System.Collections.Generic;

namespace EcommerceAppDomain.Entities
{
    public class Category
    {
        public Category()
        {
            this.items = new HashSet<Product>();
        }

        public int categoryId { get; set; }
        public string name { get; set; }
        public virtual ICollection<Product> items { get; set; }
    }
}