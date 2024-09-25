using AutoMapper;
using Microsoft.AspNetCore.Identity;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Domain.Enum;
using System.IdentityModel.Tokens.Jwt;

namespace FarmBookingBackend.Application.Services.Implemintation;

public class AccountService : IAccountServices
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IMapper _mapper;
    private readonly IJWTServices _jWT;
    private readonly IEmailService _emailService;
    public AccountService
        (UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
         IMapper mapper,
         IJWTServices jWT,
         SignInManager<ApplicationUser> signInManager,
         IEmailService emailService
        )
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _mapper = mapper;
        _jWT = jWT;
        _signInManager = signInManager;
        _emailService = emailService;
    }

    public async Task<Result> AdminRegistration(String email)
    {
        var registrationLink = $"http://localhost:3000/adminRegister?email={email}";

        var message = $@"
            Dear User,

            You have been invited to register for our Farm Booking System. Please click on the link below to complete your registration:

            <a href=""{registrationLink}"">Register Now</a>

            Thank you,
            The Farm Booking System Team
        ";

        await _emailService.SendEmailAsync(email, "Registration Invitation", message);


        return new Result { Response = "Registration email sent successfully!" };
    }


    public async Task<Result> Login(LoginModel model)
    {

        Result result = new();
        ApplicationUser? user = await _userManager.FindByEmailAsync(model.Email);
        if (user is not null && await _userManager.CheckPasswordAsync(user, model.Password))
        {

            var jwtSecurityToken = await _jWT.CreateJwtToken(user);

            result.Response = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            result.Code = 200;
        }
        else
        {
            result.Code = 400;
            result.Error = "Email or Password is incorrect!";
        }
        return result;
    }

    public async Task<Result> Logout()
    {
        await _signInManager.SignOutAsync();
        return new Result { Code = 200 };
    }

    public async Task<Result> Register(RegisterModel model)
    {
        Result result = new();
        if (await _userManager.FindByEmailAsync(model.Email) is not null)
        {
            result.Code = 400;
            result.Error = "The User is already exist";
        }
        else
        {
            ApplicationUser MapUser = _mapper.Map<ApplicationUser>(model);
            var CreateUser = await _userManager.CreateAsync(MapUser, model.Password);

            if (CreateUser.Succeeded)
            {
                await _userManager.AddToRoleAsync(MapUser, model.Role);

                var jwtSecurityToken = await _jWT.CreateJwtToken(MapUser);
                result.Response = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
                result.Code = 200;

            }
            else
            {
                result.Code = 400;

                var errors = string.Empty;

                foreach (var error in CreateUser.Errors)
                    errors += $"{error.Description},";
                result.Error = errors;
            }
           
        }
        return result;

                
    }
}
