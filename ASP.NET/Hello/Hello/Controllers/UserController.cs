using Hello.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hello.Controllers
{
    public class UserController : Controller
    {
        public IActionResult GetUser()
        {
            User user = new User();
            user.ID = 1;
            user.FirstName = "Abdullah";
            user.LastName = "Yeşil";
            return View();
        }

        [NonAction]
        public string GetFullName(User user)
        {
            return user.FirstName + " " + user.LastName;
        }
    }
}
