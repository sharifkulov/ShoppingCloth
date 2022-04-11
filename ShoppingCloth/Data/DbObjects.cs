
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCloth.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCloth.Data
{
    public class DbObjects
    {
        public static void Init(ApplicationDbContext context)
        {

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }
            if (!context.Products.Any())
            {
                context.AddRange(
                    new Product
                    {
                        Name = "Кепка NICE",
                        Description = "Кепка описание",
                        Image = "~/img/niceKEPKA1.jpg",
                        Price = 1200,
                        Category = Categories["Головной убор"]
                    },
                    new Product
                    {
                        Name = "Трусы адидас",
                        Description = "Трусы описание",
                        Image = "~/img/adidasTrusi1.jpg",
                        Price = 12200,
                        Category = Categories["Нижнее белье"]
                    },
                    new Product
                    {
                        Name = "Кепка Puma",
                        Description = "Кепка описание",
                        Image = "~/img/pumaKepka1.jpg",
                        Price = 10,
                        Category = Categories["Головной убор"]
                    }

                    );
            }
            context.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                    new Category{ CategoryName = "Головной убор", Description = "Шапки,кепки"},                  
                    new Category{ CategoryName = "Нижнее белье", Description = "Трусы"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category c in list)
                    {
                        category.Add(c.CategoryName, c);
                    }
                    
                }
                return category;
            }
        }        
    }
}
