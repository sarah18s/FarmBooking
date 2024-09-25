using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Domain.Enum;

namespace FarmBookingBackend.Infrastructure.Context
{
    public class ApplicationDbContext (DbContextOptions options):IdentityDbContext<ApplicationUser>(options)
    {


        public DbSet<Farm> Farms { get; set; }
        public DbSet<FarmRoom> FarmRooms { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = Role.CUSTOMER.ToString().ToLower(),
                    NormalizedName = Role.CUSTOMER.ToString().ToUpper()
                },
                 new IdentityRole
                 {
                     Name = Role.ADMIN.ToString().ToLower(),
                     NormalizedName = Role.ADMIN.ToString().ToUpper()
                 }
                );




            modelBuilder.Entity<Farm>().HasData(
                new Farm
                {
                    Id = 1,
                    Name = "Royal Farm",
                    Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\VillaImage\\a78075cc-2905-4471-a578-1d5fe3945fcd.jpg",
                    Occupancy = 4,
                    Price = 200,
                    Sqft = 550,
                },
                    new Farm
                    {
                        Id = 2,
                        Name = "Premium Pool Farm",
                        Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        ImageUrl = "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\VillaImage\\cac7e1b4-5ba4-493f-9b73-14434d5b56d7.jpg",
                        Occupancy = 4,
                        Price = 300,
                        Sqft = 550,
                    },
                    new Farm
                    {
                        Id = 3,
                        Name = "Luxury Pool Farm",
                        Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        ImageUrl = "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\VillaImage\\d75cb0ad-9ed1-46af-87bc-fa99e00b2e58.jpg",
                        Occupancy = 4,
                        Price = 400,
                        Sqft = 750,
                    });

            modelBuilder.Entity<FarmRoom>().HasData(
                new FarmRoom
                {
                    FarmRoom_Number = 101,
                    FarmId = 1,
                    SpecialDetails = "Master bedroom",
                    
                },
                new FarmRoom
                {
                    FarmRoom_Number = 102,
                    FarmId = 1,
                    SpecialDetails = "has 3 bed",
                },
                new FarmRoom
                {
                    FarmRoom_Number = 103,
                    FarmId = 1,
                    SpecialDetails = "has 3 bed",
                },
                new FarmRoom
                {
                    FarmRoom_Number = 104,
                    FarmId = 1,
                    SpecialDetails = "has 2 bed",
                },
                new FarmRoom
                {
                    FarmRoom_Number = 201,
                    FarmId = 2,
                    SpecialDetails = "Master bedroom",
                },
                new FarmRoom
                {
                    FarmRoom_Number = 202,
                    FarmId = 2,
                    SpecialDetails = "has 2 bed",
                },
                new FarmRoom
                {
                    FarmRoom_Number = 203,
                    FarmId = 2,
                    SpecialDetails = "has 2 bed",
                },
                new FarmRoom
                {
                    FarmRoom_Number = 301,
                    FarmId = 3,
                    SpecialDetails = "Master bedroom",
                },
                new FarmRoom
                {
                    FarmRoom_Number = 302,
                    FarmId = 3,
                    SpecialDetails = "has 2 bed",
                }
                );

            _ = modelBuilder.Entity<Amenity>().HasData(
          new Amenity
          {
              Id = 1,
              FarmId = 1,
              Name = "Private Pool"
          }, new Amenity
          {
              Id = 2,
              FarmId = 1,
              Name = "Microwave"
          }, new Amenity
          {
              Id = 3,
              FarmId = 1,
              Name = "Private Balcony"
          },


          new Amenity
          {
              Id = 5,
              FarmId = 2,
              Name = "Private Plunge Pool"
          }, new Amenity
          {
              Id = 6,
              FarmId = 2,
              Name = "Microwave and Mini Refrigerator"
          }, new Amenity
          {
              Id = 7,
              FarmId = 2,
              Name = "Private Balcony"
          },


          new Amenity
          {
              Id = 9,
              FarmId = 3,
              Name = "Private Pool"
          }, new Amenity
          {
              Id = 10,
              FarmId = 3,
              Name = "Jacuzzi"
          }, new Amenity
          {
              Id = 11,
              FarmId = 3,
              Name = "Private Balcony"
          });

        }
    }
}