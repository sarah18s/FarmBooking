using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Infrastructure.Data;
using FarmBookingBackend.Infrastructure.Repository.Interface;

namespace FarmBookingBackend.Infrastructure.Repository.Implemintaion
{
    public class BookingRepository(ApplicationDbContext _db) : Repository<Booking>(_db), IBookingRepository
    {

        public void update(Booking booking)
        {
            _db.Bookings.Update(booking);
        }
    }
}

