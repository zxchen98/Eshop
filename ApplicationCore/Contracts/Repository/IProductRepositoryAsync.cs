using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository
{
    public interface IProductRepositoryAsync:IBaseRepositoryAsync<Product>
    {
        Task<(IEnumerable<Product>, int)> GetProductsByCategoryAsync(string categoryName, int pageSize, int pageNumber);
    }
}
