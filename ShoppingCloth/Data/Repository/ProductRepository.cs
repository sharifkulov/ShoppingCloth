


using Microsoft.EntityFrameworkCore;
using ShoppingCloth.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCloth.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Product> Products => applicationDbContext.Products.Include(c=>c.Category);

        public IEnumerable<Product> GetProducts => applicationDbContext.Products.Where(p => p.Favourite).Include(c => c.Category);
        public Product GetProductId(int id)
        {
            return applicationDbContext.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
