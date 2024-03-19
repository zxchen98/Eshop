using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IShoppingCartServiceAsync
    {
        Task<IEnumerable<ShoppingCart>> GetAllCartsAsync();
        Task<ShoppingCart> GetCartByIdAsync(int id);
        Task CreateCartAsync(ShoppingCart shoppingCart);
        Task UpdateCartAsync(ShoppingCart shoppingCart);
        Task DeleteCartAsync(int id);
    }
}
