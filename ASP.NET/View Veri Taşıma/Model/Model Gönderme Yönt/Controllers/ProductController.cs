using Microsoft.AspNetCore.Mvc;
using System;

namespace Model_Gönderme_Yönt.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string userName = "Abdullah Onur";
            return View(userName as Object);
        }
    }
}
