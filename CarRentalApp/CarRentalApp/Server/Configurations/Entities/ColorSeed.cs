using CarRentalApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class ColorSeed : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color
                {
                    Id = 1,
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedAt = DateTime.Now,
                    Name = "Black"
                },
                new Color
                {
                    Id = 2,
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedAt = DateTime.Now,
                    Name = "Red"
                },
                 new Color
                 {
                     Id = 3,
                     CreatedBy = "System",
                     CreatedAt = DateTime.Now,
                     UpdatedBy = "System",
                     UpdatedAt = DateTime.Now,
                     Name = "Blue"
                 });
        }
    }
}
