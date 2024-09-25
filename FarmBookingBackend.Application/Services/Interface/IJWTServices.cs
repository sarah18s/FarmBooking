using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Application.Services.Interface
{
    public interface IJWTServices
    {
        public Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user);
    }
}
