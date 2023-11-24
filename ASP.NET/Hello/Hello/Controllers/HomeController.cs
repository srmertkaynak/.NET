using Microsoft.AspNetCore.Mvc;

namespace Hello.Controllers
{
    public class HomeController : Controller // controller
    {
        public string Index() // action
        {
            return "Uygulama çalışıyor";
        }

        public string Test()
        {
            return "Bu test action'udur.";
        }

        public IActionResult Selamla()
        {
            ViewResult result = View();
            return result;
        }

        public IActionResult Selamla2()
        {
            ViewResult result = View();
            return result;
        }
    }
}
