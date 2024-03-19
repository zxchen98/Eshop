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
    public class ShoppingCartService : IShoppingCartServiceAsync
    {
        private readonly IBaseRepositoryAsync<ShoppingCart> _cartRepository;

        public ShoppingCartService(IBaseRepositoryAsync<ShoppingCart> cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<IEnumerable<ShoppingCart>> GetAllCartsAsync()
        {
            return await _cartRepository.GetAllAsync();
        }

        public async Task<ShoppingCart> GetCartByIdAsync(int id)
        {
            return await _cartRepository.GetByIdAsync(id);
        }

        public async Task CreateCartAsync(ShoppingCart shoppingCart)
        {
            await _cartRepository.InsertAsync(shoppingCart);
        }

        public async Task UpdateCartAsync(ShoppingCart shoppingCart)
        {
            await _cartRepository.UpdateAsync(shoppingCart);
        }

        public async Task DeleteCartAsync(int id)
        {
            await _cartRepository.DeleteAsync(id);
        }
    }

}
