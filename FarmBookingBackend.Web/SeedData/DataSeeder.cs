using Microsoft.AspNetCore.Identity;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Web.SeedData
{
    public static class DataSeeder
    {
        public static async Task SeedDataAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var powerUser = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@example.com",
                PhoneNumber = "123456789",
            };

            string userPassword = "Admin@123";
            var user = await userManager.FindByEmailAsync("admin@example.com");

            if (user == null)
            {
                var createPowerUser = await userManager.CreateAsync(powerUser, userPassword);
                if (createPowerUser.Succeeded)
                {
                    await userManager.AddToRoleAsync(powerUser, "Admin");
                }
            }
        }
    }
}
