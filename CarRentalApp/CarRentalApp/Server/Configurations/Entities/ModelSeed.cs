using CarRentalApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class ModelSeed : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                    UpdatedBy = "System",
                    UpdatedAt = DateTime.Now,
                    Name = "A4",
                },
                 new Model
                 {
                     Id = 2,
                     CreatedBy = "System",
                     CreatedAt = DateTime.Now,
                     UpdatedBy = "System",
                     UpdatedAt = DateTime.Now,
                     Name = "Cool",
                 },
                  new Model
                  {
                      Id = 3,
                      CreatedBy = "System",
                      CreatedAt = DateTime.Now,
                      UpdatedBy = "System",
                      UpdatedAt = DateTime.Now,
                      Name = "Work",
                  });
        }
    }
}
