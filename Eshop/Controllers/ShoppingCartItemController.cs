using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ShoppingCartItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
