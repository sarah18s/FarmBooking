using FarmBookingBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmBookingBackend.Infrastructure.Data.Config
{
    public class FarmRoomConfiguration : IEntityTypeConfiguration<FarmRoom>
    {
        public void Configure(EntityTypeBuilder<FarmRoom> builder)
        {
            builder.HasData(LoadData());
        }
        private static List<FarmRoom> LoadData()
        {
            return
                [
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
                ];
        }
    }
}
