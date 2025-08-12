using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
