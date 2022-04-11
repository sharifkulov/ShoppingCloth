using System.Collections.Generic;

namespace ShoppingCloth.Data.Models
{
    public class ShopProduct
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ShopProduct(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public int ItemShopProductId { get; set; }
        public List<ShopProductItem> ListShopProductItem { get; set; }
    }
}
