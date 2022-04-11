namespace ShoppingCloth.Data.Models
{
    public class ShopProductItem
    {
        public int Id { get; set; }
        public Product ItemProduct { get; set; }
        public int ItemPrice { get; set; }
        public string ItemShopProductId { get; set; }
    }
}
