using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductServiceAsync : IProductServiceAsync
    {
        public readonly IProductRepositoryAsync _productRepositoryAsync;

        public ProductServiceAsync(IProductRepositoryAsync productRepositoryAsync)
        {
            this._productRepositoryAsync = productRepositoryAsync;
        }

        public Task<int> AddNewProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<Product>, int)> GetProductsByCategoryAsync(string categoryName, int pageSize, int pageNumber)
        {
            return await _productRepositoryAsync.GetProductsByCategoryAsync(categoryName, pageSize, pageNumber);
        }
    }
}
