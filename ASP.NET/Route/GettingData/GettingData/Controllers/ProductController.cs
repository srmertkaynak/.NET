using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product(){ID = 1, ProductName = "Kitap"},
            new Product(){ID = 2, ProductName = "Televizyon"},
            new Product(){ID = 3, ProductName = "Kalem"},
            new Product(){ID = 4, ProductName = "Silgi"},
        };
        public IActionResult GetAllProducts()
        {
            return View(products);
        }

        public IActionResult GetProductById(int id)
        {
            Product product = products.Find(x => x.ID == id);
            return View(product);
        }
    }
}
