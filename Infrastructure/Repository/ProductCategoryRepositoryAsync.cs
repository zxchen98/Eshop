using ApplicationCore.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProductCategoryRepositoryAsync : BaseRepositoryAsync<Category>
    {
        public ProductCategoryRepositoryAsync(TrainingDbContext tb) : base(tb)
        {
        }
    }
}
