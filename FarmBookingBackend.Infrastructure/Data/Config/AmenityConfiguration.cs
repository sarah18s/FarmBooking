using FarmBookingBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmBookingBackend.Infrastructure.Data.Config;

public class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
{
    public void Configure(EntityTypeBuilder<Amenity> builder)
    {
        builder.HasData(LoadData());
    }
    private static List<Amenity> LoadData()
    {
        return [
            new ()
            {
                Id = 1,
                FarmId = 1,
                Name = "Private Pool"
            },
            new ()
            {
                Id = 2,
                FarmId = 1,
                Name = "Microwave"
            },
            new()
            {
                Id = 3,
                FarmId = 1,
                Name = "Private Balcony"
            },
            new()
            {
                Id = 5,
                FarmId = 2,
                Name = "Private Plunge Pool"
            },
            new()
            {
                Id = 6,
                FarmId = 2,
                Name = "Microwave and Mini Refrigerator"
            },
            new()
            {
                Id = 7,
                FarmId = 2,
                Name = "Private Balcony"
            },
            new()
            {
                Id = 9,
                FarmId = 3,
                Name = "Private Pool"
            },
            new()
            {
                Id = 10,
                FarmId = 3,
                Name = "Jacuzzi"
            },
            new()
            {
                Id = 11,
                FarmId = 3,
                Name = "Private Balcony"
            }
      ];
    }
}