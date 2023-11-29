using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "623faaa6-95ac-4734-81c2-b504b40a9b84",
                    Name = "SystemAdmin",
                    NormalizedName = "SystemAdmin",

                },
                new IdentityRole
                {
                    Id = "b1b0ea46-75e8-4106-8008-28e461666acf",
                    Name = "Admin",
                    NormalizedName = "Admin",

                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "User",

                });
        }
    }
}
