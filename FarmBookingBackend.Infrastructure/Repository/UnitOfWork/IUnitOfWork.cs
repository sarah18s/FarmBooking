using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmBookingBackend.Infrastructure.Repository.Interface;

namespace FarmBookingBackend.Infrastructure.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {

        IFarmRoomRepository FarmRoom{ get; set; }
        IFarmRepository Farm { get; set; }
        IApplicationUserRepository ApplicationUser { get; set; }
        IAmenityRepository Amenity { get; set; }
        IBookingRepository Booking { get; set; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
