using System.Collections;
using System.Collections.Generic;

namespace ShoppingCloth.Data.Models
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get;  }
        IEnumerable<Product> GetProducts { get; }
        Product GetProductId(int id);

    }
}
