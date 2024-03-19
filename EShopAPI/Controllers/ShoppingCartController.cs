using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartServiceAsync _shoppingCartService;

        public ShoppingCartController(IShoppingCartServiceAsync shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var carts = await _shoppingCartService.GetAllCartsAsync();
            return Ok(carts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cart = await _shoppingCartService.GetCartByIdAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            return Ok(cart);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ShoppingCart shoppingCart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _shoppingCartService.CreateCartAsync(shoppingCart);
            return CreatedAtAction(nameof(GetById), new { id = shoppingCart.Id }, shoppingCart);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ShoppingCart shoppingCart)
        {
            if (id != shoppingCart.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _shoppingCartService.UpdateCartAsync(shoppingCart);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cart = await _shoppingCartService.GetCartByIdAsync(id);
            if (cart == null)
            {
                return NotFound();
            }

            await _shoppingCartService.DeleteCartAsync(id);
            return NoContent();
        }
    }

}
