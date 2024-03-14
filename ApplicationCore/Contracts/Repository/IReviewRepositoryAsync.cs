﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository
{
    public interface IReviewRepositoryAsync : IBaseRepositoryAsync<Review>
    {
        public IEnumerable<Review> GetReviewsByProductId(int productId);
    }
}
