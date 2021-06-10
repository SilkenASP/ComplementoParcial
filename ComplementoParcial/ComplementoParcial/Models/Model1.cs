using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ComplementoParcial.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<artista> artista { get; set; }
        public virtual DbSet<canciones> canciones { get; set; }
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<DetallePedido> DetallePedido { get; set; }
        public virtual DbSet<discos> discos { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<artista>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<artista>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<artista>()
                .Property(e => e.lugarNacimiento)
                .IsUnicode(false);

            modelBuilder.Entity<artista>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<canciones>()
                .Property(e => e.cancion)
                .IsUnicode(false);

            modelBuilder.Entity<categoria>()
                .Property(e => e.nombreCategoria)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<discos>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<discos>()
                .Property(e => e.formato)
                .IsUnicode(false);

            modelBuilder.Entity<discos>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<discos>()
                .Property(e => e.imagen)
                .IsUnicode(false);

            modelBuilder.Entity<discos>()
                .HasMany(e => e.DetallePedido)
                .WithOptional(e => e.discos)
                .HasForeignKey(e => e.iddiscos);

            modelBuilder.Entity<empleado>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<Pedido>()
                .Property(e => e.direccionEntrega)
                .IsUnicode(false);
        }
    }
}
