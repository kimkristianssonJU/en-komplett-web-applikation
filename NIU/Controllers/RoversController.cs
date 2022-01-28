using Microsoft.AspNetCore.Mvc;

namespace NIU.Controllers
{
    public class RoversController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}
