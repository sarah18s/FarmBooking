using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Web.Controllers
{
    
    [Controller]
    [Route("Api/[Controller]")]
    public class AccountController(IAccountServices _accountServices) : ControllerBase
    {

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            
            var result = await _accountServices.Register(registerModel);
            return Ok(result);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return Ok(new Result { Code = 400, Error = "The Model Is Invalid" });

            }
            var result = await _accountServices.Login(loginModel);
            return Ok(result);
        }

        //[Authorize(Roles = "Admin")]
        [HttpGet("AddAdmin")]
        public async Task<IActionResult> AddAdmin([FromQuery]String email)
        {
            var result = await _accountServices.AdminRegistration(email);
            return Ok(result);
        }

        
    }
}
