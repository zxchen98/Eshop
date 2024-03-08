using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ShipperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
