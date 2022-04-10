using Microsoft.AspNetCore.Mvc;
using ShoppingCloth.Data.Models;
using Microsoft.Extensions.Logging;
using ShoppingCloth.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCloth.ViewModel;

namespace ShoppingCloth.Controllers
{
    public class ProductsController:Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductsCategory _allCategories;
        public ProductsController(IAllProducts iAllProducts, IProductsCategory iProductCategory)
        {
            _allProducts = iAllProducts;
            _allCategories = iProductCategory;
        }
        public ViewResult List()
        {
            ViewBag.Tittle = "Страница с одеждой";
            ProductsListViewModel obj = new ProductsListViewModel();
            obj.AllProducts = _allProducts.Products;
            obj.currCategory = "Шмот";

            return View(obj);
        }
    }
}
