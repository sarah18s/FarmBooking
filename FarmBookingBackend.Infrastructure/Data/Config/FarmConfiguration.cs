using FarmBookingBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmBookingBackend.Infrastructure.Data.Config
{
    public class FarmConfiguration : IEntityTypeConfiguration<Farm>
    {
        public void Configure(EntityTypeBuilder<Farm> builder)
        {
            builder.HasData(LoadData());
        }

        private static List<Farm> LoadData()
        {
            return
            [
                new()
                {
                    Id = 1,
                    Name = "Royal Farm",
                    Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\VillaImage\\a78075cc-2905-4471-a578-1d5fe3945fcd.jpg",
                    Occupancy = 4,
                    Price = 200,
                    Sqft = 550,
                },
                new()
                {
                    Id = 2,
                    Name = "Premium Pool Farm",
                    Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\VillaImage\\cac7e1b4-5ba4-493f-9b73-14434d5b56d7.jpg",
                    Occupancy = 4,
                    Price = 300,
                    Sqft = 550,
                },
                new()
                {
                    Id = 3,
                    Name = "Luxury Pool Farm",
                    Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\VillaImage\\d75cb0ad-9ed1-46af-87bc-fa99e00b2e58.jpg",
                    Occupancy = 4,
                    Price = 400,
                    Sqft = 750,
                }

            ];
        }
    }
}
