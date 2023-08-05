using Microsoft.AspNetCore.Mvc;

namespace PWS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
