using LabStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LabStore.Infraestructure.Data
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InfraExtension).Assembly);
        }
    }
}
