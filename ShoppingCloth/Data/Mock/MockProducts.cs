using ShoppingCloth.Data.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ShoppingCloth.Data.Mock
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductsCategory _categoryProducts = new MockCategory();
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product {
                        Name ="Кепка NICE",
                        Description ="Кепка описание",
                        Image = "~/img/niceKEPKA1.jpg",
                        Price=1200,
                        Category = _categoryProducts.AllCategories.First()},
                    new Product {
                        Name ="Трусы адидас",
                        Description ="Трусы описание",
                        Image = "~/img/adidasTrusi1.jpg",
                        Price=12200,
                        Category = _categoryProducts.AllCategories.First()},
                    new Product {
                        Name ="Кепка Puma",
                        Description ="Кепка описание",
                        Image = "~/img/pumaKepka1.jpg",
                        Price=10,
                        Category = _categoryProducts.AllCategories.First()}
                };

            }
        } 
        public IEnumerable<Product> GetProducts { get; set; }
        public Product GetProductId(int productId)
        {
            throw new NotImplementedException();
        }
    }
   
    
}
