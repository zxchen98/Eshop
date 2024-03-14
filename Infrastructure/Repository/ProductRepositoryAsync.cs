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
    public class ProductRepositoryAsync : BaseRepositoryAsync<Product>, IProductRepositoryAsync
    {
        public ProductRepositoryAsync(TrainingDbContext tb) : base(tb)
        {
        }
    }
}
