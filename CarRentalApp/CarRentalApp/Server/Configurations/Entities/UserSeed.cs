using CarRentalApp.Server.Models;
using CarRentalApp.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                new ApplicationUser
                {
                    Id = "90b0139e-200d-47b4-ab90-ae27d532c351",
                    Email = "admin@carrental.com",
                    EmailConfirmed = true,
                    NormalizedEmail = "admin@carrental.com".ToUpper(),
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "admin@carrental.com",
                    NormalizedUserName = "admin@carrental.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                });
        }
    }
}
