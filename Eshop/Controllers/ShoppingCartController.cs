using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
