using ApplicationCore.Contracts.Repository;
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
    }
}
