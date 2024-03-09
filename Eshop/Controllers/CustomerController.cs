using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
