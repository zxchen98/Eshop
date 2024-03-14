using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
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

            return _productRepositoryAsync.InsertAsync(p);
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            var result = await _productRepositoryAsync.Filter(x => x.Name == name);
            return result;
        }
    }
}
