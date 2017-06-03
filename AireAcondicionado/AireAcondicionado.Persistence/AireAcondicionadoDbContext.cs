using AireAcondicionado.Entities.Entities;
using AireAcondicionado.Persistence.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireAcondicionado.Persistence
{
    public class AireAcondicionadoDbContext : DbContext
    {
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ComprobantePago> ComprobantePagos { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<FormaPago> FormaPagos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Ubigeo> Ubigeos { get; set; }

        public AireAcondicionadoDbContext() : base("AireAcondicionado")
		{

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacen>().Property(v => v.modelo)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Almacen>().Property(v => v.capacidad)
                .IsRequired()
                .HasColumnType("int");

            modelBuilder.Entity<Almacen>().Property(v => v.cantidad)
                .IsRequired()
                .HasColumnType("int");

            modelBuilder.Entity<Almacen>().Property(v => v.precioCompra)
                .IsRequired()
                .HasColumnType("double");

            modelBuilder.Entity<Almacen>().Property(v => v.precioVenta)
                .IsRequired()
                .HasColumnType("double");

            modelBuilder.Entity<Almacen>().Property(v => v.descuento)
                .IsRequired()
                .HasColumnType("double");

            modelBuilder.Entity<Almacen>().HasRequired(v => v.Producto)
                .WithMany(g => g.Almacenes)
                .HasForeignKey(v => v.ProductoId);

            modelBuilder.Entity<Cargo>().Property(v => v.nomCargo)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Cliente>().Map<CliNatural>(m => m.Requires("Descriminador").HasValue("CliNatural"));
            modelBuilder.Entity<Cliente>().Map<CliEmpresa>(m => m.Requires("Descriminador").HasValue("CliEmpresa"));

            modelBuilder.Entity<ComprobantePago>().Property(v => v.tipoComprobante)
               .IsRequired()
               .HasMaxLength(150);

            modelBuilder.Entity<ComprobantePago>().Property(v => v.cantidad)
                .IsRequired()
                .HasColumnType("int");

            modelBuilder.Entity<ComprobantePago>().Property(v => v.descripcion)
               .IsRequired()
               .HasMaxLength(150);

            modelBuilder.Entity<ComprobantePago>().Property(v => v.total)
                .IsRequired()
                .HasColumnType("double");

            modelBuilder.Entity<ComprobantePago>().Property(v => v.fechaPago)
                .IsRequired()
                .HasColumnType("DateTime");

            modelBuilder.Entity<ComprobantePago>().HasRequired(v => v.Cliente)
                .WithMany(g => g.ComprobantePagos)
                .HasForeignKey(v => v.ClienteId);

            modelBuilder.Entity<Contrato>().Property(v => v.fechaInicio)
                .IsRequired()
                .HasColumnType("DateTime");

            modelBuilder.Entity<Contrato>().Property(v => v.fechaCulminacion)
                .IsRequired()
                .HasColumnType("DateTime");

            modelBuilder.Entity<Contrato>().Property(v => v.fechaGarantia)
                .IsRequired()
                .HasColumnType("DateTime");

            modelBuilder.Entity<Contrato>().HasRequired(v => v.Almacen)
                .WithMany(g => g.Contratos)
                .HasForeignKey(v => v.AlmacenId);

            modelBuilder.Entity<Contrato>().HasRequired(v => v.FormaPago)
                .WithMany(g => g.Contratos)
                .HasForeignKey(v => v.FormaPagoId);

            modelBuilder.Entity<Contrato>().HasRequired(v => v.Cotizacion)
                .WithMany(g => g.Contratos)
                .HasForeignKey(v => v.CotizacionId);

            modelBuilder.Entity<Contacto>().Property(v => v.contacto)
               .IsRequired()
               .HasMaxLength(200);

            modelBuilder.Entity<Cotizacion>().Property(v => v.fechaVisita)
                .IsRequired()
                .HasColumnType("DateTime");

            modelBuilder.Entity<Cotizacion>().Property(v => v.tipoServicio)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Cotizacion>().Property(v => v.componente)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Cotizacion>().Property(v => v.caracteristica)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Cotizacion>().Property(v => v.costo)
                .IsRequired()
                .HasColumnType("double");

            modelBuilder.Entity<Cotizacion>().HasRequired(v => v.Trabajador)
                .WithMany(g => g.Cotizaciones)
                .HasForeignKey(v => v.TrabajadorId);

            modelBuilder.Entity<Cotizacion>().HasRequired(v => v.Cliente)
                .WithMany(g => g.Cotizaciones)
                .HasForeignKey(v => v.ClienteId);

            modelBuilder.Entity<Departamento>().Property(v => v.nomDepartamento)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Distrito>().Property(v => v.nomDistrito)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Documento>().Property(v => v.tipoDocumento)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<FormaPago>().Property(v => v.tipoPago)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Provincia>().Property(v => v.nomProvincia)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Proveedor>().Property(v => v.nomProveedor)
                .IsRequired()
                .HasMaxLength(150);


            modelBuilder.Entity<Proveedor>().Property(v => v.direccion)
                .IsRequired()
                .HasMaxLength(150);


            modelBuilder.Entity<Proveedor>().Property(v => v.telefono)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Producto>().Property(v => v.nomProducto)
                .IsRequired()
                .HasMaxLength(200);

            modelBuilder.Entity<Persona>().ToTable("Persona");
            modelBuilder.Entity<Persona>().HasKey(p => p.PersonaId);
            modelBuilder.Entity<Persona>().Property(p => p.nombre).IsRequired();
            modelBuilder.Entity<Persona>().Property(p => p.direccion).IsRequired();
            modelBuilder.Entity<Persona>().Property(p => p.numDocumento).IsRequired();

            modelBuilder.Entity<Persona>().Map<Trabajador>(m => m.Requires("Discriminador").HasValue("Trabajador"));
            modelBuilder.Entity<Persona>().Map<Cliente>(m => m.Requires("Discriminador").HasValue("Cliente"));

            modelBuilder.Entity<Persona>().HasRequired(v => v.Documento)
                .WithMany(g => g.Personas)
                .HasForeignKey(v => v.DocumentoId);

            modelBuilder.Entity<Persona>().HasRequired(v => v.Ubigeo)
                .WithMany(g => g.Personas)
                .HasForeignKey(v => v.UbigeoId);

            modelBuilder.Entity<Persona>().HasMany(v => v.Contactos)
                .WithMany(t => t.Personas)
                .Map(m =>
                {
                    m.ToTable("PersonaContacto");
                    m.MapLeftKey("PersonaId");
                    m.MapRightKey("ContactoId");
                });

            modelBuilder.Entity<Ubigeo>().HasRequired(v => v.Distrito)
                .WithMany(g => g.Ubigeos)
                .HasForeignKey(v => v.DistritoId);


            modelBuilder.Entity<Ubigeo>().HasRequired(v => v.Departamento)
                .WithMany(g => g.Ubigeos)
                .HasForeignKey(v => v.DepartamentoId);


            modelBuilder.Entity<Ubigeo>().HasRequired(v => v.Provincia)
                .WithMany(g => g.Ubigeos)
                .HasForeignKey(v => v.ProvinciaId);

            modelBuilder.Entity<Trabajador>().Property(v => v.sueldo)
               .IsRequired()
               .HasColumnType("double");

            modelBuilder.Entity<Trabajador>().Property(v => v.bono)
               .IsRequired()
               .HasColumnType("double");

            modelBuilder.Entity<Trabajador>().HasRequired(v => v.Cargo)
                .WithMany(g => g.Trabajadores)
                .HasForeignKey(v => v.CargoId);

            modelBuilder.Entity<Servicio>().HasRequired(v => v.Cotizacion)
                .WithMany(g => g.Servicios)
                .HasForeignKey(v => v.CotizacionId);

            modelBuilder.Entity<Servicio>().HasMany(v => v.Trabajadores)
                .WithMany(t => t.Servicios)
                .Map(m =>
                {
                    m.ToTable("ServicioTrabjador");
                    m.MapLeftKey("ServicioId");
                    m.MapRightKey("TrabajadorId");
                });



            //modelBuilder.Configurations.Add(new AlmacenConfiguration());
            //modelBuilder.Configurations.Add(new CargoConfiguration());
            //modelBuilder.Configurations.Add(new CliEmpresaConfiguration());
            //modelBuilder.Configurations.Add(new ClienteConfiguration());
            //modelBuilder.Configurations.Add(new CliNaturalConfiguration());
            //modelBuilder.Configurations.Add(new ComprobantePagoConfiguration());
            //modelBuilder.Configurations.Add(new ContactoConfiguration());
            //modelBuilder.Configurations.Add(new ContratoConfiguration());
            //modelBuilder.Configurations.Add(new CotizacionConfiguration());
            //modelBuilder.Configurations.Add(new DepartamentoConfiguration());
            //modelBuilder.Configurations.Add(new DistritoConfiguration());
            //modelBuilder.Configurations.Add(new DocumentoConfiguration());
            //modelBuilder.Configurations.Add(new FormaPagoConfiguration());
            //modelBuilder.Configurations.Add(new PedidoConfiguration());
            //modelBuilder.Configurations.Add(new PersonaConfiguration());
            //modelBuilder.Configurations.Add(new ProductoConfiguration());
            //modelBuilder.Configurations.Add(new ProveedorConfiguration());
            //modelBuilder.Configurations.Add(new ProvinciaConfiguration());
            //modelBuilder.Configurations.Add(new ServicioConfiguration());
            //modelBuilder.Configurations.Add(new TrabajadorConfiguration());
            //modelBuilder.Configurations.Add(new UbigeoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
