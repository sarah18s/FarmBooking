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

namespace FarmBookingBackend.Infrastructure.Data
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

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}