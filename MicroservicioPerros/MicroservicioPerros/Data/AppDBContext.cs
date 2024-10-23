using MicroservicioPerros.Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace MicroservicioPerros.Data
{
    public class AppDBContext : DbContext
    {

        public AppDBContext()
        {
            
        }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Dog> Dogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog>().Property(t => t.Id).ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}
