using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceAppDomain.Entities;

namespace Infrastructure.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetCategories()
        {
            return new List<Category> {
                new Category { categoryId = 1, name = "Movies" },
                new Category { categoryId = 2, name = "Utilities" },
                new Category { categoryId = 3, name = "Home Appliances" },
                new Category { categoryId = 4, name = "Books" },
                new Category { categoryId = 5, name = "Softwares" },
                new Category { categoryId = 6, name = "Flowers" },
                new Category { categoryId = 7, name = "Cars" },
                new Category { categoryId = 8, name = "Sunglasses" }
            };
        }
    }
}
