using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class PromotionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
