using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_cris2
{
    internal class NorthwindContext : DbContext
    {
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Productos> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Northwind_personalidado;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedores>()
                .HasKey(p => p.ProveedorId);

            modelBuilder.Entity<Productos>()
                .HasKey(p => p.ProductoId);

            modelBuilder.Entity<Productos>()
                .HasOne(p => p.Proveedor)
                .WithMany(p => p.Productos)
                .HasForeignKey(p => p.ProveedorId);
        }
    }
}
