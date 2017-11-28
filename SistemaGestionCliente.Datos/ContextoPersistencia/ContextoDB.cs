using SistemaGestionCliente.Entidades.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCliente.Datos.ContextoPersistencia
{
    public class ContextoDB : DbContext
    {
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Ciudad> Cuidades { get; set; }
        public DbSet<Sector> Sectores { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public ContextoDB():base("SistemaGestionClienteContexto")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Configuración Entidad Provincia
            var provincia = modelBuilder.Entity<Provincia>();
            provincia.ToTable("Provincias");
            provincia.Property(p => p.Codigo).HasColumnName("CodigoProvincia");
            provincia.HasKey(p => p.Codigo);
            provincia.Property(p => p.Nombre).HasMaxLength(50).IsRequired();
            //provincia.HasMany(p => p.Ciudades).WithOptional().HasForeignKey(x=>x.CodigoProvinciaFK);
            #endregion

            #region Configuración Entidad Ciudad
            var ciudad = modelBuilder.Entity<Ciudad>();
            ciudad.ToTable("Ciudades");
            ciudad.Property(c => c.Codigo).HasColumnName("CodigoCiudad");
            ciudad.HasKey(c => c.Codigo);
            ciudad.Property(p => p.Nombre).HasMaxLength(50).IsRequired();
            ciudad.HasRequired(c => c.Provincia).WithMany(x => x.Ciudades).HasForeignKey(x => x.CodigoProvinciaFK);

            #endregion

            #region Configuración Entidad Sector
            var sector = modelBuilder.Entity<Sector>();
            sector.ToTable("Sectores");
            sector.Property(s => s.Codigo).HasColumnName("CodigoSector");
            sector.HasKey(s => s.Codigo);
            sector.Property(s => s.Nombre).HasMaxLength(50).IsRequired();
            sector.HasRequired(s => s.Ciudad).WithMany(s => s.Sectores).HasForeignKey(s => s.CodigoCiudadFK);
            #endregion

            #region Configuración Entidad Zona
            var zona = modelBuilder.Entity<Zona>();
            zona.ToTable("Zonas");
            zona.Property(z => z.Codigo).HasColumnName("CodigoZona");
            zona.HasKey(z => z.Codigo);
            zona.Property(z => z.Nombre).HasMaxLength(50).IsRequired();
            zona.HasRequired(z => z.Sector).WithMany(z => z.Zonas).HasForeignKey(z => z.CodigoSectorFK);
            #endregion

            #region Configuración Entidad Cliente
            var cliente = modelBuilder.Entity<Cliente>();
            cliente.ToTable("Clientes");
            cliente.Property(c => c.Cedula).HasMaxLength(11).HasColumnName("CodigoCliente");
            cliente.HasKey(c =>c.Cedula );
            cliente.Property(c => c.Nombre).HasMaxLength(50).IsRequired();
            cliente.Property(c => c.Apellido).HasMaxLength(50).IsRequired();
            cliente.Property(c => c.Direccion).HasMaxLength(100).IsRequired();
            cliente.Property(c => c.Telefono).HasMaxLength(10).IsRequired();
            cliente.Property(c => c.Email).HasMaxLength(50);
            cliente.Property(c => c.Contacto).HasMaxLength(50).IsRequired();
            cliente.Property(c => c.TipoCliente).IsOptional();
            cliente.Property(c => c.Estado).IsRequired();
            //cliente.HasOptional(c => c.Zona).WithMany(c => c.Clientes).HasForeignKey(c => c.CodigoZonaPK).WillCascadeOnDelete(false);
            
            #endregion
        }
    }
}
