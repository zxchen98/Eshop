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
    public class ShipperService : IShipperServiceAsync
    {
        private readonly IBaseRepositoryAsync<Shipper> _shipperRepository;

        public ShipperService(IBaseRepositoryAsync<Shipper> shipperRepository)
        {
            _shipperRepository = shipperRepository;
        }

        public async Task<IEnumerable<Shipper>> GetAllShippersAsync()
        {
            return await _shipperRepository.GetAllAsync();
        }

        public async Task<Shipper> GetShipperByIdAsync(int id)
        {
            return await _shipperRepository.GetByIdAsync(id);
        }

        public async Task CreateShipperAsync(Shipper shipper)
        {
            await _shipperRepository.InsertAsync(shipper);
        }

        public async Task UpdateShipperAsync(Shipper shipper)
        {
            await _shipperRepository.UpdateAsync(shipper);
        }

        public async Task DeleteShipperAsync(int id)
        {
            await _shipperRepository.DeleteAsync(id);
        }
    }

}
