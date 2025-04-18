using DemoRepositoryDemo.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DemoRepositoryPattern.Infraestructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = Assembly.LoadFrom("DemoRepositoryPattern");
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        }
    }
}
