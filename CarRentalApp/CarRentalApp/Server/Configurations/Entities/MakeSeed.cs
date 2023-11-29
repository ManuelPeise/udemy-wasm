using CarRentalApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedAt = DateTime.Now,
                    Name = "Audi"
                },
                new Make
                {
                    Id = 2,
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedAt = DateTime.Now,
                    Name = "Renault"
                },
                new Make
                {
                    Id = 3,
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedAt = DateTime.Now,
                    Name = "VW"
                });
        }
    }
}
