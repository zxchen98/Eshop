using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ProductController : Controller
    {
        protected readonly IProductRepositoryAsync productRepository;
        public ProductController(IProductRepositoryAsync repo)
        {
            productRepository = repo;
        }
        public IActionResult Index()
        {
            var content = productRepository.GetAllAsync();
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
                    productRepository.InsertAsync(obj);
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
            var department = productRepository.GetByIdAsync(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Product obj)
        {
            productRepository.DeleteAsync(obj.Id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = productRepository.GetByIdAsync(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            try
            {

                productRepository.UpdateAsync(obj);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(obj);
            }
        }

    }
}
