using System.Collections.Generic;

namespace ShoppingCloth.Data.Models
{
    public interface IProductsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
