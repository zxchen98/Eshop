using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ReviewRepositoryAsync : BaseRepositoryAsync<Review>, IReviewRepositoryAsync
    {
        public ReviewRepositoryAsync(TrainingDbContext tb) : base(tb)
        {
        }
        public IEnumerable<Review> GetReviewsByProductId(int productId)
        {
            return _context.Reviews.Where(r => r.ProductId == productId).ToList();
        }

    }
}
