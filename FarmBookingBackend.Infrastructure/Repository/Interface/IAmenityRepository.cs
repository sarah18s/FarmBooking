using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Infrastructure.Repository.Interface
{
    public interface IAmenityRepository : IRepository<Amenity>
    {
        void update(Amenity amenity);
    }
}
