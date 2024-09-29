using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Application.Services.Interface
{
    public interface IAccountServices
    {
        public Task<Result> Register(RegisterModel model);
        public Task<Result> Login(LoginModel model);
        
        public Task<Result> AdminRegistration(String email);
    }
}
