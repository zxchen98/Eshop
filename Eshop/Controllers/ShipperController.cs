using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ShipperController : Controller
    {
        protected readonly IShipperRepository shipperRepository;
        public ShipperController(IShipperRepository repo)
        {
            shipperRepository = repo;
        }
        public IActionResult Index()
        {
            var content = shipperRepository.GetAll();
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
                    shipperRepository.Insert(obj);
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
            var department = shipperRepository.GetById(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Shipper obj)
        {
            shipperRepository.Delete(obj.Id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = shipperRepository.GetById(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Shipper shipper)
        {
            try
            {

                shipperRepository.Update(shipper);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(shipper);
            }
        }
    }
}
