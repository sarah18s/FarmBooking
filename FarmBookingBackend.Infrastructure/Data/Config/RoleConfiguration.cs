using FarmBookingBackend.Domain.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmBookingBackend.Infrastructure.Data.Config;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(LoadData());
    }
    private static List<IdentityRole> LoadData()
    {
        return
            [
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
            ];
    }
}
