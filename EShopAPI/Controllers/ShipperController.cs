using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EShopAPI.Controllers;
[Route("api/[controller]/")]
[ApiController]
public class ShippersController : ControllerBase
{
    private readonly IShipperServiceAsync _shipperService;

    public ShippersController(IShipperServiceAsync shipperService)
    {
        _shipperService = shipperService;
    }

    // GET: api/Shippers
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Shipper>>> GetAllShippers()
    {
        var shippers = await _shipperService.GetAllShippersAsync();
        return Ok(shippers);
    }

    // GET: api/Shippers/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Shipper>> GetShipper(int id)
    {
        var shipper = await _shipperService.GetShipperByIdAsync(id);

        return Ok(shipper);
    }

    // POST: api/Shippers
    [HttpPost]
    public async Task<IActionResult> CreateShipper([FromBody] Shipper shipper)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _shipperService.CreateShipperAsync(shipper);

        return CreatedAtAction(nameof(GetShipper), new { id = shipper.Id }, shipper);
    }

    // PUT: api/Shippers/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateShipper(int id, [FromBody] Shipper shipper)
    {
        if (id != shipper.Id)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _shipperService.UpdateShipperAsync(shipper);

        return NoContent();
    }

    // DELETE: api/Shippers/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteShipper(int id)
    {
        var shipper = await _shipperService.GetShipperByIdAsync(id);

        if (shipper == null)
        {
            return NotFound();
        }

        await _shipperService.DeleteShipperAsync(id);

        return NoContent();
    }
}
