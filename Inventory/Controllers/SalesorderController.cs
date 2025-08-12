using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class SalesorderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
