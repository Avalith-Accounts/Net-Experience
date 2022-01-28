using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net.Experience.Domain.Entities;

namespace Net.Experience.Persistance.Sql.Configuration
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Items");
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.Property(e => e.Title);
            entityTypeBuilder.Property(e => e.Despription)
                             .HasMaxLength(50);
        }
    }
}
