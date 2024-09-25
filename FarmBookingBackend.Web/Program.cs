using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Syncfusion.Licensing;
using FarmBooking.Application.Services.Implementation;
using FarmBookingBackend.Application.Services.Implemintation;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Domain.Helper;
using FarmBookingBackend.Infrastructure.Context;
using FarmBookingBackend.Infrastructure.Repository.Implemintaion;
using FarmBookingBackend.Infrastructure.Repository.Interface;
using FarmBookingBackend.Infrastructure.Repository.UnitOfWork;
using FarmBookingBackend.Web.SeedData;
using AccountService = FarmBookingBackend.Application.Services.Implemintation.AccountService;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:3000") // Your front-end URL
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IAccountServices, AccountService>();
builder.Services.AddScoped<IFarmService, FarmService>();
builder.Services.AddScoped<IAmenityService, AmenityService>();
builder.Services.AddScoped<IFarmRoomService, FarmRoomService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IPaymentService , PaymentService>();
builder.Services.AddScoped<IJWTServices, JWTServices>();
builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IFarmRoomRepository, FarmRoomRepository>();
builder.Services.AddScoped<IFarmRepository, FarmRepository>();
builder.Services.AddScoped<IAmenityRepository , AmenityRepository>();
builder.Services.AddScoped<IBookingRepository , BookingRepository>();
builder.Services.AddScoped<IApplicationUserRepository , ApplicationUserRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));
builder.Services.Configure<MailSetting>(builder.Configuration.GetSection("MailSetting"));

var app = builder.Build();
StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "images")),
    RequestPath = "/images" // Adjust the request path as needed
});

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;


    await DataSeeder.SeedDataAsync(services);
}

app.Run();
