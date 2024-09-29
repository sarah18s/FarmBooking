using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Infrastructure.Data;
using FarmBookingBackend.Infrastructure.Repository.Interface;

namespace FarmBookingBackend.Infrastructure.Repository.Implemintaion
{
     public class FarmRepository : Repository<Farm>, IFarmRepository
    {
        private readonly ApplicationDbContext _db;

        public FarmRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void update(Farm farm)
        {
            _db.Farms.Update(farm);
        }
    }
}
