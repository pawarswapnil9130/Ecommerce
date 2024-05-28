using Microsoft.AspNetCore.Mvc;

namespace Ekart.Controllers
{
    public class AuthenticationLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
