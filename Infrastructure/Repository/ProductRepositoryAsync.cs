using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
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
        public async Task<(IEnumerable<Product>, int)> GetProductsByCategoryAsync(string categoryName, int pageSize, int pageNumber)
        {
            var query = _context.Products
                                .Where(p => p.Category.name == categoryName);

            int totalProducts = await query.CountAsync();
            var products = await query.Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize)
                                      .ToListAsync();

            return (products, totalProducts);
        }
    }
}
