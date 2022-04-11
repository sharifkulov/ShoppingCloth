using ShoppingCloth.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace ShoppingCloth.Data.Mock
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ CategoryName = "Головной убор", Description = "Шапки,кепки"},
                    //new Category{ CategoryName = "Футболки", Description = "Красивые и не дорогие"},
                    new Category{ CategoryName = "Нижнее белье", Description = "Трусы"}
                };
            }
        }
    }
    
}
