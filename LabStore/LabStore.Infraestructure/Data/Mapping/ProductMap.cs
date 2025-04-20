using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LabStore.Domain.Entities;

namespace LabStore.Infraestructure.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired(true)
                .HasMaxLength(160)
                .HasColumnType("VARCHAR");
        }
    }
}
