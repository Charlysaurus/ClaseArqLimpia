using Libreria.Business.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Libreria.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {

        }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        //Declarando entidades
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().Property(t => t.AutorId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Libro>().Property(t => t.LibroId).ValueGeneratedOnAdd();


            //FK
            modelBuilder.Entity<Autor>().HasMany(t=>t.Libro).WithOne(t => t.Autor).HasForeignKey(t=>t.AutorId);

            //modelBuilder.Entity<Room>().HasMany(t=>t.Reservations).WithOne(t=>t.Room).HasForeignKey(t=>t.RoomId);

            base.OnModelCreating(modelBuilder);
        }


    }
}

