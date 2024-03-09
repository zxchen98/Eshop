using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ShipperRepository : BaseRepository<Shipper>, IShipperRepository
    {
        public ShipperRepository(TrainingDbContext tb) : base(tb)
        {
        }
    }
}
