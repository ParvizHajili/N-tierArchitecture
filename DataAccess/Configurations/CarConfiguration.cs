using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(x => x.Id)
                .UseIdentityColumn(seed: 100, increment: 1);

            builder.Property(x => x.Marka)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Model)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(x => x.Color)
               .HasMaxLength(100)
               .IsRequired();

            builder.HasIndex(x => x.Marka);

            builder.HasIndex(x => new { x.Marka, x.Deleted })
                .IsUnique();
        }
    }
}
