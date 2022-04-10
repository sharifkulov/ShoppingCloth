


using ShoppingCloth.Data.Models;
using System.Collections.Generic;

namespace ShoppingCloth.Data.Repository
{
    public class CategoryRepository : IProductsCategory
    {
        private readonly ApplicationDbContext applicationDbContext;
        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Category> AllCategories => applicationDbContext.Categories;
    }
}
