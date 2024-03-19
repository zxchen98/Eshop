using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IShipperServiceAsync
    {
        Task<IEnumerable<Shipper>> GetAllShippersAsync();
        Task<Shipper> GetShipperByIdAsync(int id);
        Task CreateShipperAsync(Shipper shipper);
        Task UpdateShipperAsync(Shipper shipper);
        Task DeleteShipperAsync(int id);
    }
}
