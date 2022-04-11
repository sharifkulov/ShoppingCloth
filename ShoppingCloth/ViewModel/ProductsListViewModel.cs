using Microsoft.AspNetCore.Mvc;
using ShoppingCloth.Data.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace ShoppingCloth.ViewModel

{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> AllProducts { get; set; }
        public string currCategory { get; set; }
    }
}
