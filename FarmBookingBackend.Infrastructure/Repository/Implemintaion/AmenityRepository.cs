using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Infrastructure.Data;
using FarmBookingBackend.Infrastructure.Repository.Interface;

namespace FarmBookingBackend.Infrastructure.Repository.Implemintaion
{
    public class AmenityRepository : Repository<Amenity>, IAmenityRepository
    {
        private readonly ApplicationDbContext _db;

        public AmenityRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }
        public void update(Amenity amenity)
        {
            _db.Amenities.Update(amenity);
        }
    }
}
