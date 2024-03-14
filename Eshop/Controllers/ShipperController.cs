using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ShipperController : Controller
    {
        protected readonly IShipperRepositoryAsync shipperRepository;
        public ShipperController(IShipperRepositoryAsync repo)
        {
            shipperRepository = repo;
        }
        public IActionResult Index()
        {
            var content = shipperRepository.GetAllAsync();
            return View(content);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Shipper obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    shipperRepository.InsertAsync(obj);
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
            var department = shipperRepository.GetByIdAsync(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Shipper obj)
        {
            shipperRepository.DeleteAsync(obj.Id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = shipperRepository.GetByIdAsync(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Shipper shipper)
        {
            try
            {

                shipperRepository.UpdateAsync(shipper);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(shipper);
            }
        }
    }
}
