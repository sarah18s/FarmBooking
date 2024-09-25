using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Infrastructure.Context;
using FarmBookingBackend.Infrastructure.Repository.Interface;

namespace FarmBookingBackend.Infrastructure.Repository.Implemintaion
{
    public class FarmRoomRepository : Repository<FarmRoom>, IFarmRoomRepository


    {


        private readonly ApplicationDbContext _db;

        public FarmRoomRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void update(FarmRoom farmNumber)
        {
            _db.FarmRooms.Update(farmNumber);
        }
    }
}
