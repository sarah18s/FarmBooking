using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Infrastructure.Repository.Interface
{
    public interface IFarmRepository : IRepository<Farm>
    {
        void update(Farm farm);
    }
}
