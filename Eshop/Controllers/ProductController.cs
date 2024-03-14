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
            var content = _productService.GetAllAsync();
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
                    _productService.InsertAsync(obj);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(obj);
                }
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var department = _productService.GetByIdAsync(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Product obj)
        {
            _productService.DeleteAsync(obj.Id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = _productService.GetByIdAsync(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            try
            {

                _productService.UpdateAsync(obj);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(obj);
            }
        }

    }
}
