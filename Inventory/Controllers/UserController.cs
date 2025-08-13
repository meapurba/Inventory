using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
