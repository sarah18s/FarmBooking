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
    public class ApplicationUserRepository : Repository<ApplicationUser> , IApplicationUserRepository
    {

        private readonly ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }

    }
}
