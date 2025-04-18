using DemoRepositoryDemo.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepositoryPattern.Infraestructure.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .IsRequired(true)
                .HasMaxLength(160)
                .HasColumnType("VARCHAR");
        }
    }
}
