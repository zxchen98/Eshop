using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ProductController : Controller
    {
        protected readonly IProductRepository productRepository;
        public ProductController(IProductRepository repo)
        {
            productRepository = repo;
        }
        public IActionResult Index()
        {
            var content = productRepository.GetAll();
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
                    productRepository.Insert(obj);
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
            var department = productRepository.GetById(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Product obj)
        {
            productRepository.Delete(obj.Id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = productRepository.GetById(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            try
            {

                productRepository.Update(obj);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(obj);
            }
        }

    }
}
