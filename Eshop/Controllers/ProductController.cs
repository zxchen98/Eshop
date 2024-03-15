using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ProductController : Controller
    {
        protected readonly IProductServiceAsync _productService;
        public ProductController(IProductServiceAsync productSeravice)
        {
            _productService = productSeravice;
        }
        public IActionResult Index()
        {
            var content = _productService.GetAllProducts();
            return View(content);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _productService.AddNewProduct(obj);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(obj);
                }
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(Product obj)
        {
            var res = _productService.DeleteProduct(obj.Id);
            return View(res);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = _productService.GetProductByIdAsync(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            try
            {

                _productService.UpdateProductAsync(obj);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(obj);
            }
        }

    }
}
