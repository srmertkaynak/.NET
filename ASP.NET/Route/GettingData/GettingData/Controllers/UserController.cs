using Microsoft.AspNetCore.Mvc;

namespace GettingData.Controllers
{
    public class UserController : Controller
    {
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(string firstName, string lastName)
        {
            return View();
        }
    }
}
