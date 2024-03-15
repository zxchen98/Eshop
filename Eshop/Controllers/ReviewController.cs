using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewRepositoryAsync _reviewRepository;

        public ReviewController(IReviewRepositoryAsync reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public IActionResult Index(int productId)
        {
            var reviews = _reviewRepository.GetReviewsByProductId(productId);
            return View(reviews);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Review review)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _reviewRepository.InsertAsync(review);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(review);
                }
            }
            return View(review);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var department = _reviewRepository.GetByIdAsync(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Shipper obj)
        {
            _reviewRepository.DeleteAsync(obj.Id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = _reviewRepository.GetByIdAsync(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Review review)
        {
            try
            {

                _reviewRepository.UpdateAsync(review);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(review);
            }
        }
    }
}
