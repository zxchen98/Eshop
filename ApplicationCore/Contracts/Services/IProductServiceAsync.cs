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
    }
}
