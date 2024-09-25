using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmBookingBackend.Infrastructure.Context;
using FarmBookingBackend.Infrastructure.Repository.Implemintaion;
using FarmBookingBackend.Infrastructure.Repository.Interface;

namespace FarmBookingBackend.Infrastructure.Repository.UnitOfWork
{
    public class UnitOfWork(ApplicationDbContext applicationDbContext) : IUnitOfWork
    {
        public IFarmRoomRepository FarmRoom{ get; set; } = new FarmRoomRepository(applicationDbContext);
        public IFarmRepository Farm { get; set; } = new FarmRepository(applicationDbContext);
        public IApplicationUserRepository ApplicationUser { get; set; } = new ApplicationUserRepository(applicationDbContext);
        public IAmenityRepository Amenity { get; set; } = new AmenityRepository(applicationDbContext);
    
        public IBookingRepository Booking { get; set; } = new BookingRepository(applicationDbContext);

        public void SaveChanges()
        {
            applicationDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
           await applicationDbContext.SaveChangesAsync();
        }
    }
}
