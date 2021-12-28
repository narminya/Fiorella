using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
