﻿using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
