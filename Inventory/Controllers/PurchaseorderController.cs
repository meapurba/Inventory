using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class PurchaseorderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
