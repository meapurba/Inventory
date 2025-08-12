using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            ViewBag.Active = "product";
            return View();
        }
    }
}
