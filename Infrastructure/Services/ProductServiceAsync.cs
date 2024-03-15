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

        public async Task<int> AddNewProduct(Product p)
        {
            return await _productRepositoryAsync.InsertAsync(p);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepositoryAsync.GetAllAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            return await _productRepositoryAsync.Filter(product => product.Name.Equals(name));
        }

        public async Task<(IEnumerable<Product>, int)> GetProductsByCategoryAsync(string categoryName, int pageSize, int pageNumber)
        {
            return await _productRepositoryAsync.GetProductsByCategoryAsync(categoryName, pageSize, pageNumber);
        }

        public async Task<int> DeleteProduct(int id)
        {
            int result = await _productRepositoryAsync.DeleteAsync(id);
            return result;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {

            var product = await _productRepositoryAsync.GetByIdAsync(id);

            return product;
        }

        public async Task<int> UpdateProductAsync(Product p)
        {
            return await _productRepositoryAsync.UpdateAsync(p);
        }
    }
}
