using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IProductServiceAsync
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<int> AddNewProduct(Product p);
        Task<IEnumerable< Product>> GetProductByName(string name);
        Task<(IEnumerable<Product>, int)> GetProductsByCategoryAsync(string categoryName, int pageSize, int pageNumber);
        Task<int> DeleteProduct(int id);
        Task<Product> GetProductByIdAsync(int id);
        Task<int> UpdateProductAsync(Product p);
    }
}
