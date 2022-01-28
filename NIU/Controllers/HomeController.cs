using Microsoft.AspNetCore.Mvc;

namespace NIU.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
