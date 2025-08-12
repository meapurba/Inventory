using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
